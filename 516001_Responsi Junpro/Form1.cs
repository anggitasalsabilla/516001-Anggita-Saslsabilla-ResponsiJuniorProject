using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using _516001_Responsi_Junpro.models;

namespace _516001_Responsi_Junpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_insert.Click += Button_Insert_Click;
            btn_update.Click += Button_Update_Click;
            btn_delete.Click += Button_Delete_Click;
            dgvData.CellClick += DataGridView1_CellClick;


            LoadProyek();
            LoadData();
        }

        private void LoadProyek()
        {
            try
            {
                using var conn = Database.GetConnection();
                string sql = "SELECT id_proyek, nama_proyek FROM proyek ORDER BY nama_proyek";
                using var da = new NpgsqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);

                cmb_proyek.DisplayMember = "nama_proyek";
                cmb_proyek.ValueMember = "id_proyek";
                cmb_proyek.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadProyek Error: " + ex.Message);
            }

            // ensure contract combo has sensible values if not set in Designer
            if (cmb_kontrak.Items.Count == 0)
            {
                cmb_kontrak.Items.AddRange(new[] { "Kontrak", "Kontrak Tetap", "Freelance", "Magang" });
            }
        }

        private void LoadData()
        {
            try
            {
                using var conn = Database.GetConnection();
                string sql = @"SELECT id_dev, nama_dev, id_proyek, status_kontrak, fitur_selesai, jumlah_bug
                               FROM developer ORDER BY id_dev";
                using var da = new NpgsqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dgvData.DataSource = dt;

                // debug: tunjukkan berapa baris ter-load
                MessageBox.Show($"Rows loaded: {dt.Rows.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // tampilkan pesan lengkap agar kamu tahu penyebabnya
                MessageBox.Show("LoadData Error: " + ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private bool ValidateInputs(out decimal fitur, out decimal bug)
        {
            fitur = 0;
            bug = 0;

            if (string.IsNullOrWhiteSpace(txt_nama.Text))
            {
                MessageBox.Show("Nama developer harus diisi.");
                txt_nama.Focus();
                return false;
            }

            if (cmb_proyek.SelectedValue == null || cmb_proyek.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Pilih proyek.");
                cmb_proyek.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_fitur.Text, out fitur))
            {
                MessageBox.Show("Masukkan angka valid untuk fitur selesai (mis. 5).");
                txt_fitur.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_bug.Text, out bug))
            {
                MessageBox.Show("Masukkan angka valid untuk jumlah bug (mis. 2).");
                txt_bug.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txt_nama.Text = "";
            txt_fitur.Text = "";
            txt_bug.Text = "";
            cmb_kontrak.SelectedIndex = -1;
            cmb_proyek.SelectedIndex = -1;
            dgvData.ClearSelection();
        }

        private string GetSelectedId()
        {
            if (dgvData.SelectedRows.Count == 0) return null;
            var cell = dgvData.SelectedRows[0].Cells["id_dev"];
            return cell?.Value?.ToString();
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var f, out var b)) return;

            try
            {
                using var conn = Database.GetConnection();
                string sql = @"INSERT INTO developer (nama_dev, id_proyek, status_kontrak, fitur_selesai, jumlah_bug)
                               VALUES (@nama, @id_proyek, @status, @fitur, @bug)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama", txt_nama.Text.Trim());
                cmd.Parameters.AddWithValue("id_proyek", cmb_proyek.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("status", cmb_kontrak.Text.Trim());
                cmd.Parameters.AddWithValue("fitur", f);
                cmd.Parameters.AddWithValue("bug", b);
                var rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Inserted!" : "No row inserted.");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Error: " + ex.Message);
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (!ValidateInputs(out var f, out var b)) return;

            try
            {
                using var conn = Database.GetConnection();
                string sql = @"UPDATE developer
                               SET nama_dev = @nama,
                                   id_proyek = @id_proyek,
                                   status_kontrak = @status,
                                   fitur_selesai = @fitur,
                                   jumlah_bug = @bug
                               WHERE id_dev = @id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama", txt_nama.Text.Trim());
                cmd.Parameters.AddWithValue("id_proyek", cmb_proyek.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("status", cmb_kontrak.Text.Trim());
                cmd.Parameters.AddWithValue("fitur", f);
                cmd.Parameters.AddWithValue("bug", b);
                cmd.Parameters.AddWithValue("id", id);
                var rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Updated!" : "No row updated.");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Yakin delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                using var conn = Database.GetConnection();
                string sql = "DELETE FROM developer WHERE id_dev = @id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                var rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Deleted!" : "No row deleted.");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvData.Rows[e.RowIndex];
            txt_nama.Text = row.Cells["nama_dev"].Value?.ToString() ?? "";
            txt_fitur.Text = row.Cells["fitur_selesai"].Value?.ToString() ?? "";
            txt_bug.Text = row.Cells["jumlah_bug"].Value?.ToString() ?? "";
            var idProyek = row.Cells["id_proyek"].Value;
            if (idProyek != null)
                cmb_proyek.SelectedValue = idProyek;
            cmb_kontrak.Text = row.Cells["status_kontrak"].Value?.ToString() ?? "";
        }

        // keep unused handlers to satisfy Designer references
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
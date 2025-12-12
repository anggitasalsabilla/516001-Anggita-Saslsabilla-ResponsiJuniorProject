namespace _516001_Responsi_Junpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cmb_kontrak = new ComboBox();
            cmb_proyek = new ComboBox();
            txt_nama = new TextBox();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            txt_bug = new TextBox();
            txt_fitur = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox3 = new GroupBox();
            dgvData = new DataGridView();
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "YUHUUUU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 61);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 1;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Developer :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Pilih Proyek : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 74);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "Status Kontrak : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_kontrak);
            groupBox1.Controls.Add(cmb_proyek);
            groupBox1.Controls.Add(txt_nama);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 108);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Developer";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmb_kontrak
            // 
            cmb_kontrak.FormattingEnabled = true;
            cmb_kontrak.Location = new Point(113, 71);
            cmb_kontrak.Name = "cmb_kontrak";
            cmb_kontrak.Size = new Size(121, 23);
            cmb_kontrak.TabIndex = 7;
            // 
            // cmb_proyek
            // 
            cmb_proyek.FormattingEnabled = true;
            cmb_proyek.Location = new Point(113, 45);
            cmb_proyek.Name = "cmb_proyek";
            cmb_proyek.Size = new Size(121, 23);
            cmb_proyek.TabIndex = 6;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(113, 16);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(136, 23);
            txt_nama.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_bug);
            groupBox2.Controls.Add(txt_fitur);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 88);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 50);
            label9.Name = "label9";
            label9.Size = new Size(166, 15);
            label9.TabIndex = 5;
            label9.Text = "(Jumlah bug yang ditemukan)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 19);
            label8.Name = "label8";
            label8.Size = new Size(164, 15);
            label8.TabIndex = 4;
            label8.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // txt_bug
            // 
            txt_bug.Location = new Point(113, 47);
            txt_bug.Name = "txt_bug";
            txt_bug.Size = new Size(47, 23);
            txt_bug.TabIndex = 3;
            // 
            // txt_fitur
            // 
            txt_fitur.Location = new Point(113, 16);
            txt_fitur.Name = "txt_fitur";
            txt_fitur.Size = new Size(47, 23);
            txt_fitur.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 1;
            label7.Text = "Jumlah Bug : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 0;
            label6.Text = "Fitur Seleksi : ";
            label6.Click += label6_Click;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.Yellow;
            btn_insert.Location = new Point(18, 298);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(113, 47);
            btn_insert.TabIndex = 7;
            btn_insert.Text = "INSERT";
            btn_insert.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Lime;
            btn_update.Location = new Point(137, 298);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(113, 47);
            btn_update.TabIndex = 8;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Cyan;
            btn_delete.Location = new Point(256, 298);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(113, 47);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvData);
            groupBox3.Location = new Point(18, 351);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(742, 157);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(9, 16);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(727, 135);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(137, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(169, 41);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 12;
            label10.Text = "Logo";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(772, 520);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_insert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cmb_kontrak;
        private ComboBox cmb_proyek;
        private TextBox txt_nama;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox txt_bug;
        private TextBox txt_fitur;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox3;
        private DataGridView dgvData;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private Label label10;
    }
}

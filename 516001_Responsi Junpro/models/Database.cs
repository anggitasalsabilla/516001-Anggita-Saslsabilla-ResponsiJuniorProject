using System;
using Npgsql;

namespace _516001_Responsi_Junpro.models
{
    public static class Database
    {
        private static string GetPassword()
        {
            var pw = Environment.GetEnvironmentVariable("PGPASSWORD");
            if (string.IsNullOrWhiteSpace(pw))
            {
                throw new InvalidOperationException("Environment variable PGPASSWORD is not set. Set it (setx PGPASSWORD \"Aanggitaa.02\") or update Database.cs for testing.");
            }
            return pw;
        }

        private static string ConnectionString =>
            $"Host=localhost;Port=5433;Username=postgres;Password= 12345678;Database=516001_Junpro";

        public static NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // optional helper to quickly test connection without UI code
        public static void TestConnection()
        {
            using var c = GetConnection();
            // if no exception thrown, connection OK
            c.Close();
        }
    }
}       
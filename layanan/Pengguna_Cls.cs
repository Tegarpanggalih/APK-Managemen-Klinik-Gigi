using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Dental_Management_System.layanan_
{
    using konfigurasi;

    internal class Pengguna_Cls
    {
        private string connectionString = "server=localhost;database=klinikgigi;user=root;password=;";
        Koneksi_DB_Class server;
        string Query;

        public Pengguna_Cls()
        {
            server = new Koneksi_DB_Class();
            Query = "";
        }

        public bool apakahAdaUser(string uid, string pwd)
        {
            bool cek = false;
            Query = "SELECT * FROM pengguna WHERE user_name=@uid AND password=@pwd";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.Parameters.AddWithValue("@uid", uid);
                command.Parameters.AddWithValue("@pwd", pwd);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    cek = true;
                }
            }

            return cek;
        }

        public string dapatkanNamaPengguna(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT nama_pengguna FROM pengguna WHERE user_name=@username AND password=@password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["nama_pengguna"].ToString();
                    }
                }
            }
            return null;
        }

        public string dapatkanRolePengguna(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT role FROM pengguna WHERE user_name=@username AND password=@password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["role"].ToString();
                    }
                }
            }
            return null;
        }
    }
}

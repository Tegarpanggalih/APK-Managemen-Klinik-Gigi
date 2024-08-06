using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dental_Management_System.konfigurasi
{
    internal abstract class Konfigurasi_Class
    {
        public abstract int eksekusiBukanQuery(string query);
        public abstract DataTable eksekusiQuery(string query);
    }
    internal class Koneksi_DB_Class : Konfigurasi_Class
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string link = "server=localhost;port=3306;database=klinikgigi;uid=root;pwd=";

        public Koneksi_DB_Class()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand(); // instruksi insert dll
            adapter = new MySqlDataAdapter(); // khusus select
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex) { }
        }

        void tutupKoneksi()
        {
            conn.Close();
        }

        public override int eksekusiBukanQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }
    }
}

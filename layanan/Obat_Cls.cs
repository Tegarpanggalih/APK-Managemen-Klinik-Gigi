using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Management_System.layanan_
{
    using konfigurasi;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Security.Cryptography;
    using System.Windows.Forms;
    using System.Xml.Linq;
    internal class Obat_Cls
    {
        private string _id_obat;
        private string _nama_obat;
        private string _jenis_obat;

        Koneksi_DB_Class server;
        DataTable data;
        string Query;

        public Obat_Cls()
        {
            _id_obat = "";
            _nama_obat = "";
            _jenis_obat = "";

            server = new Koneksi_DB_Class();
            data = new DataTable();
            Query = "";
        }

        // property berisi mutator dan asesor

        public string Id_Obat
        {
            set { _id_obat = value; }//mutator method
        }

        public string Nama_Obat
        {
            set { _nama_obat = value; }//mutator method
        }

        public string Jenis_Obat
        {
            set { _jenis_obat = value; }//mutator method
        }

        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "select * from obat where id_obat='" + id + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }


        public int simpanData()
        {
            int result = -1;
            Query = $"insert into obat (id_obat, nama_obat, jenis_obat) " +
                $"values ('{_id_obat}', '{_nama_obat}', '{_jenis_obat}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan!");
                }
                else
                {
                    Console.WriteLine("Data berhasil disimpan."); // Tambahkan pesan sukses
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message); // Tambahkan penanganan pengecualian
            }
            return result;
        }





        public int ubahData(string id)
        {
            int result = -1;
            Query = "update obat set nama_obat='" + _nama_obat + "', jenis_obat='" + _jenis_obat + "' where id_obat='" + id + "'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Diubah.");
                }
            }
            catch (Exception ex) { }
            return result;
        }

        public int hapusData(string id)
        {
            int result = -1;
            Query = "delete from obat where id_obat='" + id + "'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Dihapus.");
                }
            }
            catch (Exception ex) { }
            return result;
        }

        public DataTable tampilData()
        {
            Query = "select * from obat";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilDgNama(string nama)
        {
            Query = "select * from obat where nama_obat like '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public string ambilKodeNama(string nama)
        {
            string kode = "";
            DataTable dl = new DataTable();
            Query = "select id_obat from obat where nama_obat = '" + nama + "'"; // Perbaikan pada query
            dl = server.eksekusiQuery(Query); // Anda perlu mengeksekusi query dan menyimpan hasilnya ke dalam DataTable
            if (dl.Rows.Count > 0)
            {
                kode = dl.Rows[0][0].ToString(); // Mengambil nilai dari kolom pertama dari baris pertama (jika ada)
            }
            return kode;
        }
    }
}

    


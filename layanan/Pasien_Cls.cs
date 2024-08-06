using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Management_System.layanan_
{
    using konfigurasi;
    using MySql.Data.MySqlClient;
    using System.ComponentModel.Design;
    
    using System.Security.Cryptography;
    using System.Windows.Forms;
    using System.Xml.Linq;

    internal class Pasien_Cls
    {
        private string _idpasien;
        private string _namapasien;
        private string _alamatpasien;
        private string _nohppasien;
        private string _tgllahirpasien; // Ubah tipe data menjadi DateTime
        private string _jkpasien; // Ubah tipe data menjadi char
        private string _goldarpasien;
        private string _keluhanpasien;

        Koneksi_DB_Class server;
        DataTable data;
        string Query;


        public Pasien_Cls()
        { //konstruktor
            _idpasien = "";
            _namapasien = "";
            _alamatpasien = "";
            _nohppasien = "";
            _tgllahirpasien = ""; // Inisialisasi dengan nilai default DateTime
            _jkpasien = "";
            _goldarpasien = "";
            _keluhanpasien = "";

            server = new Koneksi_DB_Class();
            data = new DataTable();
            Query = "";
        }

        //property (berisi aksesor/mutator method)
        public string Id_Pasien
        {
            set { _idpasien = value; } //mutator method
            //get { return _id; } //aksesor method
        }

        public string Nama_Pasien
        {
            set { _namapasien = value; }
        }

        public string Alamat_Pasien
        {
            set
            {
                _alamatpasien = value;
            }
        }

        public string TglLahir_Pasien
        {
            set
            {
                _tgllahirpasien = value; // Format tanggal sesuai dengan format yang dibutuhkan oleh database
            }
        }

        public string JK_Pasien
        {
            set
            {
                _jkpasien = value;
            }
        }

        public string Goldar_Pasien
        {
            set
            {
                _goldarpasien = value;
            }
        }

        public string Keluhan_Pasien
        {
            set
            {
                _keluhanpasien = value;
            }
        }

        public string NoHP_Pasien
        {
            set { _nohppasien = value; }
        }


        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "select * from pasien where id_pasien='" + id + "'";
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
            Query = $"insert into pasien (id_pasien, nama_pasien,alamat_pasien,nohp_pasien,tanggal_lahir_pasien, jk_pasien,goldar_pasien, keluhan_pasien) " +
                $"values ('{_idpasien}', '{_namapasien}', '{_alamatpasien}', '{_nohppasien}', '{_tgllahirpasien}', '{_jkpasien}', '{_goldarpasien}', '{_keluhanpasien}')";
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
            Query = "update pasien set nama_pasien='" + _namapasien + "', alamat_pasien='" + _alamatpasien + "', nohp_pasien='" + _nohppasien + "', tanggal_lahir_pasien='" + _tgllahirpasien + "', jk_pasien='" + _jkpasien + "', goldar_pasien='" + _goldarpasien + "', keluhan_pasien='" + _keluhanpasien + "' where id_pasien='" + id + "'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Diubah.");
                }
                else
                {
                    Console.WriteLine("Data berhasil diubah."); // Tambahkan pesan sukses
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message); // Tambahkan penanganan pengecualian
            }
            return result;
        }




        public int hapusData(string id)
        {
            int result = -1;
            Query = "delete from pasien where id_pasien='" + id + "'";
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
            Query = "select * from pasien";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilDgNama(string nama)
        {
            Query = "select * from pasien where nama_pasien like '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public string ambilKodeNama(string nama)
        {
            string kode = "";
            DataTable dl = new DataTable();
            Query = "select id_pasien from pasien where nama_pasien = '" + nama + "'"; // Perbaikan pada query
            dl = server.eksekusiQuery(Query); // Anda perlu mengeksekusi query dan menyimpan hasilnya ke dalam DataTable
            if (dl.Rows.Count > 0)
            {
                kode = dl.Rows[0][0].ToString(); // Mengambil nilai dari kolom pertama dari baris pertama (jika ada)
            }
            return kode;
        }

        //public DataTable getAllJurusan()
        //{
        //    Query = "select p.id_prodi as id_prodi, p.nama_prodi as nama_prodi, j.nama_jurusan as nama_jurusan " +
        //        "from prodi p join jurusan j on j.id_jurusan = p.id_jurusan ";
        //    return server.eksekusiQuery(Query);
        //}

        //public DataTable getComboJurusan()
        //{
        //    Query = "select id_jurusan as id_jurusan,nama_jurusan as nama_jurusan from jurusan";
        //    return server.eksekusiQuery(Query);

        //}
    
    }
}

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

    internal class Dokter_Cls
    {
        private string _iddokter;
        private string _namadokter;
        private string _jkdokter; 
        private string _nohpdokter;

        Koneksi_DB_Class server;
        DataTable data;
        string Query;

      
        public Dokter_Cls()
        { //konstruktor
            _iddokter = "";
            _namadokter = "";
            _jkdokter = "" ;
            _nohpdokter = "";

            server = new Koneksi_DB_Class();
            data = new DataTable();
            Query = "";
        }

        //property (berisi aksesor/mutator method)
        public string Id_Dokter
        {
            set { _iddokter = value; } //mutator method
            //get { return _id; } //aksesor method
        }

        public string Nama_Dokter
        {
            set { _namadokter = value; }
        }

        public string JK_Dokter
    {
        set
        {
                _jkdokter = value;
        }
    }

        public string NoHP_Dokter
        {
            set { _nohpdokter = value; }
        }
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "select * from dokter where id_dokter='" + id + "'";
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
            Query = $"insert into dokter (id_dokter, nama_dokter, jenis_kelamin, nohp_dokter) " +
                $"values ('{_iddokter}', '{_namadokter}', '{_jkdokter}', '{_nohpdokter}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan!");
                }
                else
                {
                    Console.WriteLine("Data berhasil disimpan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message); 
            }
            return result;
        }

       



        public int ubahData(string id)
        {
            int result = -1;
            Query = "update dokter set nama_dokter='" + _namadokter + "', jenis_kelamin='" + _jkdokter + "', nohp_dokter='" + _nohpdokter + "' where id_dokter='" + id + "'";
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
            Query = "delete from dokter where id_dokter='" + id + "'";
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
            Query = "select * from dokter";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilDgNama(string nama)
        {
            Query = "select * from dokter where nama_dokter like '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public string ambilKodeNama(string nama)
        {
            string kode = "";
            DataTable dl = new DataTable();
            Query = "select id_dokter from dokter where nama_dokter = '" + nama + "'"; 
            dl = server.eksekusiQuery(Query); 
            if (dl.Rows.Count > 0)
            {
                kode = dl.Rows[0][0].ToString(); 
            }
            return kode;
        }

    }
}

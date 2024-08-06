using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Management_System.layanan_
{
    using Dental_Management_System.laporan;
    using konfigurasi;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Security.Cryptography;
    using System.Windows.Forms;
    using System.Xml.Linq;
    internal class Diagnosis_Cls
    {
        private string _iddiagnosis;
        private string _idpasien;
        private string _iddokter;
        private string _idobat;
        private string _diagnosis;

        Koneksi_DB_Class server;
        DataTable data;
        string Query;


        public Diagnosis_Cls()
        { //konstruktor
            _iddiagnosis = "";
            _idpasien = "";
            _iddokter = "";
            _idobat = "";
            _diagnosis = "";

            server = new Koneksi_DB_Class();
            data = new DataTable();
            Query = "";
        }

        //property (berisi aksesor/mutator method)
        public string Id_Diagnosis
        {
            set { _iddiagnosis = value; }

        }
        public string Id_Pasien
        {
            set { _idpasien = value; }

        }
        public string Id_Dokter
        {
            set { _iddokter = value; }

        }
        public string Id_Obat
        {
            set { _idobat = value; }

        }


        public string Diagnosis
        {
            set { _diagnosis = value; }
        }
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "select * from diagnosis where id_diagnosis='" + id + "'";
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
            Query = $"INSERT INTO diagnosis (id_diagnosis, id_pasien, id_dokter, id_obat, diagnosis) " +
            $"VALUES ('{_iddiagnosis}',  '{_idpasien}', '{_iddokter}', '{_idobat}', '{_diagnosis}')";
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
            Query = "update diagnosis set id_pasien = '" + _idpasien + "', id_dokter = '" + _iddokter + "' , id_obat = '" + _idobat + "', diagnosis = '" + _diagnosis + "' where id_diagnosis = '" + id + "';";

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
            Query = "delete from diagnosis where id_diagnosis='" + id + "'";
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
            Query = "SELECT d.id_diagnosis AS id_diagnosis, p.nama_pasien AS nama_pasien, dk.nama_dokter AS nama_dokter, o.nama_obat AS nama_obat, " +
                   "d.diagnosis AS diagnosis " +
                   "FROM diagnosis d " +
                   "JOIN pasien p ON d.id_pasien = p.id_pasien " +
                   "JOIN dokter dk ON dk.id_dokter = d.id_dokter " +
                   "JOIN obat o ON o.id_obat = d.id_obat; ";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilDgNama(string nama)
        {
            Query = "SELECT d.id_diagnosis AS id_diagnosis, p.nama_pasien AS nama_pasien, dk.nama_dokter AS nama_dokter, o.nama_obat AS nama_obat, " +
                   "d.diagnosis AS diagnosis " +
                   "FROM diagnosis d " +
                   "JOIN pasien p ON d.id_pasien = p.id_pasien " +
                   "JOIN dokter dk ON dk.id_dokter = d.id_dokter " +
                   "JOIN obat o ON o.id_obat = d.id_obat " +
                   "WHERE p.nama_pasien LIKE '%" + nama + "%';";
            return server.eksekusiQuery(Query);
        }

        //public string ambilKodeDgnNama(string nama, string namaDokter, string namaObat, string namaDiagnosis)
        //{
        //    string kode = " ";
        //    DataTable dt = new DataTable();

        //    string Query = "SELECT d.id_diagnosis, p.id_pasien, dk.id_dokter, o.id_obat, d.diagnosis " +
        //                   "FROM diagnosis d " +
        //                   "JOIN pasien p ON d.id_pasien = p.id_pasien " +
        //                   "JOIN dokter dk ON dk.id_dokter = d.id_dokter " +
        //                   "JOIN obat o ON o.id_obat = d.id_obat " +
        //                   "WHERE p.nama_pasien LIKE '%" + nama + "%' " +
        //                   "AND dk.nama_dokter LIKE '%" + namaDokter + "%' " +
        //                   "AND o.nama_obat LIKE '%" + namaObat + "%' " +
        //                   "AND d.diagnosis LIKE '%" + namaDiagnosis + "%'";

            
        //    dt = server.eksekusiQuery(Query);

            
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow data in dt.Rows)
        //        {
        //            kode = data[0].ToString();
        //        }
        //    }

        //    return kode;
        //}

        public DataTable getAllWithDiagnosis()
        {
            Query = "SELECT d.id_diagnosis AS id_diagnosis, p.nama_pasien AS nama_pasien, dk.nama_dokter AS nama_dokter, o.nama_obat AS nama_obat, d.diagnosis AS diagnosis " +
                    "FROM diagnosis d JOIN dokter dk ON dk.id_dokter = d.id_dokter " +
                    "JOIN obat o ON o.id_obat = d.id_obat " +
                    "JOIN pasien p ON p.id_pasien = d.id_pasien; ";
            return server.eksekusiQuery(Query);
        }

        public DataTable getComboDokter()
        {
            Query = "select id_dokter, nama_dokter from dokter";
            return server.eksekusiQuery(Query);

        }
        public DataTable getComboObat()
        {
            Query = "select id_obat, nama_obat from obat";
            return server.eksekusiQuery(Query);

        }
        public DataTable getComboPasien()
        {
            Query = "select id_pasien, nama_pasien from pasien";
            return server.eksekusiQuery(Query);
        }

    }
}

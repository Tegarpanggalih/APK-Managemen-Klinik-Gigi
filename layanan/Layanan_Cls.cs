using System;
using System.Data;
using System.Windows.Forms;
using Dental_Management_System.konfigurasi;
using Dental_Management_System.laporan;

namespace Dental_Management_System.layanan_
{
    internal class Layanan_Cls
    {
        private string _idlayanan;
        private string _iddiagnosis;
        private string _tgllayanan;
        private string _tindakan;

        Koneksi_DB_Class server;
        DataTable data;
        string Query;

        // Constructor
        public Layanan_Cls()
        {
            _idlayanan = "";
            _iddiagnosis = "";
            _tgllayanan = "";
            _tindakan = "";

            server = new Koneksi_DB_Class();
            data = new DataTable();
            Query = "";
        }

        // Properties
        public string Id_Layanan
        {
            set { _idlayanan = value; }
        }

        public string Id_Diagnosis
        {
            set { _iddiagnosis = value; }
        }

        public string Tgl_Layanan
        {
            set { _tgllayanan = value; }
        }

        public string Tindakan
        {
            set { _tindakan = value; }
        }

        // Methods
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "SELECT * FROM layanan WHERE id_layanan='" + id + "'";
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
            Query = $"INSERT INTO layanan (id_layanan, id_diagnosis, tanggal_layanan, tindakan_layanan) " +
                    $"VALUES ('{_idlayanan}', '{_iddiagnosis}', '{_tgllayanan}', '{_tindakan}')";
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
            Query = $"UPDATE layanan SET id_diagnosis='{_iddiagnosis}', tanggal_layanan='{_tgllayanan}', tindakan_layanan='{_tindakan}' WHERE id_layanan='{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Diubah.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
            return result;
        }

        public int hapusData(string id)
        {
            int result = -1;
            Query = $"DELETE FROM layanan WHERE id_layanan='{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Dihapus.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
            return result;
        }

        public DataTable tampilData()
        {
            Query = "SELECT l.id_layanan AS id_layanan, d.id_diagnosis AS id_diagnosis, l.tanggal_layanan AS tanggal_layanan, l.tindakan_layanan AS tindakan_layanan " +
                    "FROM layanan l " +
                    "JOIN diagnosis d ON d.id_diagnosis = l.id_diagnosis";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilDgNama(string diagnosis_pasien)
        {
            Query = "SELECT l.id_layanan AS id_layanan, d.id_diagnosis AS id_diagnosis, l.tanggal_layanan AS tanggal_layanan, " +
                "l.tindakan_layanan AS tindakan_layanan FROM layanan l JOIN diagnosis d ON d.id_diagnosis = l.id_diagnosis " +
                "WHERE d.id_diagnosis LIKE '%" + diagnosis_pasien + "%';";
            return server.eksekusiQuery(Query);
        }

        public string ambilKodeLayanan(string id_diagnosis)
        {
            string kode = "";
            DataTable dl = new DataTable();
            Query = $"SELECT id_layanan FROM layanan WHERE id_diagnosis = '{id_diagnosis}'";
            dl = server.eksekusiQuery(Query);
            if (dl.Rows.Count > 0)
            {
                kode = dl.Rows[0][0].ToString();
            }
            return kode;
        }

        public DataTable getAllWithLayanan()
        {
            Query = "SELECT l.id_layanan AS id_layanan, d.id_diagnosis AS id_diagnosis, l.tanggal_layanan AS tanggal_layanan," +
                " l.tindakan_layanan AS tindakan_layanan FROM layanan l JOIN diagnosis d ON l.id_diagnosis = d.id_diagnosis;";
            return server.eksekusiQuery(Query);
        }
        public DataTable getComboDiagnosis()
        {
            Query = "select id_diagnosis, diagnosis from diagnosis";
            return server.eksekusiQuery(Query);

        }


    }
}

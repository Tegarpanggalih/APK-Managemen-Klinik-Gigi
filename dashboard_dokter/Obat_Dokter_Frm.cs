using Dental_Management_System.laporan;
using Dental_Management_System.layanan_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Management_System.dashboard_dokter
{
    using Dental_Management_System.layanan_;
    using laporan;
    public partial class Obat_Dokter_Frm : Form
    {
        Obat_Cls obat = new Obat_Cls();
        public Obat_Dokter_Frm()
        {
            InitializeComponent();
            tampilGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Dokter_Frm Obj = new Dashboard_Dokter_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis_Dokter_Frm Obj = new Diagnosis_Dokter_Frm();
            Obj.Show();
            this.Hide();
        }


        private void Logout()
        {
            DialogResult result = MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Dokter_Login_Frm Obj = new Dokter_Login_Frm();
                Obj.Show();
                this.Close();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        void tampilGrid()
        {
            if (cariobat_txb.Text.Equals(""))
            {
                obat_dgv.DataSource = obat.tampilData();
            }
            else
            {
                obat_dgv.DataSource = obat.tampilDgNama(cariobat_txb.Text);
            }
            zebra(obat_dgv); // Menggunakan dokter_dgv sebagai parameter
        }

        void zebra(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (!obat.apakahAda(id_obat_txb.Text))
            {
                obat.Id_Obat = id_obat_txb.Text;
                obat.Nama_Obat = nama_obat_txb.Text;
                obat.Jenis_Obat = jenis_obat_cmb.Text; // Atur jenis obat


                int result = obat.simpanData();
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_obat_txb.Focus();
                    id_obat_txb.Text = "";
                    nama_obat_txb.Text = "";
                    jenis_obat_cmb.Text = "";
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Maaf, terjadi kesalahan saat menyimpan data.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_obat_txb.Focus();
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan diubah?",
                           "KONFIRMASI", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) == DialogResult.Yes)
            {

                obat.Id_Obat = id_obat_txb.Text;
                obat.Nama_Obat = nama_obat_txb.Text;
                obat.Jenis_Obat = jenis_obat_cmb.Text; // Atur jenis obat


                if (obat.ubahData(id_obat_txb.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah.",
                   "INFORMASI", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    id_obat_txb.Focus();
                    id_obat_txb.Text = "";
                    nama_obat_txb.Text = "";
                    jenis_obat_cmb.Text = "";
                    tampilGrid();
                }
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (obat.apakahAda(id_obat_txb.Text))
            {
                if (MessageBox.Show("Yakin data akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obat.hapusData(id_obat_txb.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                       "INFORMASI", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        id_obat_txb.Focus();
                        id_obat_txb.Text = "";
                        nama_obat_txb.Text = "";
                        jenis_obat_cmb.Text = "";
                        tampilGrid();
                    }
                }
            }

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            obat cetak = new obat();
            cetak.ShowDialog(this);
        }

        private void list_obat_lbl_Click(object sender, EventArgs e)
        {

        }

        private void obat_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = obat_dgv.Rows[e.RowIndex]; // Dapatkan baris yang diklik

                // Isi nilai dari sel-sel yang diklik ke dalam kontrol teks sesuai dengan indeks kolom
                id_obat_txb.Text = row.Cells[0].Value.ToString(); // Kolom pertama
                nama_obat_txb.Text = row.Cells[1].Value.ToString(); // Kolom kedua
                jenis_obat_cmb.Text = row.Cells[2].Value.ToString(); // Kolom ketiga
            }
        }

        private void cariobat_txb_OnValueChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btn_cariobat_Click(object sender, EventArgs e)
        {

        }
    }
}
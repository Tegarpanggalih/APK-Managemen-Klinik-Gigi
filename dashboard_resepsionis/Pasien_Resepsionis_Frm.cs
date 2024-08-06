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

namespace Dental_Management_System.dashboard_resepsionis
{
    using laporan;
    public partial class Pasien_Resepsionis_Frm : Form
    {
        Pasien_Cls pasien = new Pasien_Cls();
        public Pasien_Resepsionis_Frm()
        {
            InitializeComponent();
            tampilGrid();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Resepsionis_Frm Obj = new Dashboard_Resepsionis_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Pasien_Resepsionis_Frm Obj = new Pasien_Resepsionis_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            Layanan_Resepsionis_Frm Obj = new Layanan_Resepsionis_Frm();
            Obj.Show();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Logout()
        {
            DialogResult result = MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Admin_Login_Frm Obj = new Admin_Login_Frm();
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
            if (cari_txb.Text.Length == 0)
            {
                pasien_dgv.DataSource = pasien.tampilData();
            }
            else
            {
                pasien_dgv.DataSource = pasien.tampilDgNama(cari_txb.Text);
            }
            zebra(pasien_dgv); // Menggunakan dokter_dgv sebagai parameter
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

        private void tambah_pasien_btn_Click(object sender, EventArgs e)
        {
            if (!pasien.apakahAda(id_pasien_txb.Text))
            {
                pasien.Id_Pasien = id_pasien_txb.Text;
                pasien.Nama_Pasien = nama_pasien_txb.Text;
                pasien.Alamat_Pasien = alamat_pasien_txb.Text;
                pasien.NoHP_Pasien = pasien_nohp_txb.Text;
                pasien.TglLahir_Pasien = tl_pasien.Value.Year.ToString() + "/" + tl_pasien.Value.Month.ToString() + "/" + tl_pasien.Value.Day.ToString(); pasien.JK_Pasien = jk_cmb.Text; // Assuming jk_pasien_cmb is a ComboBox
                pasien.Goldar_Pasien = goldar_cmb.Text; // Assuming jk_pasien_cmb is a ComboBox
                pasien.Keluhan_Pasien = pasien_penyakit_txb.Text;




                int result = pasien.simpanData();
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_pasien_txb.Focus();
                    id_pasien_txb.Text = "";
                    nama_pasien_txb.Text = "";
                    alamat_pasien_txb.Text = "";
                    pasien_nohp_txb.Text = "";
                    tl_pasien.Value = DateTime.Now;
                    jk_cmb.SelectedIndex = -1;
                    goldar_cmb.SelectedIndex = -1;
                    pasien_penyakit_txb.Text = "";
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Maaf, terjadi kesalahan saat menyimpan data.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    id_pasien_txb.Focus();
                }
            }
            else
            {
                MessageBox.Show("Data pasien dengan ID ini sudah ada.",
                    "INFORMASI", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void hapus_pasien_btn_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(id_pasien_txb.Text))
            {
                if (MessageBox.Show("Yakin data akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pasien.hapusData(id_pasien_txb.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                       "INFORMASI", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        id_pasien_txb.Focus();
                        id_pasien_txb.Text = "";
                        nama_pasien_txb.Text = "";
                        alamat_pasien_txb.Text = "";
                        pasien_nohp_txb.Text = "";
                        tl_pasien.Text = "";
                        jk_cmb.Text = "";
                        goldar_cmb.Text = "";
                        pasien_penyakit_txb.Text = "";

                        tampilGrid();
                    }
                }
            }
        }

        private void pasien_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = pasien_dgv.Rows[e.RowIndex]; // Dapatkan baris yang diklik

                // Isi nilai dari sel-sel yang diklik ke dalam kontrol teks sesuai dengan indeks kolom
                id_pasien_txb.Text = row.Cells[0].Value.ToString(); // Kolom pertama
                nama_pasien_txb.Text = row.Cells[1].Value.ToString(); // Kolom kedua
                alamat_pasien_txb.Text = row.Cells[2].Value.ToString(); // Kolom ketiga
                pasien_nohp_txb.Text = row.Cells[3].Value.ToString(); // Kolom keempat
                tl_pasien.Text = row.Cells[4].Value.ToString(); // Kolom kelima
                jk_cmb.Text = row.Cells[5].Value.ToString(); // Kolom keenam
                goldar_cmb.Text = row.Cells[6].Value.ToString(); // Kolom ketujuh
                pasien_penyakit_txb.Text = row.Cells[7].Value.ToString(); // Kolom kedelapan
            }
        }

        private void edit_pasien_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan diubah?",
                       "KONFIRMASI", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //string Jenis_Kelamin = jk_dokter_cmb.SelectedValue.ToString();


                pasien.Id_Pasien = id_pasien_txb.Text;
                pasien.Nama_Pasien = nama_pasien_txb.Text;
                pasien.Alamat_Pasien = alamat_pasien_txb.Text;
                pasien.NoHP_Pasien = pasien_nohp_txb.Text;
                pasien.TglLahir_Pasien = tl_pasien.Value.Year.ToString() + "/" + tl_pasien.Value.Month.ToString() + "/" + tl_pasien.Value.Day.ToString(); pasien.JK_Pasien = jk_cmb.Text; // Assuming jk_pasien_cmb is a ComboBox
                pasien.JK_Pasien = jk_cmb.Text;
                pasien.Goldar_Pasien = goldar_cmb.Text;
                pasien.Keluhan_Pasien = pasien_penyakit_txb.Text;

                if (pasien.ubahData(id_pasien_txb.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah.",
                   "INFORMASI", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    id_pasien_txb.Focus();
                    id_pasien_txb.Text = "";
                    nama_pasien_txb.Text = "";
                    alamat_pasien_txb.Text = "";
                    pasien_nohp_txb.Text = "";
                    tl_pasien.Text = "";
                    jk_cmb.Text = "";
                    goldar_cmb.Text = "";
                    pasien_penyakit_txb.Text = "";
                    tampilGrid();
                }
            }
        }


        private void cari_txb_OnValueChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void cetak_pasien_btn_Click(object sender, EventArgs e)
        {
            pasien cetak = new pasien();
            cetak.ShowDialog(this);
        }
    }
}

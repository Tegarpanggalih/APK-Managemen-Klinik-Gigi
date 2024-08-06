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

namespace Dental_Management_System.dashboard_resepsionis
{
    public partial class Layanan_Resepsionis_Frm : Form
    {
        Layanan_Cls layanan_ = new Layanan_Cls();
        public Layanan_Resepsionis_Frm()
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
            Dashboard_Resepsionis_Frm Obj = new Dashboard_Resepsionis_Frm();
            Obj.Show();
            this.Hide();
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
       
        void tampilGrid()
        {
            if (cari_txb.Text.Length == 0)
            {
                layanan_dgv.DataSource = layanan_.tampilData();
            }
            else
            {
                layanan_dgv.DataSource = layanan_.tampilDgNama(cari_txb.Text);
            }
            zebra(layanan_dgv);
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
            if (!layanan_.apakahAda(id_layanan_txb.Text))
            {
                layanan_.Id_Layanan = id_layanan_txb.Text;
                layanan_.Id_Diagnosis = id_diagnosis_cmb.SelectedValue.ToString();
                layanan_.Tgl_Layanan = tl_layanan.Value.Year.ToString() + "/" + tl_layanan.Value.Month.ToString() + "/" + tl_layanan.Value.Day.ToString();
                layanan_.Tindakan = tindakan_txb.Text;

                int result = layanan_.simpanData();
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_layanan_txb.Focus();
                    id_layanan_txb.Text = "";
                    id_diagnosis_cmb.Text = "";
                    tl_layanan.Value = DateTime.Now;
                    tindakan_txb.Text = "";
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Maaf, terjadi kesalahan saat menyimpan data.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_layanan_txb.Focus();
                }
            }
        }

        private void layanan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = layanan_dgv.Rows[e.RowIndex]; // Dapatkan baris yang diklik

                // Isi nilai dari sel-sel yang diklik ke dalam kontrol teks sesuai dengan indeks kolom
                id_layanan_txb.Text = row.Cells[0].Value.ToString(); // Kolom pertama
                id_diagnosis_cmb.Text = row.Cells[1].Value.ToString(); // Kolom kedua
                tl_layanan.Text = row.Cells[2].Value.ToString(); // Kolom ketiga
                tindakan_txb.Text = row.Cells[3].Value.ToString(); // Kolom keempat
            }
        }


        private void cari_txb_OnValueChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin data akan diubah?",
              "KONFIRMASI", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                layanan_.Id_Layanan = id_layanan_txb.Text;
                layanan_.Id_Diagnosis = id_diagnosis_cmb.SelectedValue.ToString();
                layanan_.Tgl_Layanan = tl_layanan.Value.Year.ToString() + "/" + tl_layanan.Value.Month.ToString() + "/" + tl_layanan.Value.Day.ToString();
                layanan_.Tindakan = tindakan_txb.Text;

                if (layanan_.ubahData(id_layanan_txb.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah.",
                   "INFORMASI", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    id_layanan_txb.Focus();
                    id_layanan_txb.Text = "";
                    id_diagnosis_cmb.Text = "";
                    tl_layanan.Value = DateTime.Now;
                    tindakan_txb.Text = "";
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.",
                    "INFORMASI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (layanan_.apakahAda(id_layanan_txb.Text))
            {
                if (MessageBox.Show("Yakin data akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (layanan_.hapusData(id_layanan_txb.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                       "INFORMASI", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        id_layanan_txb.Focus();
                        id_layanan_txb.Text = "";
                        id_diagnosis_cmb.Text = "";
                        tl_layanan.Text = "";
                        tindakan_txb.Text = "";
                        tampilGrid();
                    }
                }
            }
        }

        private void btnCetak_Click_1(object sender, EventArgs e)
        {
            Dental_Management_System.laporan.layanan cetak = new Dental_Management_System.laporan.layanan();
            cetak.ShowDialog(this);
        }

        private void Layanan_Resepsionis_Frm_Load(object sender, EventArgs e)
        {
            layanan_dgv.DataSource = layanan_.getAllWithLayanan();
            id_diagnosis_cmb.DataSource = layanan_.getComboDiagnosis();
            id_diagnosis_cmb.DisplayMember = "id_diagnosis";
            id_diagnosis_cmb.ValueMember = "id_diagnosis";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            Pasien_Resepsionis_Frm Obj = new Pasien_Resepsionis_Frm();
            Obj.Show();
            this.Hide();

        }
    }
}


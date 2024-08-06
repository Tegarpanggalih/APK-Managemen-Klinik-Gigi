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
    using laporan;
    public partial class Diagnosis_Dokter_Frm : Form
       
    {
        Diagnosis_Cls diagnosis = new Diagnosis_Cls();

        public Diagnosis_Dokter_Frm()
        {
            InitializeComponent();
        }

        private void Diagnosis_Dokter_Frm_Load(object sender, EventArgs e)
        {
            diagnosis_dgv.DataSource = diagnosis.getAllWithDiagnosis();
            id_dokter_cmb.DataSource = diagnosis.getComboDokter();
            id_dokter_cmb.DisplayMember = "nama_dokter";
            id_dokter_cmb.ValueMember = "id_dokter";

            id_obat_cmb.DataSource = diagnosis.getComboObat();
            id_obat_cmb.DisplayMember = "nama_obat";
            id_obat_cmb.ValueMember = "id_obat";

            id_pasien_cmb.DataSource = diagnosis.getComboPasien();
            id_pasien_cmb.DisplayMember = "nama_pasien";
            id_pasien_cmb.ValueMember = "id_pasien";
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
        
            void tampilGrid()
            {
                if (cari_txb.Text.Equals(""))
                {
                    diagnosis_dgv.DataSource = diagnosis.tampilData();
                }
                else
                {
                    diagnosis_dgv.DataSource = diagnosis.tampilDgNama(cari_txb.Text);
                }
                zebra(diagnosis_dgv);
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

            private void tambah_diagnosis_btn_Click(object sender, EventArgs e)
            {
                if (!diagnosis.apakahAda(id_diagnosis_txb.Text))
                {
                    diagnosis.Id_Diagnosis = id_diagnosis_txb.Text;
                    diagnosis.Id_Pasien = id_pasien_cmb.SelectedValue.ToString();
                    diagnosis.Id_Dokter = id_dokter_cmb.SelectedValue.ToString();
                    diagnosis.Id_Obat = id_obat_cmb.SelectedValue.ToString();
                    diagnosis.Diagnosis = diagnosis_txb.Text;

                    int result = diagnosis.simpanData();
                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil disimpan.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        id_diagnosis_txb.Focus();
                        id_diagnosis_txb.Text = "";
                        id_pasien_cmb.Text = "";
                        id_dokter_cmb.Text = "";
                        id_obat_cmb.Text = "";
                        diagnosis_txb.Text = "";
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Maaf, terjadi kesalahan saat menyimpan data.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        id_diagnosis_txb.Focus();
                    }
                }
            }

            private void edit_diagnosis_btn_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Yakin data akan diubah?",
                   "KONFIRMASI", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    diagnosis.Id_Diagnosis = id_diagnosis_txb.Text;
                    diagnosis.Id_Pasien = id_pasien_cmb.SelectedValue.ToString();
                    diagnosis.Id_Dokter = id_dokter_cmb.SelectedValue.ToString();
                    diagnosis.Id_Obat = id_obat_cmb.SelectedValue.ToString();
                    diagnosis.Diagnosis = diagnosis_txb.Text;

                    if (diagnosis.ubahData(id_diagnosis_txb.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah.",
                       "INFORMASI", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        id_diagnosis_txb.Focus();
                        id_diagnosis_txb.Text = "";
                        id_pasien_cmb.Text = "";
                        id_dokter_cmb.Text = "";
                        id_obat_cmb.Text = "";
                        diagnosis_txb.Text = "";
                        tampilGrid(); // Panggil tampilGrid() setelah data diubah
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }


            private void hapus_diagnosis_btn_Click(object sender, EventArgs e)
            {
                if (diagnosis.apakahAda(id_diagnosis_txb.Text))
                {
                    if (MessageBox.Show("Yakin data akan dihapus?",
                        "KONFIRMASI", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (diagnosis.hapusData(id_diagnosis_txb.Text) > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.",
                           "INFORMASI", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                            id_diagnosis_txb.Focus();
                            id_diagnosis_txb.Text = "";
                            id_pasien_cmb.Text = "";
                            id_dokter_cmb.Text = "";
                            id_obat_cmb.Text = "";
                            diagnosis_txb.Text = "";
                            tampilGrid();
                        }
                    }
                }
            }

            private void cetak_diagnosis_btn_Click(object sender, EventArgs e)
            {

                diagnosis cetak = new diagnosis();
                cetak.ShowDialog(this);


            }

            private void diagnosis_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = diagnosis_dgv.Rows[e.RowIndex];

                    // Isi nilai dari sel-sel yang diklik ke dalam kontrol teks sesuai dengan indeks kolom
                    id_diagnosis_txb.Text = row.Cells[0].Value?.ToString();
                    id_pasien_cmb.Text = row.Cells[1].Value?.ToString();
                    id_dokter_cmb.Text = row.Cells[2].Value?.ToString();
                    id_obat_cmb.Text = row.Cells[3].Value?.ToString();
                    diagnosis_txb.Text = row.Cells[4].Value?.ToString();
                }
            }

            private void cari_txb_OnValueChanged(object sender, EventArgs e)
            {
                tampilGrid();
            }

        private void btnMedicine_Click_1(object sender, EventArgs e)
        {
            Obat_Frm Obj = new Obat_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard_Dokter_Frm Obj = new Dashboard_Dokter_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnMedicine_Click_2(object sender, EventArgs e)
        {
            Obat_Dokter_Frm Obj = new Obat_Dokter_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Logout();
        }
    }
}

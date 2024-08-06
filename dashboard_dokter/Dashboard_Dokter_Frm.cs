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
    public partial class Dashboard_Dokter_Frm : Form
    {
        private string namaPengguna;

        public Dashboard_Dokter_Frm()
        {
            InitializeComponent();
        }
        public Dashboard_Dokter_Frm(string namaPengguna)
        {
            InitializeComponent();
            this.namaPengguna = namaPengguna;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis_Dokter_Frm Obj = new Diagnosis_Dokter_Frm();
            Obj.Show();
            this.Hide();
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            Obat_Dokter_Frm Obj = new Obat_Dokter_Frm();
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


        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Dokter_Frm_Load(object sender, EventArgs e)
        {
            namatxb.Text = namaPengguna;
        }
    }
}


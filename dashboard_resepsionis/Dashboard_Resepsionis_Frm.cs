using Dental_Management_System.dashboard_dokter;
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
    public partial class Dashboard_Resepsionis_Frm : Form
    {
        private string namaPengguna;
        public Dashboard_Resepsionis_Frm()
        {
            InitializeComponent();
        }
  
        public Dashboard_Resepsionis_Frm(string namaPengguna)
        {
            InitializeComponent();
            this.namaPengguna = namaPengguna;
        }

        private void Dashboard_Resepsionis__Load(object sender, EventArgs e)
        {
            namatxb.Text = namaPengguna;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Logout()
        {
            DialogResult result = MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Resepsionis_Login_Frm Obj = new Resepsionis_Login_Frm();
                Obj.Show();
                this.Close();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

    }
}

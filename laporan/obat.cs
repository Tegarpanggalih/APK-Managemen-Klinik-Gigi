using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Management_System.laporan
{
    public partial class obat : Form
    {
        public obat()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument repDoc = new ReportDocument();
            repDoc.Load(@"C:\Users\pkare\source\repos\Dental Management System\Dental Management System\laporan\cetakobat.rpt");
            repDoc.SetDatabaseLogon("root", "");
            repDoc.Refresh();

            crystalReportViewer1.ReportSource = repDoc;
            crystalReportViewer1.Refresh();
        }
    }
}

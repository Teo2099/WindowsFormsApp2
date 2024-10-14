using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp2
{
    public partial class FormRaportIntrariIesiri : Form
    {
        public FormRaportIntrariIesiri()
        {
            InitializeComponent();
        }

        private void FormRaportIntrari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Project1DataSet.intrari' table. You can move, or remove it, as needed.
            /*this.intrariTableAdapter.Fill(this.dB_Project1DataSet.intrari);
            FormRaport f1 = new FormRaport();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7JUSON1\SQLEXPRESS;Initial Catalog=DB_Project1;Integrated Security=True");
            BindingSource bs = (BindingSource)f1.dataGridViewRaport.DataSource;
            DataTable dt = (DataTable)bs.DataSource;

            ReportViewer reportViewer1 = new ReportViewer();
            ReportDataSource rds1 = new ReportDataSource("intrari", dt);
            ReportDataSource rds2 = new ReportDataSource("intrari_detaliu", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);*/
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}

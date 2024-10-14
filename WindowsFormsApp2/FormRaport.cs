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
    public partial class FormRaport : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            fillGestiuneCB();
            comboBoxGestiune.Visible = false;
        }

        private void radioButtonOGestiune_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOGestiune.Checked)
            {
                comboBoxGestiune.Visible = true;
            } else
            {
                comboBoxGestiune.Visible = false;
            }
            
        }

        void fillGestiuneCB()
        {
            comboBoxGestiune.DataSource = db.gestiunis;
            comboBoxGestiune.DisplayMember = "denumire";
            comboBoxGestiune.ValueMember = "id";
        }

        private void buttonAccepta_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            DataTable table = new DataTable();

            if (radioButtonListIntrari.Checked)
            {
                if (radioButtonToateGestiunile.Checked)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7JUSON1\SQLEXPRESS;Initial Catalog=DB_Project1;Integrated Security=True"))
                    {

                        SqlDataAdapter sda = new SqlDataAdapter("exec dbo.SP_ListaIntrari '" + DateTime.Parse(dataInceput.Text) + "','" + DateTime.Parse(dataSfarsit.Text) + "'", con);
                        sda.Fill(table);
                        data.Tables.Add(table);
                        dataGridViewRaport.DataSource = data.Tables[0];
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7JUSON1\SQLEXPRESS;Initial Catalog=DB_Project1;Integrated Security=True"))
                    {

                        SqlDataAdapter sda = new SqlDataAdapter("exec dbo.SP_ListaIntrari '" + DateTime.Parse(dataInceput.Text) + "','" + DateTime.Parse(dataSfarsit.Text) + "','" + int.Parse(comboBoxGestiune.SelectedValue.ToString()) + "'", con);
                        sda.Fill(table);
                        data.Tables.Add(table);
                        dataGridViewRaport.DataSource = data.Tables[0];
                    }
                }
                
            }
            else
            {
                if (radioButtonToateGestiunile.Checked)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7JUSON1\SQLEXPRESS;Initial Catalog=DB_Project1;Integrated Security=True"))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("exec dbo.SP_ListaIesiri '" + DateTime.Parse(dataInceput.Text) + "','" + DateTime.Parse(dataSfarsit.Text) + "'", con);
                        sda.Fill(table);
                        data.Tables.Add(table);
                        dataGridViewRaport.DataSource = data.Tables[0];
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7JUSON1\SQLEXPRESS;Initial Catalog=DB_Project1;Integrated Security=True"))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("exec dbo.SP_ListaIesiri '" + DateTime.Parse(dataInceput.Text) + "','" + DateTime.Parse(dataSfarsit.Text) + "','" + int.Parse(comboBoxGestiune.SelectedValue.ToString()) + "'", con);
                        sda.Fill(table);
                        data.Tables.Add(table);
                        dataGridViewRaport.DataSource = data.Tables[0];
                    }
                }
            }

        }

        public class ListaRaport
        {
            public string titluRaport { get; set; }
            public string denumireGestiune { get; set; }
            public DateTime dataInceput1 { get; set; }
            public DateTime dataSfarsit1 { get; set; }
            public int numar { get; set; }
            public DateTime data { get; set; }
            public string gestiune { get; set; }
            public string produs { get; set; }
            public float pret { get; set; }
            public float cantitate { get; set; }
            public float valoare { get; set; }
        }

        ReportDataSource rs = new ReportDataSource();
        private void buttonListeaza_Click(object sender, EventArgs e)
        {
            string gestiuneaSelectata, listaSelectata;
            List<ListaRaport> list1 = new List<ListaRaport>();
            list1.Clear();

            if (radioButtonOGestiune.Checked)
            {
                gestiuneaSelectata = comboBoxGestiune.Text;
            }
            else
            {
                gestiuneaSelectata = null;
            }

            if (radioButtonListIntrari.Checked)
            {
                listaSelectata = "RAPORT INTRARI";
            } else
            {
                listaSelectata = "RAPORT IESIRI";
            }
            
            for (int i = 0; i < dataGridViewRaport.Rows.Count - 1; i++)
            {

                ListaRaport dgvList = new ListaRaport
                {
                  titluRaport = listaSelectata,
                  denumireGestiune = gestiuneaSelectata,
                  dataInceput1 = DateTime.Parse(dataInceput.Text),
                  dataSfarsit1 = DateTime.Parse(dataSfarsit.Text),
                  numar = int.Parse(dataGridViewRaport.Rows[i].Cells[0].Value.ToString()),
                  data = DateTime.Parse(dataGridViewRaport.Rows[i].Cells[1].Value.ToString()),
                  gestiune = dataGridViewRaport.Rows[i].Cells[2].Value.ToString(),
                  produs = dataGridViewRaport.Rows[i].Cells[3].Value.ToString(),
                  pret = float.Parse(dataGridViewRaport.Rows[i].Cells[4].Value.ToString()),
                  cantitate = float.Parse(dataGridViewRaport.Rows[i].Cells[5].Value.ToString()),
                  valoare = float.Parse(dataGridViewRaport.Rows[i].Cells[6].Value.ToString())

                };
                list1.Add(dgvList);
            }
            rs.Name = "DataSet1";
            rs.Value = list1;

            FormRaportIntrariIesiri f1 = new FormRaportIntrariIesiri();
            f1.reportViewer1.LocalReport.DataSources.Clear();
            f1.reportViewer1.LocalReport.DataSources.Add(rs);
            f1.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report1.rdlc";
            f1.Show();
        }
    }
}

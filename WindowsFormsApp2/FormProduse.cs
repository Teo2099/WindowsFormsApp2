using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace WindowsFormsApp2
{
    public partial class FormProduse : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormProduse()
        {
            InitializeComponent();
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            getData();
            textBoxId.ReadOnly = true;
            textBoxCod.ReadOnly = true;
            dataGridViewProd.ReadOnly = true;
        }

        private void getData()
        {
            var result = from s in db.produses select s;
            dataGridViewProd.DataSource = result;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int max = 0;
            string Denumire;
            decimal Pret;

            var result1 = from s in db.produses select s;
            if (!db.produses.Any())
            {
                max = 1;
            }
            else
            {
                var result2 = from c in db.produses select c;
                foreach (var detail in result2)
                {
                    if (max < detail.cod)
                    {
                        max = int.Parse(detail.cod.ToString());
                    }
                }
                max = max + 1;
            }

            Denumire = textBoxDenumire.Text;
            Decimal.TryParse(textBoxPret.Text.ToString(), out Pret);

            var result = new produse
            {
                cod = max,
                denumire = Denumire,
                 pret_unitar = Pret
            };
            
            db.produses.InsertOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = (from s in db.produses where s.id.Equals(dataGridViewProd.CurrentRow.Cells[0].Value) select s).First();

            db.produses.DeleteOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            decimal Pret;
            var result = (from s in db.produses where s.id.Equals(dataGridViewProd.CurrentRow.Cells[0].Value) select s).First();

            Decimal.TryParse(textBoxPret.Text, out Pret);

            result.denumire = textBoxDenumire.Text;
            result.pret_unitar = Pret;

            db.SubmitChanges();
            getData();
        }

        private void dataGridViewProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewProd.CurrentRow.Cells[0].Value.ToString();
            textBoxCod.Text = dataGridViewProd.CurrentRow.Cells[1].Value.ToString();
            textBoxDenumire.Text = dataGridViewProd.CurrentRow.Cells[2].Value.ToString();
            textBoxPret.Text = dataGridViewProd.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxCod.Clear();
            textBoxDenumire.Clear();
            textBoxPret.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormParteneri : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormParteneri()
        {
            InitializeComponent();
        }

        private void FormParteneri_Load(object sender, EventArgs e)
        {
            getData();
            textBoxId.ReadOnly = true;
            textBoxCod.ReadOnly = true;
            dataGridViewParteneri.ReadOnly = true;
        }

        private void getData()
        {
            var result = from s in db.parteneris select s;
            dataGridViewParteneri.DataSource = result;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int max = 0;
            var result1 = from s in db.parteneris select s;
            if (!db.parteneris.Any())
            {
                max = 1;
            }
            else
            {
                var result2 = from c in db.parteneris select c;
                foreach (var detail in result2)
                {
                    if (max < detail.cod)
                    {
                        max = int.Parse(detail.cod.ToString());
                    }
                }
                max = max + 1;
            }
            

            var result = new parteneri
            {
                cod = max,
                denumire = comboBoxDenumire.Text,
                cui = textBoxCUI.Text,
                adresa = textBoxAdresa.Text
            };

            db.parteneris.InsertOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var result = (from s in db.parteneris where s.id.Equals(dataGridViewParteneri.CurrentRow.Cells[0].Value) select s).First();

            result.denumire = comboBoxDenumire.Text;
            result.cui = textBoxCUI.Text;
            result.adresa = textBoxAdresa.Text;

            db.SubmitChanges();
            getData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = (from s in db.parteneris where s.id.Equals(dataGridViewParteneri.CurrentRow.Cells[0].Value) select s).First();

            db.parteneris.DeleteOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void dataGridViewParteneri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewParteneri.CurrentRow.Cells[0].Value.ToString();
            textBoxCod.Text = dataGridViewParteneri.CurrentRow.Cells[1].Value.ToString();
            comboBoxDenumire.Text = dataGridViewParteneri.CurrentRow.Cells[2].Value.ToString();
            textBoxCUI.Text = dataGridViewParteneri.CurrentRow.Cells[3].Value.ToString();
            textBoxAdresa.Text = dataGridViewParteneri.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxCod.Clear();
            comboBoxDenumire.ResetText();
            textBoxCUI.Clear();
            textBoxAdresa.Clear();
        }
    }
}

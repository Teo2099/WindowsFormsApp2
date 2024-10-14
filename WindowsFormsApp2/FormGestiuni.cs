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
    public partial class FormGestiuni : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormGestiuni()
        {
            InitializeComponent();
        }

        private void FormGestiuni_Load(object sender, EventArgs e)
        {
            getData();
            textBoxId.ReadOnly = true;
            textBoxCod.ReadOnly = true;
            dataGridViewGestiuni.ReadOnly = true;
        }

        private void getData()
        {
            var result = from s in db.gestiunis select s;
            dataGridViewGestiuni.DataSource = result;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int max = 0;
            var result1 = from s in db.gestiunis select s;
            if (!db.gestiunis.Any())
            {
                max = 1;
            }
            else
            {
                var result2 = from c in db.gestiunis select c;
                foreach (var detail in result2)
                {
                    if (max < detail.cod)
                    {
                        max = int.Parse(detail.cod.ToString());
                    }
                }
                max = max + 1;
            }

            var result = new gestiuni
            {
                cod = max,
                denumire = textBoxDenumire.Text,
            };

            db.gestiunis.InsertOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var result = (from s in db.gestiunis where s.id.Equals(dataGridViewGestiuni.CurrentRow.Cells[0].Value) select s).First();

            result.denumire = textBoxDenumire.Text;

            db.SubmitChanges();
            getData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = (from s in db.gestiunis where s.id.Equals(dataGridViewGestiuni.CurrentRow.Cells[0].Value) select s).First();

            db.gestiunis.DeleteOnSubmit(result);
            db.SubmitChanges();
            getData();
        }

        private void dataGridViewGestiuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewGestiuni.CurrentRow.Cells[0].Value.ToString();
            textBoxCod.Text = dataGridViewGestiuni.CurrentRow.Cells[1].Value.ToString();
            textBoxDenumire.Text = dataGridViewGestiuni.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxCod.Clear();
            textBoxDenumire.Clear();
        }
    }
}

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
    public partial class FormIesiri : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        BindingSource bs = new BindingSource();

        public FormIesiri()
        {
            InitializeComponent();
        }

        private void FormIesiri_Load(object sender, EventArgs e)
        {
            fillGestiuneCB();
            fillProdusCB();
            bindData();
            idTextBox.ReadOnly = true;
            numarTextBox.ReadOnly = true;
        }

        void bindData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var result = from a in db.iesiris
                         join c in db.gestiunis on a.gestiunea equals c.id
                         select new { a.id, a.numar, a.data, c.denumire };

            clearDataBindings();
            bs.DataSource = result;
            bindingNavigator1.BindingSource = bs;
            idTextBox.DataBindings.Add(new Binding("Text", bs, "id"));
            numarTextBox.DataBindings.Add(new Binding("Text", bs, "numar"));
            dateTimePicker.DataBindings.Add(new Binding("Text", bs, "data"));
            gestiuneComboBox.DataBindings.Add(new Binding("Text", bs, "denumire"));
        }

        void clearValues()
        {
            iesiri_detaliuDataGridView.Rows.Clear();
            idTextBox.Clear();
            numarTextBox.Clear();
            dateTimePicker.ResetText();
            gestiuneComboBox.ResetText();
        }

        void clearDataBindings()
        {
            idTextBox.DataBindings.Clear();
            numarTextBox.DataBindings.Clear();
            dateTimePicker.DataBindings.Clear();
            gestiuneComboBox.DataBindings.Clear();
        }

        void fillGestiuneCB()
        {
            gestiuneComboBox.DataSource = db.gestiunis;
            gestiuneComboBox.DisplayMember = "denumire";
            gestiuneComboBox.ValueMember = "id";
        }

        void fillProdusCB()
        {
            detaliuProdus.DataSource = db.produses;
            detaliuProdus.DisplayMember = "denumire";
            detaliuProdus.ValueMember = "id";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Master
            int ID_iesiri, ID_detaliu;
            decimal Numar, Gestiune, Produs, Cantitate, Valoare;
            DateTime Data;

            int.TryParse(idTextBox.Text.ToString(), out ID_iesiri);
            Decimal.TryParse(numarTextBox.Text.ToString(), out Numar);
            DateTime.TryParse(dateTimePicker.Text.ToString(), out Data);
            Decimal.TryParse(gestiuneComboBox.SelectedValue.ToString(), out Gestiune);

            var result1 = (from s in db.iesiris where s.id == ID_iesiri select s).First();
            result1.numar = Numar;
            result1.data = Data;
            result1.gestiunea = Gestiune;

            //Details
            int.TryParse(iesiri_detaliuDataGridView.CurrentRow.Cells["detaliu_id"].Value.ToString(), out ID_detaliu);
            decimal.TryParse(iesiri_detaliuDataGridView.CurrentRow.Cells["detaliuProdus"].Value.ToString(), out Produs);
            decimal.TryParse(iesiri_detaliuDataGridView.CurrentRow.Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
            decimal.TryParse(iesiri_detaliuDataGridView.CurrentRow.Cells["detaliuValoare"].Value.ToString(), out Valoare);

            var result2 = (from s in db.iesiri_detalius where s.id == ID_detaliu select s).First();
            result2.produs = Produs;
            result2.cantitate = Cantitate;
            result2.valoare = Valoare;

            db.SubmitChanges();
            bindData();
            MessageBox.Show("DATA UPDATED!");
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (iesiri_detaliuDataGridView.SelectedRows.Count > 0)
            {
                //Delete details
                decimal idDetaliu = decimal.Parse(iesiri_detaliuDataGridView.SelectedRows[0].Cells["detaliu_id"].Value.ToString());
                iesiri_detaliuDataGridView.Rows.RemoveAt(iesiri_detaliuDataGridView.SelectedRows[0].Index);
                var result = (from a in db.iesiri_detalius where a.id == idDetaliu select a).First();
                db.iesiri_detalius.DeleteOnSubmit(result);
                db.SubmitChanges();
                MessageBox.Show("DETAILS DELETED!");
            }
            else
            {
                //Delete master and details
                int ID;
                int.TryParse(idTextBox.Text.ToString(), out ID);

                var result1 = (from a in db.iesiris where a.id == ID select a).First();
                var result2 = from c in db.iesiri_detalius where c.id_iesiri == ID select c;
                foreach (var detail in result2)
                {
                    db.iesiri_detalius.DeleteOnSubmit(detail);
                }
                db.iesiris.DeleteOnSubmit(result1);
                db.SubmitChanges();
                bindData();
                MessageBox.Show("DATA DELETED!");
            }
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            if (iesiri_detaliuDataGridView.Rows.Count == 1 && iesiri_detaliuDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please add details!");
            }
            else if (iesiri_detaliuDataGridView.SelectedRows.Count == 0)
            {
                //Insert new master and details
                decimal Gestiune, Produs, Cantitate, Valoare;
                DateTime Data;

                DateTime.TryParse(dateTimePicker.Text.ToString(), out Data);
                Decimal.TryParse(gestiuneComboBox.SelectedValue.ToString(), out Gestiune);

                int max = 0;
                var result = from s in db.iesiris select s;
                if (!db.iesiris.Any())
                {
                    max = 1;
                }
                else
                {
                    var res = from c in db.iesiris select c;
                    foreach (var detail in res)
                    {
                        if (max < detail.numar)
                        {
                            max = int.Parse(detail.numar.ToString());
                        }
                    }
                    max = max + 1;
                }

                var result1 = new iesiri
                {
                    numar = max,
                    data = Data,
                    gestiunea = Gestiune,
                };
                db.iesiris.InsertOnSubmit(result1);
                db.SubmitChanges();
                for (int i = 0; i < iesiri_detaliuDataGridView.Rows.Count - 1; i++)
                {
                    Decimal.TryParse(iesiri_detaliuDataGridView.Rows[i].Cells["detaliuProdus"].Value.ToString(), out Produs);
                    Decimal.TryParse(iesiri_detaliuDataGridView.Rows[i].Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
                    Decimal.TryParse(iesiri_detaliuDataGridView.Rows[i].Cells["detaliuValoare"].Value.ToString(), out Valoare);

                    var result2 = new iesiri_detaliu
                    {
                        id_iesiri = result1.id,
                        produs = Produs,
                        cantitate = Cantitate,
                        valoare = Valoare,
                    };
                    db.iesiri_detalius.InsertOnSubmit(result2);
                    db.SubmitChanges();
                }
                bindData();
                MessageBox.Show("DATA INSERTED!");
            }
            else if (iesiri_detaliuDataGridView.SelectedRows.Count > 0)
            {
                //Insert details for current master
                decimal Produs, Cantitate, Valoare;
                decimal.TryParse(iesiri_detaliuDataGridView.SelectedRows[0].Cells["detaliuProdus"].Value.ToString(), out Produs);
                decimal.TryParse(iesiri_detaliuDataGridView.SelectedRows[0].Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
                decimal.TryParse(iesiri_detaliuDataGridView.SelectedRows[0].Cells["detaliuValoare"].Value.ToString(), out Valoare);

                var result = new iesiri_detaliu
                {
                    id_iesiri = int.Parse(idTextBox.Text),
                    produs = Produs,
                    cantitate = Cantitate,
                    valoare = Valoare
                };
                db.iesiri_detalius.InsertOnSubmit(result);
                db.SubmitChanges();
                MessageBox.Show("DETAILS INSERTED!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDataBindings();
            clearValues();
            MessageBox.Show("DATA CLEARED!");
        }

        public class Detalii
        {
            public decimal ID { get; set; }
            public decimal ID_iesiri { get; set; }
            public decimal produs { get; set; }
            public decimal cantitate { get; set; }
            public decimal valoare { get; set; }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            //Fill datagridview
            if (idTextBox.Text != "")
            {
                decimal ID = decimal.Parse(idTextBox.Text);
                var result = from a in db.iesiri_detalius
                             where a.id_iesiri == ID
                             select new Detalii { ID = a.id, ID_iesiri = a.id_iesiri.Value, produs = a.produs.Value, cantitate = a.cantitate.Value, valoare = a.valoare.Value };
                var resultList = new BindingList<Detalii>(result.ToList());
                iesiri_detaliuDataGridView.DataSource = resultList;
            }
        }

        private void iesiri_detaliuDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Calculate value of product
            int idProd;

            int.TryParse(iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), out idProd);
            var result = (from s in db.produses where s.id == idProd select s).First();

            if (iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[3].Value == null)
            {
                iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[4].Value = "0";
            }
            else
            {
                iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[4].Value = (result.pret_unitar * decimal.Parse(iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString();
            }
        }

        private void iesiri_detaliuDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            object value = iesiri_detaliuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (((DataGridViewComboBoxColumn)iesiri_detaliuDataGridView.Columns[e.ColumnIndex]).Items.Contains(value))
            {
                ((DataGridViewComboBoxColumn)iesiri_detaliuDataGridView.Columns[e.ColumnIndex]).Items.Add(value);
                e.ThrowException = false;
            }
        }
    }
}

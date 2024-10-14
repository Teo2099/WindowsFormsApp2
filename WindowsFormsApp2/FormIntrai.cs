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
    public partial class FormIntrai : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        BindingSource bs = new BindingSource();

        public FormIntrai()
        {
            InitializeComponent();
        }

        private void FormIntrai_Load(object sender, EventArgs e)
        {
            fillParteneriCB();
            fillGestiuneCB();
            fillProdusCB();
            bindData();
            idTextBox.ReadOnly = true;
            numarTextBox.ReadOnly = true;
        }

        void bindData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var result = from a in db.intraris
                         join b in db.parteneris on a.partener equals b.id
                         join c in db.gestiunis on a.gestiune equals c.id
                         select new { a.id, a.numar,a.data, u1 = b.denumire, u2 = c.denumire};

            clearDataBindings();
            bs.DataSource = result;
            bindingNavigator1.BindingSource = bs;
            idTextBox.DataBindings.Add(new Binding("Text", bs, "id"));
            numarTextBox.DataBindings.Add(new Binding("Text", bs, "numar"));
            dateTimePicker.DataBindings.Add(new Binding("Text", bs, "data"));
            partenerComboBox.DataBindings.Add(new Binding("Text", bs, "u1"));
            gestiuneComboBox.DataBindings.Add(new Binding("Text", bs, "u2"));
        }

        void clearValues()
        {
            intrari_detaliuDataGridView.Rows.Clear();
            idTextBox.Clear();
            numarTextBox.Clear();
            dateTimePicker.ResetText();
            partenerComboBox.ResetText();
            gestiuneComboBox.ResetText();
        }

         void clearDataBindings()
        {
            idTextBox.DataBindings.Clear();
            numarTextBox.DataBindings.Clear();
            dateTimePicker.DataBindings.Clear();
            partenerComboBox.DataBindings.Clear();
            gestiuneComboBox.DataBindings.Clear();
        }

        void fillParteneriCB()
        {
            partenerComboBox.DataSource = db.parteneris;
            partenerComboBox.DisplayMember = "denumire";
            partenerComboBox.ValueMember = "id";
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
                int ID_intrari, ID_detaliu;
                decimal Numar, Partener, Gestiune, Produs, Cantitate, Valoare;
                DateTime Data;

                int.TryParse(idTextBox.Text.ToString(), out ID_intrari);
                Decimal.TryParse(numarTextBox.Text.ToString(), out Numar);
                DateTime.TryParse(dateTimePicker.Text.ToString(), out Data);
                Decimal.TryParse(partenerComboBox.SelectedValue.ToString(), out Partener);
                Decimal.TryParse(gestiuneComboBox.SelectedValue.ToString(), out Gestiune);

                var result1 = (from s in db.intraris where s.id == ID_intrari select s).First();
                result1.numar = Numar;
                result1.data = Data;
                result1.partener = Partener;
                result1.gestiune = Gestiune;

                //Details
                int.TryParse(intrari_detaliuDataGridView.CurrentRow.Cells["detaliu_id"].Value.ToString(), out ID_detaliu);
                decimal.TryParse(intrari_detaliuDataGridView.CurrentRow.Cells["detaliuProdus"].Value.ToString(), out Produs);
                decimal.TryParse(intrari_detaliuDataGridView.CurrentRow.Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
                decimal.TryParse(intrari_detaliuDataGridView.CurrentRow.Cells["detaliuValoare"].Value.ToString(), out Valoare);

                var result2 = (from s in db.intrari_detalius where s.id == ID_detaliu select s).First();
                result2.produs = Produs;
                result2.cantitate = Cantitate;
                result2.valoare = Valoare;

                db.SubmitChanges();
                bindData();
                MessageBox.Show("DATA UPDATED!");
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (intrari_detaliuDataGridView.SelectedRows.Count > 0)
            {
                //Delete details
                int idDetaliu = int.Parse(intrari_detaliuDataGridView.SelectedRows[0].Cells["detaliu_id"].Value.ToString());
                intrari_detaliuDataGridView.Rows.RemoveAt(intrari_detaliuDataGridView.SelectedRows[0].Index);
                var result = (from a in db.intrari_detalius where a.id == idDetaliu select a).First();
                db.intrari_detalius.DeleteOnSubmit(result);
                db.SubmitChanges();
                MessageBox.Show("DETAILS DELETED!");
            }
            else
            {
                //Delete master and details
                int ID;
                int.TryParse(idTextBox.Text.ToString(), out ID);

                var result1 = (from a in db.intraris where a.id == ID select a).First();
                var result2 = from c in db.intrari_detalius where c.id_intrari == ID select c;
                foreach (var detail in result2)
                {
                    db.intrari_detalius.DeleteOnSubmit(detail);
                }
                db.intraris.DeleteOnSubmit(result1);
                db.SubmitChanges();
                bindData();
                MessageBox.Show("DATA DELETED!");
            }
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            if(intrari_detaliuDataGridView.Rows.Count == 1 && intrari_detaliuDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please add details!");
            }
            else if (intrari_detaliuDataGridView.SelectedRows.Count == 0)
            {
                //Insert new master and details
                decimal Partener, Gestiune, Produs, Cantitate, Valoare;
                DateTime Data;

                //Decimal.TryParse(numarTextBox.Text.ToString(), out Numar);
                DateTime.TryParse(dateTimePicker.Text.ToString(), out Data);
                Decimal.TryParse(partenerComboBox.SelectedValue.ToString(), out Partener);
                Decimal.TryParse(gestiuneComboBox.SelectedValue.ToString(), out Gestiune);

                //Increment numar
                int max = 0;
                var result1 = from s in db.intraris select s;
                if (!db.intraris.Any())
                {
                    max = 1;
                }
                else
                {
                    var res = from c in db.intraris select c;
                    foreach (var detail in res)
                    {
                        if (max < detail.numar)
                        {
                            max = int.Parse(detail.numar.ToString());
                        }
                    }
                    max = max + 1;
                }

                var result2 = new intrari
                {
                    numar = max,
                    data = Data,
                    partener = Partener,
                    gestiune = Gestiune,
                };
                db.intraris.InsertOnSubmit(result2);
                db.SubmitChanges();
                for (int i = 0; i < intrari_detaliuDataGridView.Rows.Count - 1; i++)
                {
                    Decimal.TryParse(intrari_detaliuDataGridView.Rows[i].Cells["detaliuProdus"].Value.ToString(), out Produs);
                    Decimal.TryParse(intrari_detaliuDataGridView.Rows[i].Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
                    Decimal.TryParse(intrari_detaliuDataGridView.Rows[i].Cells["detaliuValoare"].Value.ToString(), out Valoare);

                    var result3 = new intrari_detaliu
                    {
                        id_intrari = result2.id,
                        produs = Produs,
                        cantitate = Cantitate,
                        valoare = Valoare,
                    };
                    db.intrari_detalius.InsertOnSubmit(result3);
                    db.SubmitChanges();
                }
                bindData();
                MessageBox.Show("DATA INSERTED!");
            }
            else if (intrari_detaliuDataGridView.SelectedRows.Count > 0)
            {
                //Insert details for current master
                decimal Produs, Cantitate, Valoare;
                decimal.TryParse(intrari_detaliuDataGridView.SelectedRows[0].Cells["detaliuProdus"].Value.ToString(), out Produs);
                decimal.TryParse(intrari_detaliuDataGridView.SelectedRows[0].Cells["detaliuCantitate"].Value.ToString(), out Cantitate);
                decimal.TryParse(intrari_detaliuDataGridView.SelectedRows[0].Cells["detaliuValoare"].Value.ToString(), out Valoare);

                var result = new intrari_detaliu
                {
                    id_intrari = int.Parse(idTextBox.Text),
                    produs = Produs,
                    cantitate = Cantitate,
                    valoare = Valoare
                };
                db.intrari_detalius.InsertOnSubmit(result);
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
            public decimal ID_intrari { get; set; }
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
                var result = from a in db.intrari_detalius
                             where a.id_intrari == ID
                             select new Detalii{ ID = a.id, ID_intrari = a.id_intrari.Value, produs = a.produs.Value, cantitate = a.cantitate.Value, valoare = a.valoare.Value };
                var resultList = new BindingList<Detalii>(result.ToList());
                intrari_detaliuDataGridView.DataSource = resultList;
            }
        }

        private void intrari_detaliuDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            //Calculate value of product
            int idProd;

            int.TryParse(intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), out idProd);
            var result = (from s in db.produses where s.id == idProd select s).First();

            if (intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[3].Value == null)
            {
                intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[4].Value = "0";
            }
            else
            {
                intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[4].Value = (result.pret_unitar * decimal.Parse(intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString();
            }
        }

        private void intrari_detaliuDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            object value = intrari_detaliuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (((DataGridViewComboBoxColumn)intrari_detaliuDataGridView.Columns[e.ColumnIndex]).Items.Contains(value))
            {
                ((DataGridViewComboBoxColumn)intrari_detaliuDataGridView.Columns[e.ColumnIndex]).Items.Add(value);
                e.ThrowException = false;
            }
        }
    }
}

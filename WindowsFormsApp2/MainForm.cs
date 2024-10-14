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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduse f1 = new FormProduse();
            f1.Show();
        }

        private void intrariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIntrai f1 = new FormIntrai();
            f1.Show();
        }

        private void parteneriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormParteneri f1 = new FormParteneri();
            f1.Show();
        }

        private void gestiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestiuni f1 = new FormGestiuni();
            f1.Show();
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaport f1 = new FormRaport();
            f1.Show();
        }

        private void iesiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIesiri f1 = new FormIesiri();
            f1.Show();
        }
    }
}

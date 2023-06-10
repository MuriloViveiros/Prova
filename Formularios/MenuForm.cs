using Prova.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new loginForm();
            form.Show();

        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ProdutoForm();
            form.Show();

        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AlterarForm();
            form.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void caDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SobreForm();
            form.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FuncForm();
            form.Show();
        }
    }
}

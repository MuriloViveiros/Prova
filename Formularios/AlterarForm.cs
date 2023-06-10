using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.Formularios
{
    public partial class AlterarForm : Form
    {
        public AlterarForm()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            var dado = new ProdutoDAO().ListarTodas();
            edicaoDataGridView.DataSource = dado;



        }

        private void edicaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Form form = new DeletarForm();
            form.Show();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            Form form = new ModificaForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ProdutoForm();
            form.Show();
        }
    }
}

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
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            new ProdutoDAO().Adicionar(produtoTextBox.Text, Convert.ToDecimal(valorTextBox.Text),linhaTextBox.Text);
            MessageBox.Show("Produto registrado com sucesso!");
            this.Close();
        }
    }
}

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
    public partial class ModificaForm : Form
    {
        public ModificaForm()
        {
            InitializeComponent();
        }

        private void mudarButton_Click(object sender, EventArgs e)
        {
            new ProdutoDAO().Atualizar(Convert.ToInt32(idaTextBox.Text), pdTextBox.Text, Convert.ToDecimal(vaTextBox.Text), liTextBox.Text);
            MessageBox.Show("Produto Alterado com Sucesso!");
        }
    }
}

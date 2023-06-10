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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            new UsuariosDAO().Salvar(nomerTextBox.Text, senharTextBox.Text);
            MessageBox.Show("Usuario Salvo");
            this.Close();
        }
    }
}

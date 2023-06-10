using Prova;
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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        Usuario getUsuario = new Usuario();

        private void loginButton_Click(object sender, EventArgs e)
        {
            getUsuario = new UsuariosDAO().Login(nomeTextBox.Text, senhaTextBox.Text);
            if (getUsuario == null)
            {
                MessageBox.Show("Usuário e senha não encontrado!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                senhaTextBox.Clear();
                nomeTextBox.Focus();
            }
            else
            {
                if (getUsuario.Ativo == false)
                {
                    MessageBox.Show("Usuário desabilitado!", ProductName,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhaTextBox.Clear();
                    nomeTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Usuário entrou com sucesso");
                    this.Close();


                }

            }
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            Form form = new RegistroForm();
            form.Show();
        }
    }
}
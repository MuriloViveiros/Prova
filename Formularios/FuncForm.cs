using Prova.Negocios;
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
    public partial class FuncForm : Form
    {
        public FuncForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {
           
        }

        private void funcDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            var dados = new FuncDAO().ListarFunc();
            funcDataGridView.DataSource = dados;
        }
    }
}

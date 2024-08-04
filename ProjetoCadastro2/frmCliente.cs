using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdMainDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bdMainDataSet.cliente);
        }
    }
}

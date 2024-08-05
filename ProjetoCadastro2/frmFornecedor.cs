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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMainDataSet);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdMainDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.bdMainDataSet.fornecedor);

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nm_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_cnpjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

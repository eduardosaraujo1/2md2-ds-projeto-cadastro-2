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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdMainDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.bdMainDataSet.usuario);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MovePrevious();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.RemoveCurrent();
            usuarioTableAdapter.Update(bdMainDataSet.usuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            usuarioBindingSource.EndEdit();
            usuarioTableAdapter.Update(bdMainDataSet.usuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
        }
    }
}

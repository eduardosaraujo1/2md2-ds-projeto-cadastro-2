using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMode = ProjetoCadastro2.frmMain.FormMode;

namespace ProjetoCadastro2
{
    public partial class frmUsuario : Form
    {
        private FormMode currentMode = FormMode.Visualizacao;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private bool FormIsValid()
        {
            return !string.IsNullOrEmpty(txtCodigo.Text)
                && txtNivel.MaskCompleted;
        }

        private List<Button> GetButtons()
        {
            List<Button> btns = new List<Button>();
            foreach (Control control in pnlButtons.Controls)
            {
                if (control is Button)
                {
                    btns.Add(control as Button);
                }
            }
            return btns;
        }

        private List<MaskedTextBox> GetTextBoxes()
        {
            List<MaskedTextBox> textboxes = new List<MaskedTextBox>();
            foreach (Control control in pnlContent.Controls)
            {
                if (control is MaskedTextBox)
                {
                    textboxes.Add(control as MaskedTextBox);
                }
            }
            return textboxes;
        }

        private void SetFormMode(FormMode mode)
        {
            if (mode == FormMode.Visualizacao)
            {
                GetTextBoxes().ForEach(t => t.Enabled = false);
                txtCodigo.Enabled = false;

                GetButtons().ForEach(b => b.Enabled = true);
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                GetTextBoxes().ForEach(t => t.Enabled = true);
                txtCodigo.Enabled = false;

                GetButtons().ForEach(b => b.Enabled = false);
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSair.Enabled = true;
            }
            currentMode = mode;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdMainDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.bdMainDataSet.usuario);

            SetFormMode(FormMode.Visualizacao);
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
            SetFormMode(FormMode.Cadastro);
            usuarioBindingSource.AddNew();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Current != null)
            {
                usuarioBindingSource.RemoveCurrent();
                usuarioTableAdapter.Update(bdMainDataSet.usuario);
            } else
            {
                MessageBox.Show("Nenhum cadastro está selecionado", "Cadastro nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!FormIsValid())
            {
                MessageBox.Show("O cadastro possui propriedades inválidas", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuarioBindingSource.EndEdit();
            usuarioTableAdapter.Update(bdMainDataSet.usuario);
            SetFormMode(FormMode.Visualizacao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // TODO: Porque quando cancelamos no modo Cadastro o AutoIncrement do código ainda aumenta?
            usuarioBindingSource.CancelEdit();
            SetFormMode(FormMode.Visualizacao);
        }
    }
}

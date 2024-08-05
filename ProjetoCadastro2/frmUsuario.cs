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
        private DataTable table;
        public frmUsuario()
        {
            InitializeComponent();
            table = bdMainDataSet.usuario;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.bdMainDataSet.usuario);
            SetFormMode(FormMode.Visualizacao);
        }
        
        // button handlers
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
            // exibir codigo manualmente devído a erro de exibição do autoincrement
            txtCodigo.Text = Utils.EvalTableAutoIncrement(table).ToString();
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
            try
            {
                usuarioBindingSource.EndEdit();
                usuarioTableAdapter.Update(bdMainDataSet.usuario);
                SetFormMode(FormMode.Visualizacao);
            }
            catch (Exception ex) when (
                ex is NoNullAllowedException
            )
            {
                MessageBox.Show("O cadastro possui propriedades inválidas", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
            SetFormMode(FormMode.Visualizacao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Alteracao);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Current != null)
            {
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum cadastro está selecionado", "Cadastro nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa telaPesquisa = new frmPesquisa(
                FormTitle: "PESQUISAR USUÁRIO",
                SearchColumn: "nm_usuario",
                Table: table
            );
            switch (telaPesquisa.ShowDialog())
            {
                case DialogResult.OK:
                    usuarioBindingSource.Position = telaPesquisa.SearchResult;
                    break;
                case DialogResult.Abort:
                    MessageBox.Show($"Nenhum usuário com o nome \"{telaPesquisa.SearchQuery}\" foi encontrada", "Não Encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }
        }

        // Form control methods
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

        private List<MaskedTextBox> GetMaskedTextBoxes()
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
                GetMaskedTextBoxes().ForEach(t => t.Enabled = false);
                txtCodigo.Enabled = false;

                GetButtons().ForEach(b => b.Enabled = true);
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                GetMaskedTextBoxes().ForEach(t => t.Enabled = true);
                txtCodigo.Enabled = false;

                GetButtons().ForEach(b => b.Enabled = false);
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSair.Enabled = true;
            }
            currentMode = mode;
        }

        // Printing methods
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string page = GeneratePrintPage();
            Utils.PrintPage(page, e);
        }

        private string GeneratePrintPage()
        {
            // might be a cadastroDataSource method
            DataRowView row = (DataRowView)usuarioBindingSource.Current;
            string s = string.Empty;
            s += "--- DADOS DO USUÁRIO ----\n";
            s += "CÓDIGO: " + row["Id"] + '\n';
            s += "NOME: " + row["nm_usuario"] + '\n';
            s += "NÍVEL DE ACESSO: " + row["sg_nivel"] + '\n';
            s += "LOGIN: " + row["nm_login"] + '\n';
            s += "SENHA: " + new string('*', row["cd_senha"].ToString().Length);
            return s;
        }
    }
}

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
    public partial class frmFornecedor : Form
    {
        private FormMode currentMode;
        private DataTable table;
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            this.fornecedorTableAdapter.Fill(this.bdMainDataSet.fornecedor);
            table = bdMainDataSet.fornecedor;
            SetFormMode(FormMode.Visualizacao);
        }

        // button handlers
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Cadastro);
            fornecedorBindingSource.AddNew();
            // exibir codigo manualmente devído a erro de exibição do autoincrement
            txtCodigo.Text = Utils.EvalTableAutoIncrement(table).ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Alteracao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (fornecedorBindingSource.Current != null)
            {
                fornecedorBindingSource.RemoveCurrent();
                fornecedorTableAdapter.Update(bdMainDataSet.fornecedor);
            } else
            {
                MessageBox.Show("Nenhum cadastro está selecionado", "Cadastro nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(bdMainDataSet.fornecedor);
                SetFormMode(FormMode.Visualizacao);
            }
            catch (Exception ex) when (
                ex is NoNullAllowedException
                || ex is ArgumentException
            )
            {
                MessageBox.Show($"Propriedade(s) inválidas: {ex.Message}", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.CancelEdit();
            SetFormMode(FormMode.Visualizacao);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa searchForm = new frmPesquisa(fornecedorBindingSource);
            searchForm.ShowDialog();
            fornecedorBindingSource.Filter = string.Empty;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (fornecedorBindingSource.Current != null)
            {
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum cadastro está selecionado", "Cadastro nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form control
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


        // printing
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string page = GeneratePrintPage();
            Utils.PrintPage(page, e);
        }

        private string GeneratePrintPage()
        {
            DataRowView row = (DataRowView)fornecedorBindingSource.Current;
            string s = string.Empty;
            s += "--- DADOS DO FORNECEDOR ----\n";
            s += "CÓDIGO: " + row["Id"] + '\n';
            s += "NOME: " + row["nm_fornecedor"] + '\n';
            s += "ENDEREÇO: " + row["ds_endereco"] + '\n';
            s += "BAIRRO: " + row["nm_bairro"] + '\n';
            s += "CIDADE: " + row["nm_cidade"] + '\n';
            s += "ESTADO: " + row["sg_estado"] + '\n';
            s += "CEP: " + row["cd_cep"] + '\n';
            s += "CNPJ: " + row["cd_cnpj"] + '\n';
            s += "INSCRIÇÃO ESTADUAL: " + row["cd_inscr_estadual"] + '\n';
            return s;
        }
    }
}

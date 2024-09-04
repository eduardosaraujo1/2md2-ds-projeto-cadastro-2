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
    public partial class frmCliente : Form
    {
        private FormMode currentMode;
        private DataTable table;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.bdMainDataSet.cliente);
            table = bdMainDataSet.cliente;
            SetFormMode(FormMode.Visualizacao);
        }

        // button handers
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Cadastro);
            clienteBindingSource.AddNew();
            // exibir codigo manualmente devído a erro de exibição do autoincrement
            txtCodigo.Text = Utils.EvalTableAutoIncrement(table).ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Alteracao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.Current != null)
            {
                clienteBindingSource.RemoveCurrent();
                clienteTableAdapter.Update(bdMainDataSet.cliente);
            } else
            {
                MessageBox.Show("Nenhum cadastro está selecionado", "Cadastro nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(bdMainDataSet.cliente);
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
            clienteBindingSource.CancelEdit();
            SetFormMode(FormMode.Visualizacao);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa searchForm = new frmPesquisa(clienteBindingSource);
            searchForm.ShowDialog();
            clienteBindingSource.Filter = string.Empty;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.Current != null)
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

        // Printing
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string page = GeneratePrintPage();
            Utils.PrintPage(page, e);
        }

        private string GeneratePrintPage()
        {
            DataRowView row = (DataRowView)clienteBindingSource.Current;
            string s = string.Empty;
            s += "--- DADOS DO CLIENTE ----\n";
            s += "CÓDIGO: " + row["Id"] + '\n';
            s += "NOME: " + row["nm_cliente"] + '\n';
            s += "ENDEREÇO: " + row["ds_endereco"] + '\n';
            s += "BAIRRO: " + row["nm_bairro"] + '\n';
            s += "CIDADE: " + row["nm_cidade"] + '\n';
            s += "ESTADO: " + row["sg_estado"] + '\n';
            s += "CEP: " + row["cd_cep"] + '\n';
            s += "CPF: " + row["cd_cpf"] + '\n';
            s += "RG: " + row["cd_rg"] + '\n';
            s += "TELEFONE: " + row["nr_telefone"] + '\n';
            s += "E-MAIL: " + row["email"] + '\n';
            return s;
        }
    }
}

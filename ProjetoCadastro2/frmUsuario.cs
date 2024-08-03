﻿using System;
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
        
        private int GetProbableNextAutoIncrement(DataTable table)
        {
            int nextIncr = 0;

            if (table.Rows.Count > 0)
            {
                nextIncr = (int)table.Compute("MAX(Id)", "");
            }

            return nextIncr + 1;
        }

        private bool CadastroValido()
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
            // exibir um valor de autoincrement para lidar melhor com o botão Cancelar
            DataTable table = ((DataView)usuarioBindingSource.List).Table;
            txtCodigo.Text = GetProbableNextAutoIncrement(table).ToString();
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
            if (CadastroValido())
            {
                Validate();
                usuarioBindingSource.EndEdit();
                usuarioTableAdapter.Update(bdMainDataSet.usuario);
                SetFormMode(FormMode.Visualizacao);
            } else
            {
                MessageBox.Show("O cadastro possui propriedades inválidas", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
            SetFormMode(FormMode.Visualizacao);
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSair_Click(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SetFormMode(FormMode.Alteracao);
        }
    }
}

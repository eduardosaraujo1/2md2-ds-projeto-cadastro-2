using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    public partial class frmPesquisa : Form
    {
        private BindingSource source { get; set; }
        public frmPesquisa(BindingSource source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void frmPesquisaAdv_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            dataGridView.DataSource = source;
            for (int i = 2; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
            DataGridViewColumn nameColumn = dataGridView.Columns[1];
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumn.MinimumWidth = 300;
            nameColumn.HeaderText = "Nome";
        }

        private string GetColumnName()
        {
            DataGridViewColumn column = dataGridView.Columns[1];
            return column.Name;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const int positionColId = 0;
            // Se o usuário clicar no header da tabela, RowIndex é menor que 0.
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView.Rows.Count)
            {
                return; 
            }
            int newPos = (int)dataGridView[positionColId, e.RowIndex].Value;
            source.Filter = string.Empty;
            source.Position = newPos - 1;
            Close();
        }
        
        private void RunQuery(object sender=null, EventArgs e=null)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                source.Filter = string.Empty;
            } else
            {
                source.Filter = $"{GetColumnName()} like '%{query}%'";
            }
        }

        private void btnSair_onclick(object sender, EventArgs e)
        {
            source.Filter = string.Empty;
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RunQuery();
        }
    }
}

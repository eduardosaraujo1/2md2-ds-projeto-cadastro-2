﻿using System;
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
    public partial class frmPesquisaAdv : Form
    {
        private BindingSource source { get; set; }
        public frmPesquisaAdv(BindingSource source)
        {
            this.source = source;
            InitializeComponent();
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
            // column index sempre 0 para ser coluna de ID
            int newPos = (int)dataGridView[0, e.RowIndex].Value;
            source.Filter = "";
            source.Position = newPos - 1;
            Close();
        }
        
        private void RunQuery(object sender=null, EventArgs e=null)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                source.Filter = string.Empty;
                return;
            }

            source.Filter = $"{GetColumnName()} like '%{query}%'"; 
        }

        private void btnSair_onclick(object sender, EventArgs e)
        {
            source.Filter = "";
            Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar ;
            if (key == '\r')
            {
                RunQuery();
            }
        }
    }
}

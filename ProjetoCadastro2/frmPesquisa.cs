using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    /// <summary>
    /// This class provides the search function to all forms by using it with ShowDialog().
    /// It has three possible DialogResult states:
    /// DialogResult.OK - The form found a match, stored in SearchResult
    /// DialogResult.Cancel - The form was closed before a search was made
    /// DialogResult.Abort - The search was made, but no result was found
    /// </summary>
    public partial class frmPesquisa : Form
    {
        public string FormTitle { get; set; }
        public string SearchColumn { get; set; }
        public DataTable Table { get; set; }

        public string SearchQuery { get; private set; }
        public int SearchResult { get; private set; }
        public frmPesquisa(string FormTitle, string SearchColumn, DataTable Table)
        {
            this.FormTitle = FormTitle;
            this.SearchColumn = SearchColumn;
            this.Table = Table;
            InitializeComponent();
        }

        private int TableSearchByColumn()
        {
            if (string.IsNullOrEmpty(SearchQuery))
            {
                return -1;
            }

            foreach (DataRow row in Table.Rows)
            {
                string cellValue = row[SearchColumn].ToString();
                bool isMatch = cellValue.StartsWith(SearchQuery, StringComparison.OrdinalIgnoreCase);

                if (isMatch)
                {
                    return Table.Rows.IndexOf(row);
                }
            }
            return -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBar.Text.Trim())) 
            { 
                return; 
            }
            SearchQuery = txtSearchBar.Text.Trim();
            SearchResult = TableSearchByColumn();
            DialogResult = SearchResult == -1 ? DialogResult.Abort : DialogResult.OK;
            Close();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            lblHeader.Text = FormTitle;
        }
    }
}

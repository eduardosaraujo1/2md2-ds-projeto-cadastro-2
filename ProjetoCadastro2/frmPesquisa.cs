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
    public partial class frmPesquisa : Form
    {
        private string title;
        private Action<string> searchLogic;
        public frmPesquisa(Action<string> searchLogic, string title)
        {
            InitializeComponent();
            this.searchLogic = searchLogic;
            this.title = title;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchQuery.Text.Trim())) { return; }
            searchLogic(searchQuery.Text);
            Close();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            lblHeader.Text = title;
        }
    }
}

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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DummyDataGenerator.ENABLED)
            {
                DummyDataGenerator dg = new DummyDataGenerator();
                dg.GenerateAll();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.Show();
        }

        private void RefillDataSet()
        {
            this.usuarioTableAdapter.Fill(this.bdMainDataSet.usuario);
            this.clienteTableAdapter.Fill(this.bdMainDataSet.cliente);
            this.fornecedorTableAdapter.Fill(this.bdMainDataSet.fornecedor);
        }

        public enum FormMode
        {
            Visualizacao = 0,
            Cadastro = 1,
            Alteracao = 2
        }

        #region Relatórios
        string[] relatorioPages;
        int curPage = 0;
        private void PrintRelatorio(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (relatorioPages.Length <= 0) return;
            string page = relatorioPages[curPage];
            Graphics g = e.Graphics;
            Font font = RelatorioPrefs.FONT;
            Brush color = RelatorioPrefs.BRUSH_COLOR;
            PointF margins = RelatorioPrefs.DRAW_ANCHOR;

            g.DrawString(page, font, color, margins);

            // if nextPage is not last page
            if (++curPage < relatorioPages.Length)
            {
                e.HasMorePages = true;
                return;
            }

            curPage = 0;
        }

        private void relatorioUsuariosToolStrip_Click(object sender, EventArgs e)
        {
            // gerando relatório
            RefillDataSet();
            if (usuarioSource.Count <= 0)
            {
                MessageBox.Show("Não há nenhum usuário, não é possível gerar um relatório", "Empty table error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RelatorioBuilder relatorio = new RelatorioBuilder(usuarioSource);
            relatorio.AddColumn("Id", "Código", 7);
            relatorio.AddColumn("nm_usuario", "Nome", 40);
            relatorio.AddColumn("sg_nivel", "Nível", 6);
            relatorio.AddColumn("nm_login", "Login", 20);
            relatorioPages = relatorio.Write("Relatório de Usuários");

            // imprimindo
            relUsuarioPPD.ShowDialog();
        }

        private void RelatorioClientesToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void relatorioFornecedoresToolStrip_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

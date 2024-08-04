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

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public enum FormMode
        {
            Visualizacao = 0,
            Cadastro = 1,
            Alteracao = 2
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // gerando relatório
            RelatorioBuilder relatorio = new RelatorioBuilder("Relatório de Usuários", bdMainDataSet);
            relatorio.AddColumn("Id", "Código", 7);
            relatorio.AddColumn("nm_usuario", "Nome", 40);
            relatorio.AddColumn("sg_nivel", "Nível", 6);
            relatorio.AddColumn("nm_login", "Login", 20);
            pagesRelUsuario = relatorio.Write();
            relUsuarioPPD.ShowDialog();
        }

        List<string> pagesRelUsuario;
        int curPageUsuario = 0;
        private void relUsuarioPD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pagesRelUsuario.Count <= 0) return;
            Graphics g = e.Graphics;
            Font font = RelatorioPrefs.FONT;
            Brush color = RelatorioPrefs.BRUSH_COLOR;
            PointF margins = RelatorioPrefs.DRAW_ANCHOR;

            string page = pagesRelUsuario[curPageUsuario];
            g.DrawString(page, font, color, margins);

            // if nextPage is not last page
            if (++curPageUsuario < pagesRelUsuario.Count)
            {
                e.HasMorePages = true;
                return;
            }

            curPageUsuario = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (RelatorioPrefs.UseDummyData)
            {
                DummyDataGenerator dg = new DummyDataGenerator(100);
                dg.GenerateAll();
            }
        }
    }
}

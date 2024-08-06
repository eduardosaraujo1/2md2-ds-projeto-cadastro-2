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
        public DummyDataGenerator dataGenerator = new DummyDataGenerator();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer_Tick(null, null);
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
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.Show();
        }

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

        private void StartPrinting(string[] pages)
        {
            if (pages == null || pages.Length == 0) {
                MessageBox.Show("Não foi possível gerar o relatório: não há dados para gera-lo", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            relatorioPages = pages;
            relUsuarioPPD.ShowDialog();
        }

        private void relatorioUsuariosToolStrip_Click(object sender, EventArgs e)
        {
            // gerando relatório
            usuarioTableAdapter.Fill(bdMainDataSet.usuario);
            RelatorioBuilder relatorio = new RelatorioBuilder(usuarioSource);
            relatorio.AddColumn("Id", "Código", 7);
            relatorio.AddColumn("nm_usuario", "Nome", 35);
            relatorio.AddColumn("sg_nivel", "Nível", 6);
            relatorio.AddColumn("nm_login", "Login", 20);
            string[] pages = relatorio.Write("Relatório de Usuários");
            StartPrinting(pages);
        }

        private void RelatorioClientesToolStrip_Click(object sender, EventArgs e)
        {
            // gerando relatório
            clienteTableAdapter.Fill(bdMainDataSet.cliente);
            RelatorioBuilder relatorio = new RelatorioBuilder(clienteSource);
            relatorio.AddColumn("Id", "Código", 7);
            relatorio.AddColumn("nm_cliente", "Nome", 35);
            relatorio.AddColumn("nr_telefone", "Telefone", 15);
            relatorio.AddColumn("email", "E-mail", 30);
            relatorio.AddColumn("cd_cep", "CEP", 10);
            relatorio.AddColumn("nm_cidade", "Cidade", 25);
            relatorio.AddColumn("sg_estado", "Estado", 7);
            relatorio.AddColumn("cd_cpf", "CPF", 15);
            relatorio.AddColumn("cd_rg", "RG", 10);
            string[] pages = relatorio.Write("Relatório de Clientes");
            StartPrinting(pages);
        }

        private void relatorioFornecedoresToolStrip_Click(object sender, EventArgs e)
        {
            // gerando relatório
            fornecedorTableAdapter.Fill(bdMainDataSet.fornecedor);
            RelatorioBuilder relatorio = new RelatorioBuilder(fornecedorSource);
            relatorio.AddColumn("Id", "Código", 7);
            relatorio.AddColumn("nm_fornecedor", "Nome", 35);
            relatorio.AddColumn("cd_cep", "CEP", 10);
            relatorio.AddColumn("nm_cidade", "Cidade", 25);
            relatorio.AddColumn("nm_bairro", "Bairro", 25);
            relatorio.AddColumn("sg_estado", "Estado", 7);
            relatorio.AddColumn("cd_cnpj", "CNPJ", 20);
            relatorio.AddColumn("cd_inscr_estadual", "Inscrição Estadual", 20);
            string[] pages =  relatorio.Write("Relatório de Fornecedores");
            StartPrinting(pages);

        }

        public enum FormMode
        {
            Visualizacao = 0,
            Cadastro = 1,
            Alteracao = 2
        }

        private void fiveRegisters_Click(object sender, EventArgs e)
        {
            dataGenerator.GenerateAll(5);
        }

        private void fiftyRegisters_Click(object sender, EventArgs e)
        {
            dataGenerator.GenerateAll(50);
        }

        private void hundedRegisters_Click(object sender, EventArgs e)
        {
            dataGenerator.GenerateAll(100);
        }

        private void fiveHundedRegisters_Click(object sender, EventArgs e)
        {
            dataGenerator.GenerateAll(500);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            lblDataHora.Text = $"{currentDate} {currentTime}";
        }
    }
}

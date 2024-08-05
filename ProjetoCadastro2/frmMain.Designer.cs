namespace ProjetoCadastro2
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioUsuariosToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatorioClientesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioFornecedoresToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relUsuarioPD = new System.Drawing.Printing.PrintDocument();
            this.relUsuarioPPD = new System.Windows.Forms.PrintPreviewDialog();
            this.bdMainDataSet = new ProjetoCadastro2.bdMainDataSet();
            this.usuarioSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new ProjetoCadastro2.bdMainDataSetTableAdapters.fornecedorTableAdapter();
            this.clienteTableAdapter = new ProjetoCadastro2.bdMainDataSetTableAdapters.clienteTableAdapter();
            this.usuarioTableAdapter = new ProjetoCadastro2.bdMainDataSetTableAdapters.usuarioTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(801, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioUsuariosToolStrip,
            this.RelatorioClientesToolStrip,
            this.relatorioFornecedoresToolStrip});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatórioToolStripMenuItem.Text = "Relatórios";
            // 
            // relatorioUsuariosToolStrip
            // 
            this.relatorioUsuariosToolStrip.Name = "relatorioUsuariosToolStrip";
            this.relatorioUsuariosToolStrip.Size = new System.Drawing.Size(181, 26);
            this.relatorioUsuariosToolStrip.Text = "Usuários";
            this.relatorioUsuariosToolStrip.Click += new System.EventHandler(this.relatorioUsuariosToolStrip_Click);
            // 
            // RelatorioClientesToolStrip
            // 
            this.RelatorioClientesToolStrip.Name = "RelatorioClientesToolStrip";
            this.RelatorioClientesToolStrip.Size = new System.Drawing.Size(181, 26);
            this.RelatorioClientesToolStrip.Text = "Clientes";
            this.RelatorioClientesToolStrip.Click += new System.EventHandler(this.RelatorioClientesToolStrip_Click);
            // 
            // relatorioFornecedoresToolStrip
            // 
            this.relatorioFornecedoresToolStrip.Name = "relatorioFornecedoresToolStrip";
            this.relatorioFornecedoresToolStrip.Size = new System.Drawing.Size(181, 26);
            this.relatorioFornecedoresToolStrip.Text = "Fornecedores";
            this.relatorioFornecedoresToolStrip.Click += new System.EventHandler(this.relatorioFornecedoresToolStrip_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relUsuarioPD
            // 
            this.relUsuarioPD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintRelatorio);
            // 
            // relUsuarioPPD
            // 
            this.relUsuarioPPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.relUsuarioPPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.relUsuarioPPD.ClientSize = new System.Drawing.Size(400, 300);
            this.relUsuarioPPD.Document = this.relUsuarioPD;
            this.relUsuarioPPD.Enabled = true;
            this.relUsuarioPPD.Icon = ((System.Drawing.Icon)(resources.GetObject("relUsuarioPPD.Icon")));
            this.relUsuarioPPD.Name = "relUsuarioPPD";
            this.relUsuarioPPD.Visible = false;
            // 
            // bdMainDataSet
            // 
            this.bdMainDataSet.DataSetName = "bdMainDataSet";
            this.bdMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioSource
            // 
            this.usuarioSource.DataMember = "usuario";
            this.usuarioSource.DataSource = this.bdMainDataSet;
            // 
            // clienteSource
            // 
            this.clienteSource.DataMember = "cliente";
            this.clienteSource.DataSource = this.bdMainDataSet;
            // 
            // fornecedorSource
            // 
            this.fornecedorSource.DataMember = "fornecedor";
            this.fornecedorSource.DataSource = this.bdMainDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 421);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Projeto Cadastro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioUsuariosToolStrip;
        private System.Windows.Forms.ToolStripMenuItem RelatorioClientesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem relatorioFornecedoresToolStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument relUsuarioPD;
        private System.Windows.Forms.PrintPreviewDialog relUsuarioPPD;
        private bdMainDataSet bdMainDataSet;
        private System.Windows.Forms.BindingSource usuarioSource;
        private System.Windows.Forms.BindingSource clienteSource;
        private System.Windows.Forms.BindingSource fornecedorSource;
        private bdMainDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private bdMainDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private bdMainDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
    }
}


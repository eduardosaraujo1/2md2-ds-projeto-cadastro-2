namespace ProjetoCadastro2
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label nr_telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.bdMainDataSet = new ProjetoCadastro2.bdMainDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProjetoCadastro2.bdMainDataSetTableAdapters.clienteTableAdapter();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            idLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            nr_telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(61, 20);
            idLabel.TabIndex = 2;
            idLabel.Text = "Código";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Location = new System.Drawing.Point(31, 59);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(53, 20);
            nm_clienteLabel.TabIndex = 3;
            nm_clienteLabel.Text = "Nome";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(29, 147);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 5;
            nm_bairroLabel.Text = "Bairro";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(4, 103);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(80, 20);
            ds_enderecoLabel.TabIndex = 7;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(225, 147);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(61, 20);
            nm_cidadeLabel.TabIndex = 9;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(474, 147);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(61, 20);
            sg_estadoLabel.TabIndex = 11;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(41, 191);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(43, 20);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "CEP";
            // 
            // nr_telefoneLabel
            // 
            nr_telefoneLabel.AutoSize = true;
            nr_telefoneLabel.Location = new System.Drawing.Point(483, 234);
            nr_telefoneLabel.Name = "nr_telefoneLabel";
            nr_telefoneLabel.Size = new System.Drawing.Size(73, 20);
            nr_telefoneLabel.TabIndex = 15;
            nr_telefoneLabel.Text = "Telefone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 234);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 20);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "E-mail";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Location = new System.Drawing.Point(42, 278);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(42, 20);
            cd_cpfLabel.TabIndex = 19;
            cd_cpfLabel.Text = "CPF";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Location = new System.Drawing.Point(268, 278);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(34, 20);
            cd_rgLabel.TabIndex = 21;
            cd_rgLabel.Text = "RG";
            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 5;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.Controls.Add(this.btnSair, 4, 1);
            this.pnlButtons.Controls.Add(this.btnImprimir, 3, 1);
            this.pnlButtons.Controls.Add(this.btnPesquisar, 2, 1);
            this.pnlButtons.Controls.Add(this.btnCancelar, 1, 1);
            this.pnlButtons.Controls.Add(this.btnSalvar, 0, 1);
            this.pnlButtons.Controls.Add(this.btnExcluir, 4, 0);
            this.pnlButtons.Controls.Add(this.btnAlterar, 3, 0);
            this.pnlButtons.Controls.Add(this.btnNovo, 2, 0);
            this.pnlButtons.Controls.Add(this.btnAnterior, 0, 0);
            this.pnlButtons.Controls.Add(this.btnProximo, 1, 0);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons.Location = new System.Drawing.Point(0, 325);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(6);
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(740, 116);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(590, 62);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(140, 44);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Location = new System.Drawing.Point(445, 62);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(137, 44);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(300, 62);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 44);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(155, 62);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 44);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.Location = new System.Drawing.Point(10, 62);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 44);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(590, 10);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Location = new System.Drawing.Point(445, 10);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 44);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovo.Location = new System.Drawing.Point(300, 10);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(137, 44);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.Location = new System.Drawing.Point(10, 10);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(137, 44);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximo.Location = new System.Drawing.Point(155, 10);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(137, 44);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // bdMainDataSet
            // 
            this.bdMainDataSet.DataSetName = "bdMainDataSet";
            this.bdMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bdMainDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true));
            this.txtCodigo.Location = new System.Drawing.Point(88, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nm_cliente", true));
            this.txtNome.Location = new System.Drawing.Point(89, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(414, 27);
            this.txtNome.TabIndex = 2;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nm_bairro", true));
            this.txtBairro.Location = new System.Drawing.Point(89, 144);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(130, 27);
            this.txtBairro.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ds_endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(89, 100);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(635, 27);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nm_cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(294, 144);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(162, 27);
            this.txtCidade.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "sg_estado", true));
            this.txtEstado.Location = new System.Drawing.Point(543, 144);
            this.txtEstado.Mask = ">LL";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 27);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtCep
            // 
            this.txtCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cd_cep", true));
            this.txtCep.Location = new System.Drawing.Point(89, 188);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 27);
            this.txtCep.TabIndex = 7;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nr_telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(562, 231);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(162, 27);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(89, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(374, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cd_cpf", true));
            this.txtCpf.Location = new System.Drawing.Point(89, 275);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 27);
            this.txtCpf.TabIndex = 10;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtRg
            // 
            this.txtRg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cd_rg", true));
            this.txtRg.Location = new System.Drawing.Point(308, 275);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(129, 27);
            this.txtRg.TabIndex = 11;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(idLabel);
            this.pnlContent.Controls.Add(cd_rgLabel);
            this.pnlContent.Controls.Add(this.txtCodigo);
            this.pnlContent.Controls.Add(this.txtRg);
            this.pnlContent.Controls.Add(this.txtNome);
            this.pnlContent.Controls.Add(cd_cpfLabel);
            this.pnlContent.Controls.Add(nm_clienteLabel);
            this.pnlContent.Controls.Add(this.txtCpf);
            this.pnlContent.Controls.Add(this.txtBairro);
            this.pnlContent.Controls.Add(emailLabel);
            this.pnlContent.Controls.Add(nm_bairroLabel);
            this.pnlContent.Controls.Add(this.txtEmail);
            this.pnlContent.Controls.Add(this.txtEndereco);
            this.pnlContent.Controls.Add(nr_telefoneLabel);
            this.pnlContent.Controls.Add(ds_enderecoLabel);
            this.pnlContent.Controls.Add(this.txtTelefone);
            this.pnlContent.Controls.Add(this.txtCidade);
            this.pnlContent.Controls.Add(cd_cepLabel);
            this.pnlContent.Controls.Add(nm_cidadeLabel);
            this.pnlContent.Controls.Add(this.txtCep);
            this.pnlContent.Controls.Add(this.txtEstado);
            this.pnlContent.Controls.Add(sg_estadoLabel);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(740, 325);
            this.pnlContent.TabIndex = 23;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 441);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButtons);
            this.MinimumSize = new System.Drawing.Size(758, 488);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private bdMainDataSet bdMainDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bdMainDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Panel pnlContent;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}
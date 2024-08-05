namespace ProjetoCadastro2
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_inscr_estadualLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.txtInscrEstadual = new System.Windows.Forms.MaskedTextBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMainDataSet = new ProjetoCadastro2.bdMainDataSet();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.fornecedorTableAdapter = new ProjetoCadastro2.bdMainDataSetTableAdapters.fornecedorTableAdapter();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            idLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_inscr_estadualLabel = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(61, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Código";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Location = new System.Drawing.Point(34, 50);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(53, 20);
            nm_fornecedorLabel.TabIndex = 2;
            nm_fornecedorLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(3, 124);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(80, 20);
            ds_enderecoLabel.TabIndex = 4;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(32, 157);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 6;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(263, 157);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(61, 20);
            nm_cidadeLabel.TabIndex = 8;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(26, 194);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(61, 20);
            sg_estadoLabel.TabIndex = 10;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(483, 157);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(43, 20);
            cd_cepLabel.TabIndex = 12;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Location = new System.Drawing.Point(34, 85);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(53, 20);
            cd_cnpjLabel.TabIndex = 14;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // cd_inscr_estadualLabel
            // 
            cd_inscr_estadualLabel.AutoSize = true;
            cd_inscr_estadualLabel.Location = new System.Drawing.Point(280, 85);
            cd_inscr_estadualLabel.Name = "cd_inscr_estadualLabel";
            cd_inscr_estadualLabel.Size = new System.Drawing.Size(120, 20);
            cd_inscr_estadualLabel.TabIndex = 16;
            cd_inscr_estadualLabel.Text = "Inscr. Estadual";
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
            this.pnlButtons.Location = new System.Drawing.Point(0, 256);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(6);
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(667, 116);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(534, 62);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 44);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Location = new System.Drawing.Point(403, 62);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 44);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(272, 62);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(123, 44);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(141, 62);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 44);
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
            this.btnSalvar.Size = new System.Drawing.Size(123, 44);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(534, 10);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Location = new System.Drawing.Point(403, 10);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 44);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovo.Location = new System.Drawing.Point(272, 10);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 44);
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
            this.btnAnterior.Size = new System.Drawing.Size(123, 44);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximo.Location = new System.Drawing.Point(141, 10);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(123, 44);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(cd_inscr_estadualLabel);
            this.pnlContent.Controls.Add(this.txtInscrEstadual);
            this.pnlContent.Controls.Add(cd_cnpjLabel);
            this.pnlContent.Controls.Add(this.txtCnpj);
            this.pnlContent.Controls.Add(cd_cepLabel);
            this.pnlContent.Controls.Add(this.txtCep);
            this.pnlContent.Controls.Add(sg_estadoLabel);
            this.pnlContent.Controls.Add(this.txtEstado);
            this.pnlContent.Controls.Add(nm_cidadeLabel);
            this.pnlContent.Controls.Add(this.txtCidade);
            this.pnlContent.Controls.Add(nm_bairroLabel);
            this.pnlContent.Controls.Add(this.txtBairro);
            this.pnlContent.Controls.Add(ds_enderecoLabel);
            this.pnlContent.Controls.Add(this.txtEndereco);
            this.pnlContent.Controls.Add(nm_fornecedorLabel);
            this.pnlContent.Controls.Add(this.txtNome);
            this.pnlContent.Controls.Add(idLabel);
            this.pnlContent.Controls.Add(this.txtCodigo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(667, 256);
            this.pnlContent.TabIndex = 24;
            // 
            // txtInscrEstadual
            // 
            this.txtInscrEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscrEstadual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cd_inscr_estadual", true));
            this.txtInscrEstadual.Location = new System.Drawing.Point(416, 82);
            this.txtInscrEstadual.Mask = "000.000.000.000";
            this.txtInscrEstadual.Name = "txtInscrEstadual";
            this.txtInscrEstadual.Size = new System.Drawing.Size(238, 27);
            this.txtInscrEstadual.TabIndex = 4;
            this.txtInscrEstadual.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.bdMainDataSet;
            // 
            // bdMainDataSet
            // 
            this.bdMainDataSet.DataSetName = "bdMainDataSet";
            this.bdMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCnpj
            // 
            this.txtCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cd_cnpj", true));
            this.txtCnpj.Location = new System.Drawing.Point(93, 82);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(181, 27);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtCep
            // 
            this.txtCep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cd_cep", true));
            this.txtCep.Location = new System.Drawing.Point(532, 154);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(122, 27);
            this.txtCep.TabIndex = 8;
            this.txtCep.Text = "42423423";
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtEstado
            // 
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "sg_estado", true));
            this.txtEstado.Location = new System.Drawing.Point(93, 191);
            this.txtEstado.Mask = ">LL";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(42, 27);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nm_cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(330, 154);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(146, 27);
            this.txtCidade.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nm_bairro", true));
            this.txtBairro.Location = new System.Drawing.Point(93, 154);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(164, 27);
            this.txtBairro.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "ds_endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(93, 121);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(561, 27);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nm_fornecedor", true));
            this.txtNome.Location = new System.Drawing.Point(93, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(561, 27);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Id", true));
            this.txtCodigo.Location = new System.Drawing.Point(93, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(98, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
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
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 372);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButtons);
            this.MinimumSize = new System.Drawing.Size(685, 419);
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMainDataSet)).EndInit();
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
        private System.Windows.Forms.Panel pnlContent;
        private bdMainDataSet bdMainDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private bdMainDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtInscrEstadual;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCidade;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}
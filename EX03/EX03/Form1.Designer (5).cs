namespace EX03
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grpDadosClientes = new System.Windows.Forms.GroupBox();
            this.chkNotaPaulista = new System.Windows.Forms.CheckBox();
            this.lblCupomFiscal = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCupomFiscal = new System.Windows.Forms.GroupBox();
            this.btnConfirmaSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lstItensCupom = new System.Windows.Forms.ListBox();
            this.grpProdutoAtual = new System.Windows.Forms.GroupBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantidadeItens = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.grpFormaPagamento = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.btnAbreCupom = new System.Windows.Forms.Button();
            this.pctCarrinho = new System.Windows.Forms.PictureBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.pctLogotipoTabajara = new System.Windows.Forms.PictureBox();
            this.grpDadosClientes.SuspendLayout();
            this.grpCupomFiscal.SuspendLayout();
            this.grpProdutoAtual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogotipoTabajara)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosClientes
            // 
            this.grpDadosClientes.Controls.Add(this.btnAbreCupom);
            this.grpDadosClientes.Controls.Add(this.chkNotaPaulista);
            this.grpDadosClientes.Controls.Add(this.lblCupomFiscal);
            this.grpDadosClientes.Controls.Add(this.mskCPF);
            this.grpDadosClientes.Location = new System.Drawing.Point(12, 12);
            this.grpDadosClientes.Name = "grpDadosClientes";
            this.grpDadosClientes.Size = new System.Drawing.Size(280, 323);
            this.grpDadosClientes.TabIndex = 0;
            this.grpDadosClientes.TabStop = false;
            this.grpDadosClientes.Text = " Dados dos Clientes ";
            // 
            // chkNotaPaulista
            // 
            this.chkNotaPaulista.AutoSize = true;
            this.chkNotaPaulista.Location = new System.Drawing.Point(16, 33);
            this.chkNotaPaulista.Name = "chkNotaPaulista";
            this.chkNotaPaulista.Size = new System.Drawing.Size(119, 17);
            this.chkNotaPaulista.TabIndex = 2;
            this.chkNotaPaulista.Text = "Nota Fiscal Paulista";
            this.chkNotaPaulista.UseVisualStyleBackColor = true;
            this.chkNotaPaulista.CheckedChanged += new System.EventHandler(this.chkNotaPaulista_CheckedChanged);
            // 
            // lblCupomFiscal
            // 
            this.lblCupomFiscal.AutoSize = true;
            this.lblCupomFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupomFiscal.ForeColor = System.Drawing.Color.Red;
            this.lblCupomFiscal.Location = new System.Drawing.Point(9, 104);
            this.lblCupomFiscal.Name = "lblCupomFiscal";
            this.lblCupomFiscal.Size = new System.Drawing.Size(242, 39);
            this.lblCupomFiscal.TabIndex = 5;
            this.lblCupomFiscal.Text = "Cupom Fiscal";
            this.lblCupomFiscal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCupomFiscal.Visible = false;
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(16, 60);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(160, 26);
            this.mskCPF.TabIndex = 1;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(455, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 146);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Supermercado\r\nTabajara";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpCupomFiscal
            // 
            this.grpCupomFiscal.Controls.Add(this.btnConfirmaSenha);
            this.grpCupomFiscal.Controls.Add(this.txtSenha);
            this.grpCupomFiscal.Controls.Add(this.btnRemoverProduto);
            this.grpCupomFiscal.Controls.Add(this.lstItensCupom);
            this.grpCupomFiscal.Location = new System.Drawing.Point(329, 407);
            this.grpCupomFiscal.Name = "grpCupomFiscal";
            this.grpCupomFiscal.Size = new System.Drawing.Size(616, 323);
            this.grpCupomFiscal.TabIndex = 3;
            this.grpCupomFiscal.TabStop = false;
            this.grpCupomFiscal.Text = " Cupom Fiscal ";
            // 
            // btnConfirmaSenha
            // 
            this.btnConfirmaSenha.Enabled = false;
            this.btnConfirmaSenha.Location = new System.Drawing.Point(477, 254);
            this.btnConfirmaSenha.Name = "btnConfirmaSenha";
            this.btnConfirmaSenha.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaSenha.TabIndex = 11;
            this.btnConfirmaSenha.Text = "Excluir";
            this.btnConfirmaSenha.UseVisualStyleBackColor = true;
            this.btnConfirmaSenha.Click += new System.EventHandler(this.btnConfirmaSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(463, 228);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lstItensCupom
            // 
            this.lstItensCupom.FormattingEnabled = true;
            this.lstItensCupom.Location = new System.Drawing.Point(16, 24);
            this.lstItensCupom.Name = "lstItensCupom";
            this.lstItensCupom.Size = new System.Drawing.Size(390, 290);
            this.lstItensCupom.TabIndex = 4;
            this.lstItensCupom.SelectedIndexChanged += new System.EventHandler(this.lstItensCupom_SelectedIndexChanged);
            // 
            // grpProdutoAtual
            // 
            this.grpProdutoAtual.Controls.Add(this.btnAdicionarProduto);
            this.grpProdutoAtual.Controls.Add(this.txtPrecoUnitario);
            this.grpProdutoAtual.Controls.Add(this.lblPrecoUnitario);
            this.grpProdutoAtual.Controls.Add(this.txtDescricao);
            this.grpProdutoAtual.Controls.Add(this.lblDescricao);
            this.grpProdutoAtual.Controls.Add(this.txtQuantidade);
            this.grpProdutoAtual.Controls.Add(this.lblQuantidade);
            this.grpProdutoAtual.Controls.Add(this.txtCodigoBarras);
            this.grpProdutoAtual.Controls.Add(this.lblCodigoBarras);
            this.grpProdutoAtual.Enabled = false;
            this.grpProdutoAtual.Location = new System.Drawing.Point(329, 227);
            this.grpProdutoAtual.Name = "grpProdutoAtual";
            this.grpProdutoAtual.Size = new System.Drawing.Size(616, 154);
            this.grpProdutoAtual.TabIndex = 4;
            this.grpProdutoAtual.TabStop = false;
            this.grpProdutoAtual.Text = " Produto Atual ";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(117, 123);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(71, 20);
            this.txtPrecoUnitario.TabIndex = 4;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(13, 126);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(74, 13);
            this.lblPrecoUnitario.TabIndex = 6;
            this.lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(117, 88);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(279, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 91);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(117, 56);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(37, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(13, 63);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(117, 24);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(13, 31);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Código de Barras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuantidadeItens);
            this.groupBox1.Controls.Add(this.lblTotalCompra);
            this.groupBox1.Controls.Add(this.btnPagamento);
            this.groupBox1.Location = new System.Drawing.Point(951, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Total da Compra ";
            // 
            // lblQuantidadeItens
            // 
            this.lblQuantidadeItens.AutoSize = true;
            this.lblQuantidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeItens.ForeColor = System.Drawing.Color.Red;
            this.lblQuantidadeItens.Location = new System.Drawing.Point(92, 90);
            this.lblQuantidadeItens.Name = "lblQuantidadeItens";
            this.lblQuantidadeItens.Size = new System.Drawing.Size(97, 39);
            this.lblQuantidadeItens.TabIndex = 11;
            this.lblQuantidadeItens.Text = "Itens";
            this.lblQuantidadeItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantidadeItens.Visible = false;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCompra.Location = new System.Drawing.Point(85, 37);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(73, 39);
            this.lblTotalCompra.TabIndex = 10;
            this.lblTotalCompra.Text = "R$ ";
            this.lblTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalCompra.Visible = false;
            // 
            // grpFormaPagamento
            // 
            this.grpFormaPagamento.Controls.Add(this.btnFinalizarCompra);
            this.grpFormaPagamento.Controls.Add(this.lblTroco);
            this.grpFormaPagamento.Controls.Add(this.lblValorRecebido);
            this.grpFormaPagamento.Controls.Add(this.txtValorRecebido);
            this.grpFormaPagamento.Controls.Add(this.rdbDinheiro);
            this.grpFormaPagamento.Controls.Add(this.rdbCredito);
            this.grpFormaPagamento.Controls.Add(this.rdbDebito);
            this.grpFormaPagamento.Enabled = false;
            this.grpFormaPagamento.Location = new System.Drawing.Point(951, 512);
            this.grpFormaPagamento.Name = "grpFormaPagamento";
            this.grpFormaPagamento.Size = new System.Drawing.Size(385, 218);
            this.grpFormaPagamento.TabIndex = 7;
            this.grpFormaPagamento.TabStop = false;
            this.grpFormaPagamento.Text = " Forma de Pagamento ";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(6, 170);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(178, 39);
            this.lblTroco.TabIndex = 12;
            this.lblTroco.Text = "Troco: R$";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTroco.Visible = false;
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Enabled = false;
            this.lblValorRecebido.Location = new System.Drawing.Point(90, 81);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(80, 13);
            this.lblValorRecebido.TabIndex = 4;
            this.lblValorRecebido.Text = "Valor Recebido";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Enabled = false;
            this.txtValorRecebido.Location = new System.Drawing.Point(92, 97);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtValorRecebido.TabIndex = 3;
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(20, 77);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rdbDinheiro.TabIndex = 2;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(20, 54);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 1;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Checked = true;
            this.rdbDebito.Location = new System.Drawing.Point(20, 31);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(56, 17);
            this.rdbDebito.TabIndex = 0;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // btnAbreCupom
            // 
            this.btnAbreCupom.Image = global::EX03.Properties.Resources.NFe;
            this.btnAbreCupom.Location = new System.Drawing.Point(67, 167);
            this.btnAbreCupom.Name = "btnAbreCupom";
            this.btnAbreCupom.Size = new System.Drawing.Size(141, 123);
            this.btnAbreCupom.TabIndex = 3;
            this.btnAbreCupom.Text = "Abre Cupom";
            this.btnAbreCupom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbreCupom.UseVisualStyleBackColor = true;
            this.btnAbreCupom.Click += new System.EventHandler(this.btnAbreCupom_Click);
            // 
            // pctCarrinho
            // 
            this.pctCarrinho.Image = global::EX03.Properties.Resources.carrinho_de_compras_de_design_de_linhas_horizontais_318_50800;
            this.pctCarrinho.Location = new System.Drawing.Point(12, 520);
            this.pctCarrinho.Name = "pctCarrinho";
            this.pctCarrinho.Size = new System.Drawing.Size(246, 209);
            this.pctCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarrinho.TabIndex = 8;
            this.pctCarrinho.TabStop = false;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Image = global::EX03.Properties.Resources.FInalizar_Compra;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(238, 51);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(141, 123);
            this.btnFinalizarCompra.TabIndex = 12;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Enabled = false;
            this.btnPagamento.Image = global::EX03.Properties.Resources.Pagar;
            this.btnPagamento.Location = new System.Drawing.Point(128, 141);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(141, 123);
            this.btnPagamento.TabIndex = 9;
            this.btnPagamento.Text = "Ir para Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnFinalizaCompra_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Image = global::EX03.Properties.Resources.Adicionar;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(451, 16);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(141, 123);
            this.btnAdicionarProduto.TabIndex = 8;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Enabled = false;
            this.btnRemoverProduto.Image = global::EX03.Properties.Resources.Remover;
            this.btnRemoverProduto.Location = new System.Drawing.Point(440, 99);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(141, 123);
            this.btnRemoverProduto.TabIndex = 9;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctLogotipoTabajara
            // 
            this.pctLogotipoTabajara.Image = global::EX03.Properties.Resources.Tabajara;
            this.pctLogotipoTabajara.Location = new System.Drawing.Point(1055, 12);
            this.pctLogotipoTabajara.Name = "pctLogotipoTabajara";
            this.pctLogotipoTabajara.Size = new System.Drawing.Size(295, 209);
            this.pctLogotipoTabajara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogotipoTabajara.TabIndex = 1;
            this.pctLogotipoTabajara.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnAbreCupom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pctCarrinho);
            this.Controls.Add(this.grpFormaPagamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProdutoAtual);
            this.Controls.Add(this.grpCupomFiscal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogotipoTabajara);
            this.Controls.Add(this.grpDadosClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Supermercado Organizações Tabajara";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpDadosClientes.ResumeLayout(false);
            this.grpDadosClientes.PerformLayout();
            this.grpCupomFiscal.ResumeLayout(false);
            this.grpCupomFiscal.PerformLayout();
            this.grpProdutoAtual.ResumeLayout(false);
            this.grpProdutoAtual.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFormaPagamento.ResumeLayout(false);
            this.grpFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogotipoTabajara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosClientes;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.CheckBox chkNotaPaulista;
        private System.Windows.Forms.PictureBox pctLogotipoTabajara;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCupomFiscal;
        private System.Windows.Forms.ListBox lstItensCupom;
        private System.Windows.Forms.GroupBox grpProdutoAtual;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Button btnAbreCupom;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblCupomFiscal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuantidadeItens;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.GroupBox grpFormaPagamento;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.PictureBox pctCarrinho;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnConfirmaSenha;
    }
}


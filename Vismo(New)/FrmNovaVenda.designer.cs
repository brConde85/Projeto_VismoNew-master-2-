namespace Vismo_New_
{
    partial class FrmNovaVenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.MaskedTextBox();
            this.txtTroco = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pchave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblChave = new System.Windows.Forms.Label();
            this.cboPalavra = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pctExclamation = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblOpcao = new System.Windows.Forms.Label();
            this.lblFalhaPesquisa1 = new System.Windows.Forms.Label();
            this.lblFalhaPesquisa2 = new System.Windows.Forms.Label();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.NumericUpDown();
            this.lblOpPesquisa = new System.Windows.Forms.Label();
            this.lblFalhaPesquisa3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRow)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label2.Location = new System.Drawing.Point(23, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label3.Location = new System.Drawing.Point(948, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label4.Location = new System.Drawing.Point(1108, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Troco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label5.Location = new System.Drawing.Point(85, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "R$";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(121, 487);
            this.txtPago.Mask = "999.99";
            this.txtPago.Name = "txtPago";
            this.txtPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPago.Size = new System.Drawing.Size(108, 45);
            this.txtPago.TabIndex = 6;
            this.txtPago.ValidatingType = typeof(int);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPago_KeyPress);
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(1113, 514);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(104, 45);
            this.txtTroco.TabIndex = 12;
            this.txtTroco.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(953, 514);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 45);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label6.Location = new System.Drawing.Point(917, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label7.Location = new System.Drawing.Point(1076, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "R$";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(193, 122);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(50, 26);
            this.txtCod.TabIndex = 0;
            this.txtCod.Click += new System.EventHandler(this.TxtCod_Click);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCod_KeyPress);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.lblCod.Location = new System.Drawing.Point(29, 124);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(158, 22);
            this.lblCod.TabIndex = 16;
            this.lblCod.Text = "Código do produto:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Preco,
            this.QtdEstoque,
            this.Pchave});
            this.dataGridView2.Location = new System.Drawing.Point(27, 227);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(428, 86);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Codigo";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 35;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 90;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.MinimumWidth = 8;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 50;
            // 
            // QtdEstoque
            // 
            this.QtdEstoque.DataPropertyName = "QtdEstoque";
            this.QtdEstoque.HeaderText = "Qtd.Estoque";
            this.QtdEstoque.MinimumWidth = 8;
            this.QtdEstoque.Name = "QtdEstoque";
            this.QtdEstoque.ReadOnly = true;
            this.QtdEstoque.Width = 50;
            // 
            // Pchave
            // 
            this.Pchave.DataPropertyName = "Pchave";
            this.Pchave.HeaderText = "Palavra-Chave";
            this.Pchave.MinimumWidth = 8;
            this.Pchave.Name = "Pchave";
            this.Pchave.ReadOnly = true;
            this.Pchave.Width = 150;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnOk.Location = new System.Drawing.Point(636, 489);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 53);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Confirmar Venda";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.BtnOk_MouseEnter);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(751, 489);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 53);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(463, 227);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 35);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.BtnPesquisar_MouseEnter);
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.lblChave.Location = new System.Drawing.Point(261, 171);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(125, 22);
            this.lblChave.TabIndex = 22;
            this.lblChave.Text = "Palavra-Chave:";
            this.lblChave.Visible = false;
            // 
            // cboPalavra
            // 
            this.cboPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPalavra.FormattingEnabled = true;
            this.cboPalavra.Items.AddRange(new object[] {
            "Lata",
            "Garrafa",
            "Pacote",
            "Enlatado",
            "Unidade",
            "Outro"});
            this.cboPalavra.Location = new System.Drawing.Point(392, 169);
            this.cboPalavra.Name = "cboPalavra";
            this.cboPalavra.Size = new System.Drawing.Size(121, 28);
            this.cboPalavra.TabIndex = 2;
            this.cboPalavra.Visible = false;
            this.cboPalavra.Click += new System.EventHandler(this.CboPalavra_Click);
            this.cboPalavra.Enter += new System.EventHandler(this.CboPalavra_Enter);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.lblNome.Location = new System.Drawing.Point(29, 173);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 22);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(95, 171);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Visible = false;
            this.txtNome.Click += new System.EventHandler(this.TxtNome_Click);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label11.Location = new System.Drawing.Point(29, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Quantidade desejada:";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(221, 357);
            this.txtQtd.MaxLength = 2;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(34, 26);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.Text = "1";
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.TxtQtd_Leave);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAdicionar.Location = new System.Drawing.Point(463, 279);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 33);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.BtnAdicionar_MouseEnter);
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnValidar.Location = new System.Drawing.Point(283, 476);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(111, 52);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar Venda";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            this.btnValidar.MouseEnter += new System.EventHandler(this.BtnValidar_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Numero});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(636, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(579, 391);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QtdEstoque";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qtd.Estoque";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pchave";
            this.dataGridViewTextBoxColumn5.HeaderText = "Palavra-Chave";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.MinimumWidth = 8;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 150;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRelatorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRelatorio.Location = new System.Drawing.Point(1073, 576);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(137, 67);
            this.btnRelatorio.TabIndex = 10;
            this.btnRelatorio.Text = "Relatório  ou cancelamento de vendas";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            this.btnRelatorio.MouseEnter += new System.EventHandler(this.BtnRelatorio_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(631, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 31);
            this.label1.TabIndex = 87;
            this.label1.Text = "Produtos selecionados para venda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 31);
            this.label12.TabIndex = 88;
            this.label12.Text = "Pesquisar Produtos";
            // 
            // pctExclamation
            // 
            this.pctExclamation.Image = global::Vismo_New_.Properties.Resources.Untitled;
            this.pctExclamation.Location = new System.Drawing.Point(241, 489);
            this.pctExclamation.Margin = new System.Windows.Forms.Padding(2);
            this.pctExclamation.Name = "pctExclamation";
            this.pctExclamation.Size = new System.Drawing.Size(13, 36);
            this.pctExclamation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExclamation.TabIndex = 90;
            this.pctExclamation.TabStop = false;
            this.pctExclamation.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::Vismo_New_.Properties.Resources.Logo21;
            this.pictureBox4.Location = new System.Drawing.Point(0, 839);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-391, 867);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2315, 232);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 320);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 31);
            this.label13.TabIndex = 91;
            this.label13.Text = "Valor pago pelo cliente";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpcao.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOpcao.Location = new System.Drawing.Point(289, 132);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(170, 16);
            this.lblOpcao.TabIndex = 92;
            this.lblOpcao.Text = "Alternar opções de pesquisa";
            this.lblOpcao.Click += new System.EventHandler(this.LblOpcao_Click);
            this.lblOpcao.MouseEnter += new System.EventHandler(this.LblOpcao_MouseEnter);
            this.lblOpcao.MouseLeave += new System.EventHandler(this.LblOpcao_MouseLeave);
            // 
            // lblFalhaPesquisa1
            // 
            this.lblFalhaPesquisa1.AutoSize = true;
            this.lblFalhaPesquisa1.BackColor = System.Drawing.Color.Transparent;
            this.lblFalhaPesquisa1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFalhaPesquisa1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalhaPesquisa1.ForeColor = System.Drawing.Color.Red;
            this.lblFalhaPesquisa1.Location = new System.Drawing.Point(26, 208);
            this.lblFalhaPesquisa1.Name = "lblFalhaPesquisa1";
            this.lblFalhaPesquisa1.Size = new System.Drawing.Size(264, 16);
            this.lblFalhaPesquisa1.TabIndex = 93;
            this.lblFalhaPesquisa1.Text = "Nenhum campo para pesquisa foi preenchido";
            this.lblFalhaPesquisa1.Visible = false;
            // 
            // lblFalhaPesquisa2
            // 
            this.lblFalhaPesquisa2.AutoSize = true;
            this.lblFalhaPesquisa2.BackColor = System.Drawing.Color.Transparent;
            this.lblFalhaPesquisa2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFalhaPesquisa2.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalhaPesquisa2.ForeColor = System.Drawing.Color.Red;
            this.lblFalhaPesquisa2.Location = new System.Drawing.Point(29, 208);
            this.lblFalhaPesquisa2.Name = "lblFalhaPesquisa2";
            this.lblFalhaPesquisa2.Size = new System.Drawing.Size(167, 16);
            this.lblFalhaPesquisa2.TabIndex = 94;
            this.lblFalhaPesquisa2.Text = "Nenhum produto encontrado";
            this.lblFalhaPesquisa2.Visible = false;
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.AutoSize = true;
            this.lblAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAdicionar.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionar.ForeColor = System.Drawing.Color.Red;
            this.lblAdicionar.Location = new System.Drawing.Point(443, 325);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(131, 16);
            this.lblAdicionar.TabIndex = 95;
            this.lblAdicionar.Text = "Nada para adicionar";
            this.lblAdicionar.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblValor.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Red;
            this.lblValor.Location = new System.Drawing.Point(135, 535);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(87, 16);
            this.lblValor.TabIndex = 96;
            this.lblValor.Text = "Valor inválido";
            this.lblValor.Visible = false;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(0, 23);
            this.txtRow.Margin = new System.Windows.Forms.Padding(2);
            this.txtRow.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(27, 20);
            this.txtRow.TabIndex = 97;
            this.txtRow.Visible = false;
            this.txtRow.ValueChanged += new System.EventHandler(this.TxtRow_ValueChanged);
            // 
            // lblOpPesquisa
            // 
            this.lblOpPesquisa.AutoSize = true;
            this.lblOpPesquisa.Location = new System.Drawing.Point(577, 76);
            this.lblOpPesquisa.Name = "lblOpPesquisa";
            this.lblOpPesquisa.Size = new System.Drawing.Size(13, 13);
            this.lblOpPesquisa.TabIndex = 98;
            this.lblOpPesquisa.Text = "1";
            this.lblOpPesquisa.Visible = false;
            // 
            // lblFalhaPesquisa3
            // 
            this.lblFalhaPesquisa3.AutoSize = true;
            this.lblFalhaPesquisa3.BackColor = System.Drawing.Color.Transparent;
            this.lblFalhaPesquisa3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFalhaPesquisa3.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalhaPesquisa3.ForeColor = System.Drawing.Color.Red;
            this.lblFalhaPesquisa3.Location = new System.Drawing.Point(30, 208);
            this.lblFalhaPesquisa3.Name = "lblFalhaPesquisa3";
            this.lblFalhaPesquisa3.Size = new System.Drawing.Size(322, 16);
            this.lblFalhaPesquisa3.TabIndex = 99;
            this.lblFalhaPesquisa3.Text = "Informe o nome do produto para esse tipo de pesquisa";
            this.lblFalhaPesquisa3.Visible = false;
            // 
            // FrmNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.lblFalhaPesquisa3);
            this.Controls.Add(this.lblOpPesquisa);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblAdicionar);
            this.Controls.Add(this.lblFalhaPesquisa2);
            this.Controls.Add(this.lblFalhaPesquisa1);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pctExclamation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cboPalavra);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "FrmNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Realizar Venda - Vismo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNovaVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPago;
        private System.Windows.Forms.MaskedTextBox txtTroco;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.ComboBox cboPalavra;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctExclamation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pchave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Label lblFalhaPesquisa1;
        private System.Windows.Forms.Label lblFalhaPesquisa2;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown txtRow;
        private System.Windows.Forms.Label lblOpPesquisa;
        private System.Windows.Forms.Label lblFalhaPesquisa3;
    }
}
namespace Vismo_New_
{
    partial class FrmListarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarProduto));
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPalChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumncodForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.chkSelecionar = new System.Windows.Forms.CheckBox();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.chkDesabilitados = new System.Windows.Forms.CheckBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.id,
            this.ColumnNome,
            this.ColumnPreco,
            this.ColumnQtdEstoque,
            this.ColumnPalChave,
            this.Status,
            this.ColumncodForn});
            this.dgvProduto.Location = new System.Drawing.Point(80, 232);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowHeadersWidth = 62;
            this.dgvProduto.RowTemplate.Height = 28;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(964, 352);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellDoubleClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.MinimumWidth = 8;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.TrueValue = "";
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "Codigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Código";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 8;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 140;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.MinimumWidth = 8;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            this.ColumnPreco.Width = 80;
            // 
            // ColumnQtdEstoque
            // 
            this.ColumnQtdEstoque.DataPropertyName = "QtdEstoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnQtdEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnQtdEstoque.HeaderText = "Qtd Estoque";
            this.ColumnQtdEstoque.MinimumWidth = 8;
            this.ColumnQtdEstoque.Name = "ColumnQtdEstoque";
            this.ColumnQtdEstoque.ReadOnly = true;
            this.ColumnQtdEstoque.Width = 60;
            // 
            // ColumnPalChave
            // 
            this.ColumnPalChave.DataPropertyName = "Pchave";
            this.ColumnPalChave.HeaderText = "Palavra Chave";
            this.ColumnPalChave.MinimumWidth = 8;
            this.ColumnPalChave.Name = "ColumnPalChave";
            this.ColumnPalChave.ReadOnly = true;
            this.ColumnPalChave.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // ColumncodForn
            // 
            this.ColumncodForn.DataPropertyName = "fornecedor";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumncodForn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumncodForn.HeaderText = "Fornecedor";
            this.ColumncodForn.MinimumWidth = 8;
            this.ColumncodForn.Name = "ColumncodForn";
            this.ColumncodForn.ReadOnly = true;
            this.ColumncodForn.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(60, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 384);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1132, 36);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(75, 32);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(-898, 688);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2888, 42);
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Vismo_New_.Properties.Resources.Logo21;
            this.pictureBox2.Location = new System.Drawing.Point(0, 643);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(915, 612);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 40);
            this.btnVoltar.TabIndex = 78;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.SystemColors.Control;
            this.lblMsg.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.lblMsg.Location = new System.Drawing.Point(780, 48);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(340, 56);
            this.lblMsg.TabIndex = 96;
            this.lblMsg.Text = "Selecione um registro para editar,\r\ndesabilitar ou remover.";
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrado.ForeColor = System.Drawing.Color.Red;
            this.lblEncontrado.Location = new System.Drawing.Point(178, 185);
            this.lblEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(211, 20);
            this.lblEncontrado.TabIndex = 102;
            this.lblEncontrado.Text = "Nenhum registro encontrado";
            this.lblEncontrado.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Red;
            this.lblNome.Location = new System.Drawing.Point(178, 185);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(222, 20);
            this.lblNome.TabIndex = 101;
            this.lblNome.Text = "Insira um nome para pesquisa";
            this.lblNome.Visible = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistro.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRegistro.Location = new System.Drawing.Point(879, 175);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(163, 28);
            this.lblRegistro.TabIndex = 100;
            this.lblRegistro.Text = "Registros gerais";
            this.lblRegistro.Visible = false;
            this.lblRegistro.Click += new System.EventHandler(this.LblRegistro_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(435, 145);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 40);
            this.btnPesquisar.TabIndex = 98;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomeProd.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.lblNomeProd.Location = new System.Drawing.Point(45, 145);
            this.lblNomeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(89, 34);
            this.lblNomeProd.TabIndex = 99;
            this.lblNomeProd.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 149);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 26);
            this.txtNome.TabIndex = 97;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnConfirmar.Location = new System.Drawing.Point(474, 612);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 40);
            this.btnConfirmar.TabIndex = 103;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // chkSelecionar
            // 
            this.chkSelecionar.AutoSize = true;
            this.chkSelecionar.Location = new System.Drawing.Point(80, 175);
            this.chkSelecionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSelecionar.Name = "chkSelecionar";
            this.chkSelecionar.Size = new System.Drawing.Size(154, 24);
            this.chkSelecionar.TabIndex = 104;
            this.chkSelecionar.Text = "Selecionar todos";
            this.chkSelecionar.UseVisualStyleBackColor = true;
            this.chkSelecionar.Visible = false;
            this.chkSelecionar.CheckedChanged += new System.EventHandler(this.ChkSelecionar_CheckedChanged);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelecionar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.lblSelecionar.Location = new System.Drawing.Point(648, 48);
            this.lblSelecionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(473, 56);
            this.lblSelecionar.TabIndex = 105;
            this.lblSelecionar.Text = "Selecione os registros de produtos relacionados\r\nao fornecedor que também irão se" +
    "r habilitados.";
            this.lblSelecionar.Visible = false;
            this.lblSelecionar.Click += new System.EventHandler(this.lblSelecionar_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(1095, 643);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(18, 20);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "0";
            this.lblCod.Visible = false;
            // 
            // chkDesabilitados
            // 
            this.chkDesabilitados.AutoSize = true;
            this.chkDesabilitados.Location = new System.Drawing.Point(574, 158);
            this.chkDesabilitados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDesabilitados.Name = "chkDesabilitados";
            this.chkDesabilitados.Size = new System.Drawing.Size(173, 24);
            this.chkDesabilitados.TabIndex = 107;
            this.chkDesabilitados.Text = "Exibir Desabilitados";
            this.chkDesabilitados.UseVisualStyleBackColor = true;
            this.chkDesabilitados.CheckedChanged += new System.EventHandler(this.ChkDesabilitados_CheckedChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(759, 160);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(18, 20);
            this.lblPesquisa.TabIndex = 108;
            this.lblPesquisa.Text = "0";
            this.lblPesquisa.Visible = false;
            // 
            // FrmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 718);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.chkDesabilitados);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.chkSelecionar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblEncontrado);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Produto - Vismo";
            this.Load += new System.EventHandler(this.FrmListarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRegistro;
        public System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Label lblNomeProd;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.DataGridView dgvProduto;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label lblSelecionar;
        public System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPalChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumncodForn;
        public System.Windows.Forms.CheckBox chkSelecionar;
        public System.Windows.Forms.CheckBox chkDesabilitados;
        private System.Windows.Forms.Label lblPesquisa;
    }
}
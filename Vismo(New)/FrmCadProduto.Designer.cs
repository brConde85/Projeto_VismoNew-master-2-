namespace Vismo_New_
{
    partial class FrmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProduto));
            this.cboPalavra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornec = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblRemover = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPalavra
            // 
            this.cboPalavra.FormattingEnabled = true;
            this.cboPalavra.Items.AddRange(new object[] {
            "Lata",
            "Garrafa",
            "Pacote",
            "Enlatado",
            "Unidade",
            "Outro"});
            this.cboPalavra.Location = new System.Drawing.Point(153, 237);
            this.cboPalavra.Name = "cboPalavra";
            this.cboPalavra.Size = new System.Drawing.Size(121, 21);
            this.cboPalavra.TabIndex = 4;
            this.cboPalavra.Enter += new System.EventHandler(this.CboPalavra_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label6.Location = new System.Drawing.Point(26, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Palavra-chave:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(504, 286);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 41);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnEditar.Location = new System.Drawing.Point(413, 286);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 41);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(228, 182);
            this.txtQtd.MaxLength = 5;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(46, 20);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtd_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(181, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(21, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 31);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Cadastro de produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label4.Location = new System.Drawing.Point(368, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 44);
            this.label4.TabIndex = 17;
            this.label4.Text = "Código de\r\nFornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade em estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label2.Location = new System.Drawing.Point(331, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Preço de venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do produto:";
            // 
            // txtFornec
            // 
            this.txtFornec.Location = new System.Drawing.Point(479, 115);
            this.txtFornec.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornec.MaxLength = 4;
            this.txtFornec.Name = "txtFornec";
            this.txtFornec.Size = new System.Drawing.Size(45, 20);
            this.txtFornec.TabIndex = 1;
            this.txtFornec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFornec_KeyPress);
            this.txtFornec.Leave += new System.EventHandler(this.TxtFornec_Leave);
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
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-801, 362);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1926, 28);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Vismo_New_.Properties.Resources.Logo21;
            this.pictureBox3.Location = new System.Drawing.Point(0, 333);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.BackColor = System.Drawing.Color.Transparent;
            this.lblRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemover.Enabled = false;
            this.lblRemover.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRemover.Location = new System.Drawing.Point(24, 299);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(114, 17);
            this.lblRemover.TabIndex = 97;
            this.lblRemover.Text = "Remover produto";
            this.lblRemover.Click += new System.EventHandler(this.LblRemover_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblStatus.Location = new System.Drawing.Point(24, 274);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 17);
            this.lblStatus.TabIndex = 96;
            this.lblStatus.Text = "Desabilitar produto";
            this.lblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistro.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRegistro.Location = new System.Drawing.Point(529, 119);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(88, 16);
            this.lblRegistro.TabIndex = 98;
            this.lblRegistro.Text = "Exibir registro";
            this.lblRegistro.Click += new System.EventHandler(this.LblRegistro_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(470, 184);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(65, 20);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress);
            this.txtPreco.Leave += new System.EventHandler(this.TxtPreco_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValor.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblValor.Location = new System.Drawing.Point(541, 188);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 16);
            this.lblValor.TabIndex = 100;
            this.lblValor.Text = "Alterar valor";
            this.lblValor.Click += new System.EventHandler(this.LblValor_Click);
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.BackColor = System.Drawing.Color.Transparent;
            this.lblAlto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAlto.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.ForeColor = System.Drawing.Color.Red;
            this.lblAlto.Location = new System.Drawing.Point(471, 210);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(87, 16);
            this.lblAlto.TabIndex = 101;
            this.lblAlto.Text = "Valor inválido";
            this.lblAlto.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(413, 286);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 41);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCod.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.Red;
            this.lblCod.Location = new System.Drawing.Point(479, 141);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(141, 16);
            this.lblCod.TabIndex = 102;
            this.lblCod.Text = "Código não encontrado";
            this.lblCod.Visible = false;
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 385);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblRemover);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtFornec);
            this.Controls.Add(this.cboPalavra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto - Vismo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadProduto_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPalavra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCod;
    }
}
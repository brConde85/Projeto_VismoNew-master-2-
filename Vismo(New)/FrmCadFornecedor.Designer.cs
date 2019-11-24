namespace Vismo_New_
{
    partial class FrmCadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFornecedor));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRemover = new System.Windows.Forms.Label();
            this.desabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 20);
            this.txtNome.TabIndex = 10;
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label1.Location = new System.Drawing.Point(23, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(21, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 31);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Cadastro de  fornecedor";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(362, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 41);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-840, 288);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1926, 28);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(462, 226);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 41);
            this.btnVoltar.TabIndex = 70;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Vismo_New_.Properties.Resources.Logo21;
            this.pictureBox3.Location = new System.Drawing.Point(0, 259);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Red;
            this.lblNome.Location = new System.Drawing.Point(190, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 82;
            this.lblNome.Text = "Nome já registrado";
            this.lblNome.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnEditar.Location = new System.Drawing.Point(362, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 41);
            this.btnEditar.TabIndex = 83;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblStatus.Location = new System.Drawing.Point(21, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 17);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.Text = "Desabilitar fornecedor";
            this.lblStatus.Visible = false;
            this.lblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.BackColor = System.Drawing.Color.Transparent;
            this.lblRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemover.Enabled = false;
            this.lblRemover.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRemover.Location = new System.Drawing.Point(21, 205);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(134, 17);
            this.lblRemover.TabIndex = 95;
            this.lblRemover.Text = "Remover fornecedor";
            this.lblRemover.Visible = false;
            this.lblRemover.Click += new System.EventHandler(this.LblRemover_Click);
            // 
            // desabilitarToolStripMenuItem
            // 
            this.desabilitarToolStripMenuItem.Name = "desabilitarToolStripMenuItem";
            this.desabilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desabilitarToolStripMenuItem.Text = "Desabilitar";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // FrmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 311);
            this.Controls.Add(this.lblRemover);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de  Fornecedor - Vismo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.ToolStripMenuItem desabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    }
}
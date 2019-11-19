namespace Vismo_New_
{
    partial class FrmCadFuncionario
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
            this.textSenhaAux = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.texLogin = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textSenhaAux
            // 
            this.textSenhaAux.Location = new System.Drawing.Point(170, 287);
            this.textSenhaAux.Margin = new System.Windows.Forms.Padding(2);
            this.textSenhaAux.Name = "textSenhaAux";
            this.textSenhaAux.Size = new System.Drawing.Size(182, 20);
            this.textSenhaAux.TabIndex = 4;
            this.textSenhaAux.UseSystemPasswordChar = true;
            this.textSenhaAux.Leave += new System.EventHandler(this.textSenhaAux_Leave);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(170, 232);
            this.textSenha.Margin = new System.Windows.Forms.Padding(2);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(182, 20);
            this.textSenha.TabIndex = 3;
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // texLogin
            // 
            this.texLogin.Location = new System.Drawing.Point(170, 178);
            this.texLogin.Margin = new System.Windows.Forms.Padding(2);
            this.texLogin.Name = "texLogin";
            this.texLogin.Size = new System.Drawing.Size(182, 20);
            this.texLogin.TabIndex = 2;
            this.texLogin.Leave += new System.EventHandler(this.texLogin_Leave);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(72, 122);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(280, 20);
            this.textNome.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnOk.Location = new System.Drawing.Point(446, 298);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 41);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Salvar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label6.Location = new System.Drawing.Point(26, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "Confirmar Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label5.Location = new System.Drawing.Point(105, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label2.Location = new System.Drawing.Point(10, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label3.Location = new System.Drawing.Point(110, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Login:";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label4.Location = new System.Drawing.Point(387, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cpf:";
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
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Formulário de cadastramento de funcionário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.label8.Location = new System.Drawing.Point(387, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 22);
            this.label8.TabIndex = 59;
            this.label8.Text = "Cargo na empresa:";
            // 
            // comboTipo
            // 
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Gerente",
            "Operador de Caixa"});
            this.comboTipo.Location = new System.Drawing.Point(391, 215);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(120, 24);
            this.comboTipo.TabIndex = 5;
            this.comboTipo.Enter += new System.EventHandler(this.ComboTipo_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox4.Location = new System.Drawing.Point(-19, 809);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1659, 50);
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
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
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // txtCpf
            // 
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Location = new System.Drawing.Point(434, 124);
            this.txtCpf.Mask = "999999999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(124, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(540, 298);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 41);
            this.btnVoltar.TabIndex = 71;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
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
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.Red;
            this.lblCpf.Location = new System.Drawing.Point(492, 147);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(66, 13);
            this.lblCpf.TabIndex = 80;
            this.lblCpf.Text = "CPF inválido";
            this.lblCpf.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Red;
            this.lblSenha.Location = new System.Drawing.Point(232, 309);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(124, 13);
            this.lblSenha.TabIndex = 81;
            this.lblSenha.Text = "Senhas não confirmadas";
            this.lblSenha.Visible = false;
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.ForeColor = System.Drawing.Color.Red;
            this.lblLogin1.Location = new System.Drawing.Point(286, 200);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(70, 13);
            this.lblLogin1.TabIndex = 82;
            this.lblLogin1.Text = "Login em uso";
            this.lblLogin1.Visible = false;
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.Color.Red;
            this.lblLogin2.Location = new System.Drawing.Point(284, 200);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(72, 13);
            this.lblLogin2.TabIndex = 83;
            this.lblLogin2.Text = "Login inválido";
            this.lblLogin2.Visible = false;
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 385);
            this.Controls.Add(this.lblLogin2);
            this.Controls.Add(this.lblLogin1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSenhaAux);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.texLogin);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário - Vismo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadFuncionario_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSenhaAux;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox texLogin;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Label lblLogin2;
    }
}
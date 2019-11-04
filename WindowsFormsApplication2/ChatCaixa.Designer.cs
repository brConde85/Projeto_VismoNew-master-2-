namespace WindowsFormsApplication2
{
    partial class ChatCaixa
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbCaixa = new System.Windows.Forms.RichTextBox();
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(278, 303);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(51, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // rtbCaixa
            // 
            this.rtbCaixa.Enabled = false;
            this.rtbCaixa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rtbCaixa.Location = new System.Drawing.Point(5, 124);
            this.rtbCaixa.Name = "rtbCaixa";
            this.rtbCaixa.Size = new System.Drawing.Size(313, 159);
            this.rtbCaixa.TabIndex = 8;
            this.rtbCaixa.Text = "";
            // 
            // txtCaixa
            // 
            this.txtCaixa.Location = new System.Drawing.Point(5, 305);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.Size = new System.Drawing.Size(267, 20);
            this.txtCaixa.TabIndex = 7;
            // 
            // ChatCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rtbCaixa);
            this.Controls.Add(this.txtCaixa);
            this.Name = "ChatCaixa";
            this.Text = "ChatCaixa";
            this.Load += new System.EventHandler(this.ChatCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtbCaixa;
        private System.Windows.Forms.TextBox txtCaixa;
    }
}
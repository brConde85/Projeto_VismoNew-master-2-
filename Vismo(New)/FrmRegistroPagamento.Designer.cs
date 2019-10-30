namespace Vismo_New_
{
    partial class FrmRegistroPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgPagamento = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblPen = new System.Windows.Forms.Label();
            this.lblAtra = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro de Pagamentos";
            // 
            // dgPagamento
            // 
            this.dgPagamento.AllowUserToAddRows = false;
            this.dgPagamento.AllowUserToDeleteRows = false;
            this.dgPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColumnNome,
            this.Descrição,
            this.Prazo,
            this.Situação,
            this.Fornecedor});
            this.dgPagamento.Location = new System.Drawing.Point(28, 68);
            this.dgPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgPagamento.Name = "dgPagamento";
            this.dgPagamento.ReadOnly = true;
            this.dgPagamento.RowHeadersWidth = 62;
            this.dgPagamento.RowTemplate.Height = 28;
            this.dgPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagamento.Size = new System.Drawing.Size(643, 229);
            this.dgPagamento.TabIndex = 10;
            this.dgPagamento.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 250);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "codigo";
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
            this.ColumnNome.DataPropertyName = "valor";
            this.ColumnNome.HeaderText = "Valor";
            this.ColumnNome.MinimumWidth = 8;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 120;
            // 
            // Prazo
            // 
            this.Prazo.DataPropertyName = "validade";
            this.Prazo.HeaderText = "Prazo";
            this.Prazo.Name = "Prazo";
            this.Prazo.ReadOnly = true;
            // 
            // Situação
            // 
            this.Situação.DataPropertyName = "situacao";
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "codFornecedor";
            this.Fornecedor.HeaderText = "ID Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(309, 321);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 27);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.LightGreen;
            this.lblRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRes.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(255, 80);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(80, 24);
            this.lblRes.TabIndex = 14;
            this.lblRes.Text = "Realizados";
            this.lblRes.Click += new System.EventHandler(this.LblRes_Click);
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.BackColor = System.Drawing.Color.Khaki;
            this.lblPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPen.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPen.Location = new System.Drawing.Point(351, 80);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(78, 24);
            this.lblPen.TabIndex = 15;
            this.lblPen.Text = "Pendentes";
            this.lblPen.Click += new System.EventHandler(this.LblPen_Click);
            // 
            // lblAtra
            // 
            this.lblAtra.AutoSize = true;
            this.lblAtra.BackColor = System.Drawing.Color.LightCoral;
            this.lblAtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtra.Location = new System.Drawing.Point(446, 80);
            this.lblAtra.Name = "lblAtra";
            this.lblAtra.Size = new System.Drawing.Size(76, 24);
            this.lblAtra.TabIndex = 16;
            this.lblAtra.Text = "Atrasados";
            this.lblAtra.Click += new System.EventHandler(this.LblAtra_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(194, 321);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 27);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            // 
            // FrmRegistroPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblAtra);
            this.Controls.Add(this.lblPen);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRegistroPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pagamentos - Vismo";
            this.Load += new System.EventHandler(this.FrmRegistroPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.Label lblAtra;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
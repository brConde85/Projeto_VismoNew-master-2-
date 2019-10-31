namespace Vismo_New_
{
    partial class FrmMaisVendidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgVendidos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendidos)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(301, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mais e Menos Vendidos";
            // 
            // dgVendidos
            // 
            this.dgVendidos.AllowUserToAddRows = false;
            this.dgVendidos.AllowUserToDeleteRows = false;
            this.dgVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColumnNome,
            this.Qtd,
            this.Datas});
            this.dgVendidos.Location = new System.Drawing.Point(28, 68);
            this.dgVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgVendidos.Name = "dgVendidos";
            this.dgVendidos.ReadOnly = true;
            this.dgVendidos.RowHeadersWidth = 62;
            this.dgVendidos.RowTemplate.Height = 28;
            this.dgVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendidos.Size = new System.Drawing.Size(643, 229);
            this.dgVendidos.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 250);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "codigoProduto";
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
            this.ColumnNome.Width = 200;
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "quantidadeVendida";
            this.Qtd.HeaderText = "Quantidade Vendida";
            this.Qtd.MinimumWidth = 8;
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 80;
            // 
            // Datas
            // 
            this.Datas.DataPropertyName = "datas";
            dataGridViewCellStyle2.NullValue = "99/99/9999";
            this.Datas.DefaultCellStyle = dataGridViewCellStyle2;
            this.Datas.HeaderText = "Data";
            this.Datas.MinimumWidth = 8;
            this.Datas.Name = "Datas";
            this.Datas.ReadOnly = true;
            this.Datas.Width = 150;
            // 
            // FrmMaisVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.dgVendidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMaisVendidos";
            this.Text = "FrmMaisVendidos";
            this.Load += new System.EventHandler(this.FrmMaisVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVendidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datas;
    }
}
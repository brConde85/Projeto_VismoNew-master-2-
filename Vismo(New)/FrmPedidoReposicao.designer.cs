namespace Vismo_New_
{
    partial class FrmPedidoReposicao
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
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pchave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(282, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pedidos de Reposição";
            // 
            // dgPedido
            // 
            this.dgPedido.AllowUserToAddRows = false;
            this.dgPedido.AllowUserToDeleteRows = false;
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColumnNome,
            this.Preco,
            this.QtdEstoque,
            this.Pchave,
            this.Fornecedor});
            this.dgPedido.Location = new System.Drawing.Point(28, 68);
            this.dgPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.ReadOnly = true;
            this.dgPedido.RowHeadersWidth = 62;
            this.dgPedido.RowTemplate.Height = 28;
            this.dgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedido.Size = new System.Drawing.Size(643, 229);
            this.dgPedido.TabIndex = 10;
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
            // 
            // id
            // 
            this.id.DataPropertyName = "codigo";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 8;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // QtdEstoque
            // 
            this.QtdEstoque.DataPropertyName = "qtdEstoque";
            this.QtdEstoque.HeaderText = "Qtd Estoque";
            this.QtdEstoque.Name = "QtdEstoque";
            this.QtdEstoque.ReadOnly = true;
            // 
            // Pchave
            // 
            this.Pchave.DataPropertyName = "pchave";
            this.Pchave.HeaderText = "Palavra Chave";
            this.Pchave.Name = "Pchave";
            this.Pchave.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "nomeFornec";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // FrmPedidoReposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.dgPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPedidoReposicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedidoReposicao";
            this.Load += new System.EventHandler(this.FrmPedidoReposicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pchave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
    }
}
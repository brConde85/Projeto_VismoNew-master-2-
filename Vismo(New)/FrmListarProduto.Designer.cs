﻿namespace Vismo_New_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumncodForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPalChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColumnNome,
            this.ColumnPreco,
            this.ColumnQtdEstoque,
            this.ColumncodForn,
            this.ColumnPalChave});
            this.dataGridView1.Location = new System.Drawing.Point(28, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.HeaderText = "Código";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 8;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 140;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ColumnPreco.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.MinimumWidth = 8;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.Width = 80;
            // 
            // ColumnQtdEstoque
            // 
            this.ColumnQtdEstoque.DataPropertyName = "QtdEstoque";
            this.ColumnQtdEstoque.HeaderText = "Quantidade em Estoque";
            this.ColumnQtdEstoque.MinimumWidth = 8;
            this.ColumnQtdEstoque.Name = "ColumnQtdEstoque";
            this.ColumnQtdEstoque.Width = 80;
            // 
            // ColumncodForn
            // 
            this.ColumncodForn.DataPropertyName = "codFornecedor";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.ColumncodForn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumncodForn.HeaderText = "Código Fornecedor";
            this.ColumncodForn.MinimumWidth = 8;
            this.ColumncodForn.Name = "ColumncodForn";
            this.ColumncodForn.Width = 80;
            // 
            // ColumnPalChave
            // 
            this.ColumnPalChave.DataPropertyName = "Pchave";
            this.ColumnPalChave.HeaderText = "Palavra Chave";
            this.ColumnPalChave.MinimumWidth = 8;
            this.ColumnPalChave.Name = "ColumnPalChave";
            this.ColumnPalChave.Width = 150;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(243, 322);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 27);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(377, 322);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(101, 27);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Apagar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 250);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Produto - Vismo";
            this.Load += new System.EventHandler(this.FrmListarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumncodForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPalChave;
    }
}
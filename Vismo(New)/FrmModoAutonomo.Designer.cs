namespace Vismo_New_
{
    partial class FrmModoAutonomo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graficoCancelamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.graficoVenda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCancelamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "Visualizar Graficos";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.Label2_DoubleClick);
            this.label2.MouseLeave += new System.EventHandler(this.Label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autônomo";
            this.label1.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // graficoCancelamento
            // 
            chartArea11.Name = "ChartArea1";
            this.graficoCancelamento.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.graficoCancelamento.Legends.Add(legend11);
            this.graficoCancelamento.Location = new System.Drawing.Point(20, 581);
            this.graficoCancelamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graficoCancelamento.Name = "graficoCancelamento";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.graficoCancelamento.Series.Add(series11);
            this.graficoCancelamento.Size = new System.Drawing.Size(441, 195);
            this.graficoCancelamento.TabIndex = 11;
            this.graficoCancelamento.Text = "Cancelamentos";
            title11.Name = "Title2";
            title11.Text = "Cancelamentos";
            this.graficoCancelamento.Titles.Add(title11);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Olá";
            // 
            // graficoVenda
            // 
            chartArea12.Name = "ChartArea1";
            this.graficoVenda.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            legend12.Title = "Produtos";
            this.graficoVenda.Legends.Add(legend12);
            this.graficoVenda.Location = new System.Drawing.Point(20, 329);
            this.graficoVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graficoVenda.Name = "graficoVenda";
            this.graficoVenda.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.graficoVenda.Series.Add(series12);
            this.graficoVenda.Size = new System.Drawing.Size(450, 217);
            this.graficoVenda.TabIndex = 13;
            this.graficoVenda.Text = "Vendas";
            title12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title12.Name = "Title1";
            title12.Text = "Vendas";
            this.graficoVenda.Titles.Add(title12);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 817);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox2.BackgroundImage = global::Vismo_New_.Properties.Resources.thumb2_blue_texture_background_blue_paint_texture_painted_wall_stone_texture;
            this.pictureBox2.Image = global::Vismo_New_.Properties.Resources.Seta_direita_azul_200x200px1;
            this.pictureBox2.Location = new System.Drawing.Point(11, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vismo_New_.Properties.Resources.thumb2_blue_texture_background_blue_paint_texture_painted_wall_stone_texture;
            this.pictureBox1.Location = new System.Drawing.Point(-34, -61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 215);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmModoAutonomo
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 920);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.graficoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.graficoCancelamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmModoAutonomo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo Autonomo - Vismo";
            this.Load += new System.EventHandler(this.FrmModoAutonomo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoCancelamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCancelamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVenda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}
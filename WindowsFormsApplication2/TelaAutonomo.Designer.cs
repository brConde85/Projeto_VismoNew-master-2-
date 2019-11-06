namespace WindowsFormsApplication2
{
    partial class TelaAutonomo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graficoVenda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.graficoCancelamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCancelamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autônomo";
            this.label1.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visualizar Graficos";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.Label2_DoubleClick);
            this.label2.MouseLeave += new System.EventHandler(this.Label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            // 
            // graficoVenda
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoVenda.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            legend3.Title = "Produtos";
            this.graficoVenda.Legends.Add(legend3);
            this.graficoVenda.Location = new System.Drawing.Point(12, 273);
            this.graficoVenda.Name = "graficoVenda";
            this.graficoVenda.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficoVenda.Series.Add(series3);
            this.graficoVenda.Size = new System.Drawing.Size(300, 141);
            this.graficoVenda.TabIndex = 3;
            this.graficoVenda.Text = "Vendas";
            title3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title3.Name = "Title1";
            title3.Text = "Vendas";
            this.graficoVenda.Titles.Add(title3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kk";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // graficoCancelamento
            // 
            chartArea4.Name = "ChartArea1";
            this.graficoCancelamento.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graficoCancelamento.Legends.Add(legend4);
            this.graficoCancelamento.Location = new System.Drawing.Point(18, 437);
            this.graficoCancelamento.Name = "graficoCancelamento";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.graficoCancelamento.Series.Add(series4);
            this.graficoCancelamento.Size = new System.Drawing.Size(294, 127);
            this.graficoCancelamento.TabIndex = 5;
            this.graficoCancelamento.Text = "Cancelamentos";
            title4.Name = "Title2";
            title4.Text = "Cancelamentos";
            this.graficoCancelamento.Titles.Add(title4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.thumb2_blue_texture_background_blue_paint_texture_painted_wall_stone_texture;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.Seta_direita_azul_200x200px1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.thumb2_blue_texture_background_blue_paint_texture_painted_wall_stone_texture;
            this.pictureBox1.Location = new System.Drawing.Point(-18, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // TelaAutonomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 598);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.graficoCancelamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graficoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaAutonomo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo Autonomo - Vismo";
            this.Load += new System.EventHandler(this.TelaAutonomo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCancelamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCancelamento;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
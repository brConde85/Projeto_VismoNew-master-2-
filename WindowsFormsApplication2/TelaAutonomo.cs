using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class TelaAutonomo : Form
    {


        bool x = false;
        bool y = false;

        public string fodase = "fodase";
        public TelaAutonomo()
        {
            InitializeComponent();
        }
       

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Autônomo";
            label1.Visible = true;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            label1.Text = "Neste modo o computador ira usar \n como base suas descisões para \n auxiliar o caixa e administrar a empresa.";
            label1.Visible = true;
           

        }

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            graficoVenda.Visible = true;
            graficoCancelamento.Visible = true;
            label3.Visible = true;
            string comprimento;
            int hora = Convert.ToInt32(DateTime.Now.Hour);
           
            if (hora < 12)
            {
                comprimento = "Bom Dia!";
                if (hora < 18)
                {
                    comprimento = "Boa Noite!";

                }
            }
            else
            {
                comprimento = "Boa Tarde";
            }
            label3.Refresh();
            label3.Text = comprimento + " Estas são suas estatiscas de hoje.";


        }
        private void Label2_Click(object sender, EventArgs e)
        {
            graficoVenda.Enabled = true;
            graficoCancelamento.Enabled = true;
           

        }
        private void Label2_DoubleClick(object sender, EventArgs e)
        {
            graficoVenda.Enabled = false;
            graficoCancelamento.Enabled = false;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            if(graficoVenda.Enabled == false)
            {
                graficoCancelamento.Visible = false;
                graficoVenda.Visible = false;
                label3.Visible = false;
               


            }

        }

        private void TelaAutonomo_Load(object sender, EventArgs e)
        {
         
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(label2, "Para mater o grafico aberto basta dar um click, e para voltar a exibir normalmente basta dar 2 clicks :)");


            string[]produtos = {
                "coca" };
            graficoCancelamento.Visible = false;
            graficoVenda.Visible = false;
            label3.Visible = false;
            graficoVenda.Refresh();
            int[] Percentual = { 20, 80, 75, 50, 78, 159, 10, 69, 110, 16, 191, 112 };
            for (int i = 0; i < produtos.Length; i++)
            {
                Series series = this.graficoVenda.Series.Add(produtos[i]);
                series.Points.Add(Percentual[i]);
            }

            
            int[] PercentualCancelamento = { 20, 80, 75, 50, 78, 159, 10, 69, 110, 16, 191, 112 };
            for (int i = 0; i < produtos.Length; i++)
            {
                Series series = this.graficoCancelamento.Series.Add(produtos[i]);
                series.Points.Add(PercentualCancelamento[i]);
            }
            graficoCancelamento.Refresh();
            









        }




        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            TelaAutonomo telaAutonomo = new TelaAutonomo();
            TelaDisponivel telaDisponivel = new TelaDisponivel();
            telaDisponivel.Show();
            this.Show();
            this.Hide();
        }
    }
}


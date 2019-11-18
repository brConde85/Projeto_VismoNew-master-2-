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
using Control;


namespace Vismo_New_
{
    public partial class FrmModoAutonomo : Form
    {
        public FrmModoAutonomo(string login)
        {
            InitializeComponent();

            txtLogin.Text = login;
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
            label1.Text = "Neste modo o computador ira usar como base suas \n descisões para auxiliar o caixa e administrar a empresa.";
            label1.Visible = true;
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
            if (graficoVenda.Enabled == false)
            {
                graficoCancelamento.Visible = false;
                graficoVenda.Visible = false;
                label3.Visible = false;
            }
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

        private void FrmModoAutonomo_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(label2, "Para mater o grafico aberto basta dar um click, e para voltar a exibir normalmente basta dar 2 clicks :)");


            string[] produtos = {
                "" };
            graficoCancelamento.Visible = false;
            graficoVenda.Visible = false;
            label3.Visible = false;
            graficoVenda.Refresh();
            int[] Percentual = { 20, 80, 75, 50, 78, 159, 10, 69, 110, 16, 191, 112 };
            for (int i = 0; i < produtos.Length; i++)
            {
                Series series = this.graficoVenda.Series.Add(produtos[i]);
                series.Points.Add(Percentual[i]);
                series.Points.Add(Percentual[i]);
                series.Points.Add(Percentual[i]);
                series.Points.Add(Percentual[i]);
                series.Points.Add(Percentual[i]);
                series.Points.Add(Percentual[i]);
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel telaDisponivel = new FrmModoDisponivel(txtLogin.Text);
            telaDisponivel.Show();
            this.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Login = txtLogin.Text;

            if (funcionario.AlteraStatus(3) == 1)
            {
                funcionario.PegaLogin();

                //Exibe a mensagem de confirmação e fecha a tela de autenticação
                MessageBox.Show("Seu status foi alterado com sucesso.",
                    "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a tela de gerente com o novo status
                Application.OpenForms["FrmLogGerente"].Close();

                FrmLogGerente tela = new FrmLogGerente(funcionario.Login, funcionario.Senha);
                tela.Show();
            }
            else
            {
                MessageBox.Show("Erro ao alterar status do Usuário", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}

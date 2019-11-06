using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class TelaDisponivel : Form
    {
        public TelaAutonomo telaAutonomo = new TelaAutonomo();


        TelaAusente telaAusente = new TelaAusente();
        public TelaDisponivel()
        {
            InitializeComponent();
        }

        public void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Neste modo você ira escolher\n todas as ações a serem tomadas.";
            label1.Visible = true;
        }

        public void label1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Disponível";
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDisponivel telaDisponivel = new TelaDisponivel();
            this.telaAusente.Show();
            this.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.telaAutonomo.Show();
            this.Show();
            this.Hide();
        }

    }
}


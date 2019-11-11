using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo_New_
{
    public partial class FrmModoDisponivel : Form
    {
        
        public FrmModoAusente telaAusente = new FrmModoAusente();
        public FrmModoAutonomo telaAutonomo = new FrmModoAutonomo();
        public FrmModoDisponivel()
        {
            InitializeComponent();
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Neste modo você ira escolher\n todas as ações a serem tomadas.";
            label1.Visible = true;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Disponível";
            label1.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.telaAutonomo.Show();
            this.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel telaDisponivel = new FrmModoDisponivel();
            this.telaAusente.Show();
            this.Show();
            this.Hide();
        }
    }
}

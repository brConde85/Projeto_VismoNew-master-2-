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
    public partial class FrmModoAusente : Form
    {
        public FrmModoAusente()
        {
            InitializeComponent();
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Ausente";
            label1.Visible = true;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Neste modo você ira escolher as ações \n a serem tomadas na sua ausência.";
            label1.Visible = true;
        }

        private void BtnProsseguir_Click(object sender, EventArgs e)
        {
            FrmModoAusente2 frmModoAusente2 = new FrmModoAusente2();
            frmModoAusente2.Show();
            this.Hide();


            if (radioButton1.Checked == true)
            {

            }
            else
            {
                if (radioButton2.Checked == true)
                {

                }
                else
                {

                    if (radioButton3.Checked == true)
                    {

                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {

                        }




                    }

                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            FrmModoDisponivel telaDisponivel = new FrmModoDisponivel();
            telaDisponivel.Show();
            this.Show();
            this.Hide();
        }
    }
}

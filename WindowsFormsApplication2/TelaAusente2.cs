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
    public partial class TelaAusente2 : Form
    {
        public TelaAusente2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaAusente2_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            TelaAusente telaAusente = new TelaAusente();
            TelaDisponivel telaDisponivel = new TelaDisponivel();
            telaAusente.Show();
            this.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

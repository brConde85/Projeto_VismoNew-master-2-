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
    public partial class FrmModoAusente2 : Form
    {
        public FrmModoAusente2()
        {
            InitializeComponent();
        }

        private void FrmModoAusente2_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FrmModoAusente telaAusente = new FrmModoAusente();
            FrmModoDisponivel telaDisponivel = new FrmModoDisponivel();
            telaAusente.Show();
            this.Show();
            this.Hide();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAutenGerente tela = new FrmAutenGerente();
            tela.Show();

            this.Close();
        }
    }
}

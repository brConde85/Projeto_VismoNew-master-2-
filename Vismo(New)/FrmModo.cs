using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vismo_New_
{
    public partial class FrmModo : Form
    {
        public FrmModo(string login)
        {
            InitializeComponent();

            txtLogin.Text = login;
        }

        //abre formulário para Modo Disponível
        private void LblDis_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }

        private void Pcb1Dis_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }

        private void Pcb2Dis_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }


        //abre formulário para Modo Autônomo
        private void LblAut_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void Pcb1Aut_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void Pcb2Aut_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }


        //abre formulário para Modo Ausente
        private void LblAus_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void Pcb1Aus_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void Pcb2Aus_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente(txtLogin.Text);
            tela.Show();

            Close();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }
    }
}

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
    public partial class FrmAutenGerente : Form
    {
        public FrmAutenGerente()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Acessar(txtLogin.Text, txtSenha.Text);
            if (funcionario.ConfirmCadast)
            {
                MessageBox.Show("Aturização realizada com sucesso!", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (funcionario.Tipo == "Gerente")
                {
                    funcionario.Login = txtLogin.Text;
                    funcionario.Senha = txtSenha.Text;

                    if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() == 1)
                    {
                        if (funcionario.AlteraStatus(1) == 1)
                        {
                            Application.OpenForms["FrmModoDisponivel"].Close();
                        }                       
                    }


                    if (Application.OpenForms.OfType<FrmModoAusente2>().Count() == 1)
                    {
                        if (funcionario.AlteraStatus(2) == 1)
                        {
                            Application.OpenForms["FrmModoAusente2"].Close();
                        }
                    }


                    if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() == 1)
                    {
                        if (funcionario.AlteraStatus(3) == 1)
                        {
                            Application.OpenForms["FrmModoAutonomo"].Close();
                        }
                    }

                    MessageBox.Show("Seu status foi alterado com sucesso.","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();

                    Application.OpenForms["FrmLogGerente"].Close();

                    FrmLogGerente tela = new FrmLogGerente(funcionario.Login, funcionario.Senha);
                    tela.Show();
                }
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique login e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

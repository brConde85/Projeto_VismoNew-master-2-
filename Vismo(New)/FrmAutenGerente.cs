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

        //Ação para validar login e senha de gerente
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

                    //Fecha as telas dos forms de gerente que estiverem abertas 
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

                    // Fecha a tela de altenticação
                    Close();
                    
                    // Atualiza a tela de gerente com o novo status
                    Application.OpenForms["FrmLogGerente"].Close();

                    FrmLogGerente tela = new FrmLogGerente(funcionario.Login, funcionario.Senha);
                    tela.Show();
                }
            }
            // Caso o login e senha estejam errados o usuario será informado
            else
            {
                MessageBox.Show("Login não encontrado, verifique login e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

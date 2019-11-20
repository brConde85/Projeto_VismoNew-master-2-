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

            //atribuição dos campos de login e senha aos atributos da classe Funcionario
            funcionario.Login = txtLogin.Text;
            funcionario.Senha = txtSenha.Text;

            //verifica se login e senha são válidos
            if (funcionario.VerificarLogin() == true)
            {
                /*Fecha as telas de Modos do Gerente abertas e atualiza o status do Gerente.
                  O método "AlteraStatus()" recebe como parâmetro um número inteiro que representa
                  o atual status do gerente, sendo: 1 - Disponível; 2 - Ausente; 3 - Autônomo*/
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

                //Exibe a mensagem de confirmação e fecha a tela de autenticação
                MessageBox.Show("Seu status foi alterado com sucesso.",
                    "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a tela de gerente com o novo status
                Application.OpenForms["FrmLogGerente"].Close();

                FrmLogGerente tela = new FrmLogGerente(funcionario.Login, funcionario.Senha);
                tela.Show();

                Close();
            }
            else
            {
                // Caso o login e senha estejam inválidos
                MessageBox.Show("Login não encontrado, verifique login e senha!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
        }

        // Ação para abrir a tela de cadastro
        private void LblCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            if (funcionario.AchaGerente() == 0)
            {
                FrmCadFuncionario tela = new FrmCadFuncionario();
                tela.Show();
            }
            else
            {
                MessageBox.Show("Notamos que já existe uma ou mais contas registradas,\n" +
                    "para continuar você deve antes informar Login e Senha de um conta como Gerente.\n\n" +
                    "Esse procedimento pode ser evitado logando no sistema como Gerente e seguir:\n" +
                    "(Cadastrar --> Funcionário)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmAuten tela = new FrmAuten();
                tela.Show();
            }
        }


        // Ação para validação de Login
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            //atribuição dos campos de login e senha aos atributos da classe Funcionario
            funcionario.Login = txtLogin.Text;
            funcionario.Senha = txtSenha.Text;

            try
            {
                //chamada do método qye verifica login e senha informados
                if (funcionario.VerificarLogin() == true)
                {
                    //compara o tipo de conta que utilizará o sistema
                    if (funcionario.Tipo == "Gerente")
                    {
                        //caso for um gerente
                        FrmLogGerente frmGer = new FrmLogGerente(txtLogin.Text, txtSenha.Text);
                        frmGer.Show();
                        Hide();
                    }
                    else
                    {
                        //caso for um operador de caixa
                        FrmLogOpCaixa frmCx = new FrmLogOpCaixa();
                        frmCx.Show();
                        Hide();
                    }

                    //limpa os campos de login e senha
                    txtLogin.Clear();
                    txtSenha.Clear();

                    txtLogin.Focus();

                    lblLogin.Visible = false;
                }
                else
                {
                    //caso login ou senha inválidos
                    lblLogin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Ação para validação de Login por caixa de texto
        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnEntrar_Click(sender, e);
            }
        }


        // Ação para exibir ou ocultar senha
        private void PcbSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }


        // Design da label "Cadastrar-se"
        private void LblCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrar.ForeColor = Color.SkyBlue;
        }

        private void LblCadastrar_MouseLeave(object sender, EventArgs e)
        {
            lblCadastrar.ForeColor = Color.SteelBlue;
        }
    }
}

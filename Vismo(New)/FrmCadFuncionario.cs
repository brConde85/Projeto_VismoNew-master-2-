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
    public partial class FrmCadFuncionario : Form
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        // Ação para cadastrar um funcionário
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //compara se todos os campos foram preenchidos corretamente
            if ((!textNome.Text.Equals("")) &&
                    (!txtCpf.Text.Equals("")) &&
                    (!texLogin.Text.Equals("")) &&
                    (!textSenha.Text.Equals("")) &&
                    (!textSenhaAux.Text.Equals("")) &&
                    (!comboTipo.Text.Equals("")) &&
                    lblCpf.Visible == false && lblLogin1.Visible == false && lblLogin2.Visible == false == lblSenha.Visible == false)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Senha = textSenha.Text;
                funcionario.SenhaAux = textSenhaAux.Text;

                //compara se os campos de senha e confirmação de senha estão iguais
                if (funcionario.Senha == funcionario.SenhaAux)
                {
                    try
                    {
                        //atribuição dos campos do formulário nos atributos da classe Funcionario
                        funcionario.Login = texLogin.Text;
                        funcionario.Senha = textSenha.Text;
                        funcionario.Nome = textNome.Text;
                        funcionario.Cpf = txtCpf.Text;
                        funcionario.Tipo = comboTipo.Text;

                        /*checa se a conta criada é do tipo "Gerente" ou "Operador de Caixa";
                          a primeira posição do ComboBox do formulário (0) é referente a Gerente
                          e a segunda (1) a Operador de Caixa*/

                        /*uma conta Gerente recebe o status 1, que representa um status "Disponível",
                          uma conta Operador de Caixa não têm status e recebe valor 0*/
                        if (comboTipo.SelectedIndex == 0)
                        {
                            funcionario.Status = "1";
                        }
                        else
                        {
                            funcionario.Status = "0";
                        }

                        if (funcionario.Inserir() == 1)
                        {
                            MessageBox.Show(String.Format("Funcionário: {0} inserido com sucesso.", textNome.Text));

                            //limpa o formulário
                            textNome.Clear();
                            txtCpf.Clear();
                            texLogin.Clear();
                            textSenha.Clear();
                            textSenhaAux.Clear();
                            comboTipo.Text = "";

                            textNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar cadastro.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    //caso os campos de senha e confirmação de senha estiverem diferentes
                    MessageBox.Show("Senhas cadastradas não conferem, favor conferir a senha digitada.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos coretamente antes de continuar.");
            }
        }

        //fecha o formulário
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //compara se CPF inserido é válido
        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (!txtCpf.Text.Equals(""))
            {
                double aux = Convert.ToDouble(txtCpf.Text);
                string cpf = Convert.ToString(aux);

                if (cpf.Length == 11)
                {
                    lblCpf.Visible = false;
                }
                else
                {
                    lblCpf.Visible = true;
                }
            } 
        }

        //compara se a senha e confiramção estão iguais
        private void textSenhaAux_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == textSenhaAux.Text)
            {
                lblSenha.Visible = false;
            }
            else
            {
                lblSenha.Visible = true;
            }
        }

        //compara se login inserido é válido
        private void texLogin_Leave(object sender, EventArgs e)
        {
            string login = new string(texLogin.Text.Reverse().ToArray());

            for (int i = 0; i < texLogin.Text.Length; i++)
            {
                if (texLogin.Text.ElementAt(i) == '@')
                {
                    if (login.Substring(0, 4) == "moc.")
                    {
                        i = texLogin.Text.Length;

                        lblLogin2.Visible = false;

                        Funcionario funcionario = new Funcionario();

                        funcionario.Login = texLogin.Text;

                        if (funcionario.PegaLogin() == 0)
                        {
                            lblLogin1.Visible = false;
                        }
                        else
                        {
                            lblLogin1.Visible = true;
                        }
                    }
                    else
                    {
                        lblLogin2.Visible = true;
                    }
                }
                else
                {
                    lblLogin2.Visible = true;
                }
            }
        }
    }
}

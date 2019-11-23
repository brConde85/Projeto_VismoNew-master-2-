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
        Funcionario funcionario;

        public FrmCadFuncionario()
        {
            InitializeComponent();

            funcionario = new Funcionario();
        }

        //procura por Gerentes cadastrados
        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            if (funcionario.AchaGerente() == 0)
            {
                cboTipo.Text = "Gerente";
                cboTipo.Enabled = false;
            }
        }


        //tratamento de interface
        private void CboTipo_Enter(object sender, EventArgs e)
        {
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //compara se CPF inserido é válido
        private void TxtCpf_Leave(object sender, EventArgs e)
        {
            if (!txtCpf.Text.Equals(""))
            {
                char[] cpf = new char[11];

                int var = 0;

                for (int i = 0; i < txtCpf.Text.Length; i++)
                {
                    cpf[i] = txtCpf.Text.ElementAt(i);

                    for (int num = 0; num <= 9; num++)
                    {
                        if (Convert.ToString(cpf[i]) == Convert.ToString(num))
                        {
                            var += 1;
                        }
                    }
                }

                if (var == 11)
                {
                    lblCpf.Visible = false;

                    funcionario.Cpf = txtCpf.Text;

                    if (funcionario.ChecaCpf() == 0)
                    {
                        lblCpfUso.Visible = false;
                    }
                    else
                    {
                        lblCpfUso.Visible = true;
                    }
                }
                else
                {
                    lblCpfUso.Visible = false;
                    lblCpf.Visible = true;
                }
            }
        }

        //compara se a senha e confiramção estão iguais
        private void TxtSenhaAux_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtSenhaAux.Text)
            {
                lblSenha.Visible = false;
            }
            else
            {
                lblSenha.Visible = true;
            }
        }

        //compara se login inserido é válido
        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            string login = new string(txtLogin.Text.Reverse().ToArray());

            for (int i = 0; i < txtLogin.Text.Length; i++)
            {
                if (txtLogin.Text.ElementAt(i) == '@')
                {
                    if (login.Substring(0, 4) == "moc.")
                    {
                        i = txtLogin.Text.Length;

                        lblLogin2.Visible = false;

                        funcionario.Login = txtLogin.Text;

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


        //ação para cadastrar um funcionário
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //compara se todos os campos foram preenchidos corretamente
            if ((!txtNome.Text.Equals("")) &&
                    (!txtCpf.Text.Equals("")) &&
                    (!txtLogin.Text.Equals("")) &&
                    (!txtSenha.Text.Equals("")) &&
                    (!cboTipo.Text.Equals("")) &&
                    lblCpf.Visible == false && lblLogin1.Visible == false &&
                    lblLogin2.Visible == false == lblSenha.Visible == false && lblCpfUso.Visible == false)
            {
                try
                {
                    //atribuição dos campos do formulário nos atributos da classe Funcionario
                    funcionario.Login = txtLogin.Text;
                    funcionario.Senha = txtSenha.Text;
                    funcionario.Nome = txtNome.Text;
                    funcionario.Cpf = txtCpf.Text;
                    funcionario.Tipo = cboTipo.Text;

                    /*checa se a conta criada é do tipo "Gerente" ou "Operador de Caixa";
                      a primeira posição do ComboBox do formulário (0) é referente a Gerente
                      e a segunda (1) a Operador de Caixa*/

                    /*uma conta Gerente recebe o status 1, que representa um status "Disponível",
                      uma conta Operador de Caixa não têm status e recebe valor 0*/
                    if (cboTipo.SelectedIndex == 0)
                    {
                        funcionario.Status = "1";
                    }
                    else
                    {
                        funcionario.Status = "0";
                    }

                    if (funcionario.Inserir() == 1)
                    {
                        MessageBox.Show(String.Format("Funcionário: {0} inserido com sucesso.", txtNome.Text));

                        //limpa o formulário
                        txtNome.Clear();
                        txtCpf.Clear();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtSenhaAux.Clear();

                        cboTipo.Enabled = true;
                        cboTipo.DropDownStyle = ComboBoxStyle.DropDown;
                        cboTipo.Text = "";

                        txtNome.Focus();
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
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos coretamente antes de continuar.");
            }
        }


        //volta para a tela de login se o Form for aberto fora da tela de Gerente
        private void FrmCadFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmLogGerente>().Count() == 0)
            {
                Application.OpenForms["FrmTelaLogin"].Show();
            }
        }

        //fecha o formulário
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

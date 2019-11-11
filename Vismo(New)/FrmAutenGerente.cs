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

                    if (funcionario.AlteraStatus(2) == 1)
                    {
                        MessageBox.Show("Alterado.");

                    }

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique login e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

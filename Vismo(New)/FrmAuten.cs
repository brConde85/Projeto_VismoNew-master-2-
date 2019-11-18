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
    public partial class FrmAuten : Form
    {
        public FrmAuten()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Login = txtLogin.Text;
                funcionario.Senha = txtSenha.Text;

                if (funcionario.VerificarLogin() == true)
                {
                    FrmCadFuncionario tela = new FrmCadFuncionario();
                    tela.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("Login inválido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnOk_Click(sender, e);
            }
        }
    }
}

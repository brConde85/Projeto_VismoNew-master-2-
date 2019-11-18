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
    public partial class FrmModoAusente2 : Form
    {
        public FrmModoAusente2(string login)
        {
            InitializeComponent();

            txtLogin.Text = login;
        }

        private void FrmModoAusente2_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FrmModoAusente telaAusente = new FrmModoAusente(txtLogin.Text);
            telaAusente.Show();
            this.Show();
            this.Hide();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Login = txtLogin.Text;

            if (funcionario.AlteraStatus(2) == 1)
            {
                funcionario.PegaLogin();

                //Exibe a mensagem de confirmação e fecha a tela de autenticação
                MessageBox.Show("Seu status foi alterado com sucesso.",
                    "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a tela de gerente com o novo status
                Application.OpenForms["FrmLogGerente"].Close();

                FrmLogGerente tela = new FrmLogGerente(funcionario.Login, funcionario.Senha);
                tela.Show();
            }
            else
            {
                MessageBox.Show("Erro ao alterar status do Usuário", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}

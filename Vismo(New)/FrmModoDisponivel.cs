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
    public partial class FrmModoDisponivel : Form
    {
        public FrmModoDisponivel(string login)
        {
            InitializeComponent();

            txtLogin.Text = login;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Neste modo você ira escolher\n todas as ações a serem tomadas.";
            label1.Visible = true;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            label1.Text = "Disponível";
            label1.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Login = txtLogin.Text;

            if (funcionario.AlteraStatus(1) == 1)
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

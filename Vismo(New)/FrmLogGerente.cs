using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;
using Control;


namespace Vismo_New_
{
    public partial class FrmLogGerente : Form
    {
        //Guarda o status do gerente logado
        public FrmLogGerente(string login, string senha)
        {
            InitializeComponent();

            Funcionario funcionario = new Funcionario();

            funcionario.Login = login;
            funcionario.Senha = senha;

            funcionario.PegaStatus();
            txtModo.Text = funcionario.Status;
        }

        // Ação para sair ou realizar logoff do sistema
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Application.OpenForms["FrmTelaLogin"].Show();
            }  
        }

        //Ações para abrir tela
        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmNovoFornecedor>().Count() == 0)
            {
                FrmNovoFornecedor tela = new FrmNovoFornecedor();
                tela.Show();
            } 
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmNovoProduto>().Count() == 0)
            {
                FrmNovoProduto tela = new FrmNovoProduto();
                tela.Show();
            } 
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmNovaVenda>().Count() == 0)
            {
                frmNovaVenda tela = new frmNovaVenda();
                tela.Show();
            }  
        }

        private void ProdutoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarProduto>().Count() == 0)
            {
                FrmListarProduto tela = new FrmListarProduto();
                tela.Show();
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadFuncionario>().Count() == 0)
            {
                FrmCadFuncionario tela = new FrmCadFuncionario();
                tela.Show();
            } 
        }

        private void funcionárioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFuncionario>().Count() == 0)
            {
                FrmListarFuncionario tela = new FrmListarFuncionario();
                tela.Show();
            }
        }

        private void fornecedorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFornecedor>().Count() == 0)
            {
                FrmListarFornecedor tela = new FrmListarFornecedor();
                tela.Show();
            }  
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroPagamento>().Count() == 0)
            {
                FrmCadastroPagamento tela = new FrmCadastroPagamento();
                tela.Show();
            } 
        }

        private void PagamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRegistroPagamento>().Count() == 0)
            {
                FrmRegistroPagamento tela = new FrmRegistroPagamento();
                tela.Show();
            }   
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRegistroVenda>().Count() == 0)
            {
                FrmRegistroVenda tela = new FrmRegistroVenda();
                tela.Show();
            }  
        }

        private void PedidosDeReposiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmPedidoReposicao>().Count() == 0)
            {
                FrmPedidoReposicao tela = new FrmPedidoReposicao();
                tela.Show();
            }   
        }

        private void MaisEMenosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMaisVendidos>().Count() == 0)
            {
                FrmMaisVendidos tela = new FrmMaisVendidos();
                tela.Show();
            }   
        }

        //Ações que abrem os modos de gerente
        private void ModosDoGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtModo.Text) == 1)
            {
                FrmModoDisponivel tela = new FrmModoDisponivel();
                tela.Show();
            }
            else if (Convert.ToInt32(txtModo.Text) == 2)
            {
                FrmModoAusente tela = new FrmModoAusente();
                tela.Show();
            }
            else
            {
               FrmModoAutonomo tela = new FrmModoAutonomo();
                tela.Show();
            }
        }

        //Ações para fechar os forms abertos no sistema se existentes e voltar para tela de login
        private void FrmLogGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmTelaLogin>().Count() == 1)
            {
                Application.OpenForms["FrmTelaLogin"].Show();
            }

            if (Application.OpenForms.OfType<FrmNovoProduto>().Count() == 1)
            {
                Application.OpenForms["FrmNovoProduto"].Close();
            }

            if (Application.OpenForms.OfType<FrmCadFuncionario>().Count() == 1)
            {
                Application.OpenForms["FrmCadFuncionario"].Close();
            }

            if (Application.OpenForms.OfType<FrmNovoFornecedor>().Count() == 1)
            {
                Application.OpenForms["FrmNovoFornecedor"].Close();
            }

            if (Application.OpenForms.OfType<FrmCadastroPagamento>().Count() == 1)
            {
                Application.OpenForms["FrmCadastroPagamento"].Close();
            }

            if (Application.OpenForms.OfType<FrmListarProduto>().Count() == 1)
            {
                Application.OpenForms["FrmListarProduto"].Close();
            }

            if (Application.OpenForms.OfType<FrmListarFuncionario>().Count() == 1)
            {
                Application.OpenForms["FrmListarFuncionario"].Close();
            }

            if (Application.OpenForms.OfType<FrmListarFornecedor>().Count() == 1)
            {
                Application.OpenForms["FrmListarFornecedor"].Close();
            }

            if (Application.OpenForms.OfType<FrmRegistroPagamento>().Count() == 1)
            {
                Application.OpenForms["FrmRegistroPagamento"].Close();
            }

            if (Application.OpenForms.OfType<FrmRegistroVenda>().Count() == 1)
            {
                Application.OpenForms["FrmRegistroVenda"].Close();
            }

            if (Application.OpenForms.OfType<FrmMaisVendidos>().Count() == 1)
            {
                Application.OpenForms["FrmMaisVendidos"].Close();
            }

            if (Application.OpenForms.OfType<FrmPedidoReposicao>().Count() == 1)
            {
                Application.OpenForms["FrmPedidoReposicao"].Close();
            }

            if (Application.OpenForms.OfType<frmNovaVenda>().Count() == 1)
            {
                Application.OpenForms["frmNovaVenda"].Close();
            }
        }

        //Ações para fechar modos de gerente caso estejam abertos
        private void Label1_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FrmModoDisponivel tela = new FrmModoDisponivel();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            FrmModoAutonomo tela = new FrmModoAutonomo();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAusente>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() > 0)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            FrmModoAusente tela = new FrmModoAusente();
            tela.Show();

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() > 0)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() > 0)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        //Ação para alterar o status do gerente
        private void FrmLogGerente_Load(object sender, EventArgs e)
        {
            txtModo.Refresh();
            if(txtModo.Text == "1")
            {
                pcbAusente.Visible = false;
                pcbAutomo.Visible = false;
            }
            else if (txtModo.Text == "2")
            {
                pcbDisponivel.Visible = false;
                pcbAutomo.Visible = false;
                label5.Text = "Ausente";
            }
            else
            {
                pcbAusente.Visible = false;
                pcbDisponivel.Visible = false;
                label5.Text = "Autônomo";
            }


        }
    }
    
}

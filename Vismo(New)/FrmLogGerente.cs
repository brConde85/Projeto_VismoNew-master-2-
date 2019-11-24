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
    public partial class FrmLogGerente : Form
    {
        Funcionario funcionario;

        //Guarda o status e nome do gerente logado
        public FrmLogGerente(string login, string senha)
        {
            InitializeComponent();

            funcionario = new Funcionario();

            funcionario.Login = login;
            funcionario.Senha = senha;

            funcionario.PegaStatus();

            txtModo.Text = funcionario.Status;
            txtLogin.Text = funcionario.Login;
            lblNome.Text = funcionario.Nome;
        }

 
        //Ações para abrir as telas do sistema
        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadFornecedor>().Count() == 0)
            {
                FrmCadFornecedor tela = new FrmCadFornecedor(0);
                tela.Show();
            } 
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadProduto>().Count() == 0)
            {
                FrmCadProduto tela = new FrmCadProduto(0);
                tela.Show();
            } 
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmNovaVenda>().Count() == 0)
            {
                FrmNovaVenda tela = new FrmNovaVenda();
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
            if (Application.OpenForms.OfType<FrmCadPagamento>().Count() == 0)
            {
                FrmCadPagamento tela = new FrmCadPagamento();
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

        private void ModosDoGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(txtLogin.Text);
                tela.Show();
            }          
        }

        private void ProdutoDaCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmNovoProdutoCasa>().Count() == 0)
            {
                FrmNovoProdutoCasa tela = new FrmNovoProdutoCasa();
                tela.Show();
            }
        }


        //volta para a tela de login
        private void FrmLogGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() == 0 &&
                Application.OpenForms.OfType<FrmModoAusente2>().Count() == 0 &&
                Application.OpenForms.OfType<FrmModoAutonomo>().Count() == 0)
            {
                Application.OpenForms["FrmTelaLogin"].Show();
            }   
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
                lblModo.Text = "Ausente";
            }
            else
            {
                pcbAusente.Visible = false;
                pcbDisponivel.Visible = false;
                lblModo.Text = "Autônomo";
            }


        }

        private void LblModo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(funcionario.Login);
                tela.Show();
            }
        }

        private void PcbAutomo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(funcionario.Login);
                tela.Show();
            }
        }

        private void PcbAusente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(funcionario.Login);
                tela.Show();
            }
        }

        private void PcbDisponivel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(funcionario.Login);
                tela.Show();
            }
        }


        //sai do programa e abre a tela de Login
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();

                Application.OpenForms["FrmTelaLogin"].Show();
            }
        }

        //abre um Form de ajuda
        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_logGerenteAjuda>().Count() == 0)
            {
                Frm_logGerenteAjuda tela = new Frm_logGerenteAjuda();
                tela.Show();
            }  
        }
    } 
}

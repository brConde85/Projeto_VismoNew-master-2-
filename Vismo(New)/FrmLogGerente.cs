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

        private void ModosDoGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(txtLogin.Text);
                tela.Show();
            }          
        }



        //Fecha os forms abertos no sistema se existentes e voltar para tela de login
        private void FrmLogGerente_FormClosed(object sender, FormClosedEventArgs e)
        {               
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

            if (Application.OpenForms.OfType<FrmNovaVenda>().Count() == 1)
            {
                Application.OpenForms["FrmNovaVenda"].Close();
            }

            if (Application.OpenForms.OfType<FrmModo>().Count() == 1)
            {
                Application.OpenForms["FrmModo"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoDisponivel>().Count() == 1)
            {
                Application.OpenForms["FrmModoDisponivel"].Close();
            }

            if(Application.OpenForms.OfType<FrmModoAusente>().Count() == 1)
            {
                Application.OpenForms["FrmModoAusente"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAusente2>().Count() == 1)
            {
                Application.OpenForms["FrmModoAusente2"].Close();
            }

            if (Application.OpenForms.OfType<FrmModoAutonomo>().Count() == 1)
            {
                Application.OpenForms["FrmModoAutonomo"].Close();
            }

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
                FrmModo tela = new FrmModo(txtLogin.Text);
                tela.Show();
            }
        }

        private void PcbAutomo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(txtLogin.Text);
                tela.Show();
            }
        }

        private void PcbAusente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(txtLogin.Text);
                tela.Show();
            }
        }

        private void PcbDisponivel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModo>().Count() == 0)
            {
                FrmModo tela = new FrmModo(txtLogin.Text);
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
    } 
}

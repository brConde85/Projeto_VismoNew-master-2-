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
        public FrmLogGerente(string login, string senha)
        {
            InitializeComponent();

            Funcionario funcionario = new Funcionario();

            funcionario.Login = login;
            funcionario.Senha = senha;

            funcionario.PegaStatus();
            txtModo.Text = funcionario.Status;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Application.OpenForms["FrmTelaLogin"].Show();
            }  
        }

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

        private void ModosDoGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtModo.Text) == 1)
            {
                TelaDisponivel tela = new TelaDisponivel();
                tela.Show();
            }
            else if (Convert.ToInt32(txtModo.Text) == 2)
            {
                TelaAusente tela = new TelaAusente();
                tela.Show();
            }
            else
            {
                TelaAutonomo tela = new TelaAutonomo();
                tela.Show();
            }
        }

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
    }
}

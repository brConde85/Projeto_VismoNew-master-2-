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


namespace Vismo_New_
{
    public partial class FrmLogGerente : Form
    {
        public FrmLogGerente()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoFornecedor tela = new FrmNovoFornecedor();
            tela.Show();

            Close();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoProduto tela = new FrmNovoProduto();
            tela.Show();

            Close();
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaVenda tela = new frmNovaVenda();
            tela.Show();

            Close();
        }

        private void ProdutoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListarProduto tela = new FrmListarProduto();
            tela.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario tela = new FrmCadFuncionario();
            tela.Show();

            Close();
        }

        private void funcionárioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListarFuncionario tela = new FrmListarFuncionario();
            tela.Show();
        }

        private void fornecedorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPagamento tela = new FrmCadastroPagamento();
            tela.Show();

            Close();
        }

        private void PagamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRegistroPagamento tela = new FrmRegistroPagamento();
            tela.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroVenda tela = new FrmRegistroVenda();
            tela.Show();
        }

        private void AusenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAusente tela = new TelaAusente();
            tela.Show();
        }

        private void DisponívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDisponivel tela = new TelaDisponivel();
            tela.Show();
        }

        private void AutônomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAutonomo tela = new TelaAutonomo();
            tela.Show();
        }
    }
}

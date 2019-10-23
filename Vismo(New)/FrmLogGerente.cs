using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

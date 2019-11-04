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
    public partial class FrmLogOpCaixa : Form
    {
        public FrmLogOpCaixa()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaVenda tela = new frmNovaVenda();
            tela.Show();

            this.Close();
        }

        private void AbrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmCadastroPagamento tela = new FrmCadastroPagamento();
            tela.Show();
        }

        private void produtoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListarProduto tela = new FrmListarProduto();
            tela.Show();
        }

        private void fornecedorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }

        private void pagamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRegistroPagamento tela = new FrmRegistroPagamento();
            tela.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroVenda tela = new FrmRegistroVenda();
            tela.Show();
        }

        private void pedidosDeReposiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoReposicao tela = new FrmPedidoReposicao();
            tela.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmNovaVenda tela = new frmNovaVenda();
            tela.Show();
        }
    }
}

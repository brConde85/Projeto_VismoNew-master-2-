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
    }
}

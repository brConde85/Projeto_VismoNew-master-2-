﻿using System;
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
        // Ações para abrir tela
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

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmete sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Application.OpenForms["FrmTelaLogin"].Show();
            }
        }

        private void FrmLogOpCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmTelaLogin>().Count() == 1)
            {
                Application.OpenForms["FrmTelaLogin"].Show();
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

            if (Application.OpenForms.OfType<frmNovaVenda>().Count() == 1)
            {
                Application.OpenForms["frmNovaVenda"].Close();
            }
        }
    }
}

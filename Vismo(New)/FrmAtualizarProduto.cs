﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using System.Data.SqlClient;

namespace Vismo_New_
{
    public partial class FrmAtualizarProduto : Form
    {
        Produto produto = new Produto();
        Fornecedor fornecedor = new Fornecedor();
        
        //Preenche o formulário com o registro do produto que será atualizado
        public FrmAtualizarProduto(int id, string nome, double preco, int qtd, int fornec, string pchave)
        {
            InitializeComponent();
            produto.Codigo = id;
            txtId.Text = Convert.ToString(fornec);
            txtNome.Text = nome;
            txtPreco.Text = Convert.ToString(preco);
            txtQtd.Text = Convert.ToString(qtd);
            cboPalavra.Text = pchave;   
        }

        //Volta para o registro de produtos 
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Para atualizar
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") &&
                !cboPalavra.Text.Equals("") &&
                !txtId.Text.Equals(""))
            {
                fornecedor.CodigoF = Convert.ToInt32(txtId.Text);

                if (fornecedor.PegaId() == 1)
                {
                    try
                    {
                        produto.Nome = txtNome.Text;
                        produto.Preco = Convert.ToDouble(txtPreco.Text);
                        produto.QtdEstoque = Convert.ToInt32(txtQtd.Text);
                        produto.Pchave = cboPalavra.Text;
                        produto.fornecedor.CodigoF = fornecedor.CodigoF;
                        produto.Pchave = cboPalavra.Text;

                        if (produto.Update() == 1)
                        {
                            MessageBox.Show("Produto atualizado com sucesso.");

                            txtNome.Clear();
                            txtPreco.Clear();
                            txtQtd.Clear();
                            cboPalavra.Text = "";
                            txtNome.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        //exibe mensagem em caso de erro
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("ID de fornecedor não encontrado", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

            else
            {
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos antes de continuar.");
            }
        }

        //Abre o registro de fornecedores
        private void TxtId_Enter(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }
        
    }
}

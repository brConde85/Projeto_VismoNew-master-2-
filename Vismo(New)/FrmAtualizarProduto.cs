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
using System.Data.SqlClient;

namespace Vismo_New_
{
    public partial class FrmAtualizarProduto : Form
    {
        Produto produto;
        
        //Preenche o formulário com o registro do produto que será atualizado ao carregar o Form
        public FrmAtualizarProduto(int codigo)
        {
            InitializeComponent();

            produto = new Produto();

            produto.Codigo = codigo;

            if (produto.Listar1() != null)
            {
                txtId.Text = Convert.ToString(produto.fornecedor.CodigoF);
                txtNome.Text = produto.Nome;
                txtPreco.Text = Convert.ToString(produto.Preco);
                txtQtd.Text = Convert.ToString(produto.QtdEstoque);
                cboPalavra.Text = produto.Pchave;
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro ao pesquisar pelo registro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        //Volta para o registro de produtos 
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();

            FrmListarProduto tela = new FrmListarProduto();
            tela.Show();
        }

        // Ação para atualizar o produto
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") &&
                !cboPalavra.Text.Equals("") &&
                !txtId.Text.Equals(""))
            {
                //atribuição do campo de ID de funcionário ao atributo da classe Funcionário
                produto.fornecedor.CodigoF = Convert.ToInt32(txtId.Text);

                //checa se ID de funcionário está registrado
                if (produto.fornecedor.PegaId() == 1)
                {
                    try
                    {
                        //atribuição dos campos do formulário aos atributos da classe Produto
                        produto.Nome = txtNome.Text;
                        produto.Preco = Convert.ToDouble(txtPreco.Text);
                        produto.QtdEstoque = Convert.ToInt32(txtQtd.Text);
                        produto.Pchave = cboPalavra.Text;
                        produto.Pchave = cboPalavra.Text;

                        //chama o método de atualização de registro de produto
                        if (produto.Update() == 1)
                        {
                            MessageBox.Show("Produto atualizado com sucesso.");

                            Close();

                            FrmListarProduto tela = new FrmListarProduto();
                            tela.Show();
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

        //Abre o registro de fornecedores para que o usuário possa selecionar o ID correspondente
        private void TxtId_Enter(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }


        //tratamento da caixa de texto para receber somente valores numéricos
        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}

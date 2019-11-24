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

                if (produto.Status == "Desabilitado")
                {
                    lblStatus.Text = "Habilitar produto";
                }

                ItemDeVenda item = new ItemDeVenda();

                item.IdProduto = produto.Codigo;

                if (item.Busca() == 0)
                {
                    lblRemover.Enabled = true;
                }
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

        private void LblStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Desabilitar produto")
            {
                if (MessageBox.Show("Essa ação não removerá o registro, mas fará com que não " +
               "esteja disponível em relacionamentos com o sistema.\n\n" +
               "Você poderá desfazer essa ação futuramente.\n\n" +
               "Continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produto.MudaStatus2("Desabilitado") == 1)
                    {
                        MessageBox.Show("Registro desabilitado.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();

                        FrmListarProduto tela = new FrmListarProduto();
                        tela.Show();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar registro", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Habilitar registro de fornecedor e permitir relacionamentos " +
                    "com o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produto.MudaStatus2("Habilitado") == 1)
                    {
                        MessageBox.Show("Registro habilitado.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();

                        FrmListarProduto tela = new FrmListarProduto();
                        tela.Show();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar registro", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LblRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (produto.Remover() == 1)
                {
                    MessageBox.Show("Registro removido.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmListarProduto tela = new FrmListarProduto();
                    tela.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao remover registro", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

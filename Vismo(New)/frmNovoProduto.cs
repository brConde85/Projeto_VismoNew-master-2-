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
    public partial class FrmNovoProduto : Form
    {
        Produto produto = new Produto();
        Fornecedor fornecedor = new Fornecedor();

        public FrmNovoProduto()
        {
            InitializeComponent();
        }

        // volta ao menu principal
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Ação de cadastramento de produto 
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") &&
                (!cboPalavra.Text.Equals("")))
            {
                try
                {
                    //atribuição dos compos do formulário para os atributos do produto
                    produto.Nome = txtNome.Text;
                    produto.Preco = Convert.ToDouble(txtPreco.Text);
                    produto.QtdEstoque = Convert.ToInt32(txtQtd.Text);
                    produto.Pchave = cboPalavra.Text;
                    produto.fornecedor.CodigoF = fornecedor.CodigoF;

                    //chamada do método Inserir(), que insere os registros no banco
                    int x = produto.Inserir();

                    if (x > 0) //o retorno do método deve ser maior que 0 para sucesso
                    {
                        MessageBox.Show("Produto cadastrado com sucesso.");

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
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos antes de continuar.");
            }
        }

        //Ação para validação do fornecedor inserido 
        private void TxtFornec_Leave(object sender, EventArgs e)
        {
            if (!txtFornec.Text.Equals(""))
            {
                try
                {
                    //atribuição do campo do fornecedor para seu atributo de nome
                    fornecedor.Nome = txtFornec.Text;

                    //chamada do método Checa(), que connfere se o nome informado está nos registros

                    //retorno 0 = não há reistros
                    //retorno 1 = há registos
                    if (fornecedor.Checa() == 0)
                    {
                        if (MessageBox.Show("Fornecedor (" + fornecedor.Nome + ") não encontrado nos registros, deseja cadastrá-lo?",
                            "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Close();
                            FrmNovoFornecedor tela = new FrmNovoFornecedor();
                            tela.Show();
                        }

                        //mantém o formulário de produto desativado
                        txtFornec.BackColor = Color.MistyRose;
                        txtNome.Enabled = false;
                        txtPreco.Enabled = false;
                        txtQtd.Enabled = false;
                        btnOk.Enabled = false;
                        cboPalavra.Enabled = false;
                        lblMsg.Text = "* Obrigatório.";
                    }
                    else
                    {
                        //libera o formulário de produto
                        txtFornec.BackColor = Color.White;
                        lblMsg.Text = "";

                        txtNome.Enabled = true;
                        txtPreco.Enabled = true;
                        txtQtd.Enabled = true;
                        btnOk.Enabled = true;
                        cboPalavra.Enabled = true;

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
                //mantém o formulário de produto desativado
                txtFornec.BackColor = Color.MistyRose;
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
                txtQtd.Enabled = false;
                btnOk.Enabled = false;
                cboPalavra.Enabled = false;
                lblMsg.Text = "* Obrigatório.";
            }
        }


        //tratamento da caixa de texto para receber somente valores numéricos
        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
    
}

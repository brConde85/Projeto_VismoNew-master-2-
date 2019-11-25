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
    public partial class FrmCadProduto : Form
    {
        Produto produto;
        
        //Preenche o formulário com o registro do produto que será atualizado ao carregar o Form
        public FrmCadProduto(int codigo)
        {
            InitializeComponent();

            produto = new Produto();

            produto.Codigo = codigo;

            if (codigo > 0)
            {
                string comando = "SELECT * FROM Produto WHERE codigo = @codigo";

                if (produto.Listar(comando) != null)
                {
                    txtFornec.Text = Convert.ToString(produto.fornecedor.Codigo);
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

                    Text = "Editar Produto - Vismo";
                    lblTitulo.Text = "Editar produto";
                }
                else
                {
                    MessageBox.Show("Ocorreu algum erro ao pesquisar pelo registro.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Close();
                }
            } 
        }


        //formata o campo de preço do formulário
        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Editar produto")
            {
                TxtPreco_Leave(sender, e);
            }
            else
            {
                txtPreco.Enabled = true;
                lblValor.Visible = false;

                lblStatus.Visible = false;
                lblRemover.Visible = false;

                btnEditar.Visible = false;
                btnSalvar.Visible = true;
            }
        }

        //ação para salvar o produto
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") &&
                !cboPalavra.Text.Equals("") &&
                !txtFornec.Text.Equals("") &&
                lblCod.Visible == false)
            {
                try
                {
                    //atribuição dos compos do formulário para os atributos do produto
                    produto.Nome = txtNome.Text;

                    double valor = Convert.ToDouble(txtPreco.Text.Replace("R$", ""));
                    produto.Preco = valor;

                    produto.QtdEstoque = Convert.ToInt32(txtQtd.Text);
                    produto.Pchave = cboPalavra.Text;
                    produto.fornecedor.Codigo = Convert.ToInt32(txtFornec.Text);

                    if (produto.Inserir() == 1)
                    {
                        MessageBox.Show("Produto cadastrado com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtFornec.Clear();
                        txtPreco.Clear();
                        txtQtd.Clear();

                        cboPalavra.DropDownStyle = ComboBoxStyle.DropDown;
                        cboPalavra.Text = "";

                        txtPreco.Enabled = true;
                        lblValor.Visible = false;

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
                MessageBox.Show("Preencha todos os campos corretamente antes de continuar.");
            }
        }

        //ação para editar o produto
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") &&
                !cboPalavra.Text.Equals("") &&
                !txtFornec.Text.Equals("") &&
                lblCod.Visible == false)
            {
                //atribuição do campo de ID de funcionário ao atributo da classe Funcionário
                produto.fornecedor.Codigo = Convert.ToInt32(txtFornec.Text);

                //checa se ID de funcionário está registrado
                if (produto.fornecedor.PegaId() == 1)
                {
                    try
                    {
                        //atribuição dos campos do formulário aos atributos da classe Produto
                        produto.Nome = txtNome.Text;

                       double valor = Convert.ToDouble(txtPreco.Text.Replace("R$", ""));
                        produto.Preco = valor;

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

                    catch (SqlException ex)
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
                MessageBox.Show("Preencha todos os campos corretamente antes de continuar.");
            }
        }

        //Abre o registro de fornecedores para que o usuário possa selecionar o ID correspondente
        private void LblRegistro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFornecedor>().Count() == 0)
            {
                FrmListarFornecedor tela = new FrmListarFornecedor();

                tela.StartPosition = FormStartPosition.WindowsDefaultLocation;
                tela.Size = new Size(628, 509);

                tela.lblMsg.Visible = false;
                tela.chkDesabilitados.Visible = false;

                tela.Show();
            }
        }


        //tratamento da caixa de texto para receber somente valores numéricos
        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtFornec_KeyPress(object sender, KeyPressEventArgs e)
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
                    string comando = "UPDATE Produto SET status = 'Desabilitado' " +
                    "WHERE codigo = @codigo";

                    if (produto.MudaStatus(comando) == 1)
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
                    string comando = "UPDATE Produto SET status = 'Habilitado' " +
                    "WHERE codigo = @codigo";

                    if (produto.MudaStatus(comando) == 1)
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


        //formata o campo de preço do formulário
        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            float valor = float.Parse(txtPreco.Text);
            txtPreco.Text = String.Format("{0:c}", valor);

            if (valor > 0 && valor <= 999.99)
            {
                txtPreco.Enabled = false;
                lblAlto.Visible = false;
                lblValor.Visible = true;
            }
            else
            {
                lblAlto.Visible = true;
                txtPreco.Clear();
            }
        }

        //permite somente valores numérios e vírgula no campo de preço
        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        //libera o campo de preço para alteração
        private void LblValor_Click(object sender, EventArgs e)
        {
            txtPreco.Enabled = true;
            txtPreco.Clear();
            txtPreco.Focus();

            lblValor.Visible = false;
        }

        //tratamento do comboBox 
        private void CboPalavra_Enter(object sender, EventArgs e)
        {
            cboPalavra.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //checa se código de fornecedor informado está registrado
        private void TxtFornec_Leave(object sender, EventArgs e)
        {
            
            if (!txtFornec.Text.Equals(""))
            {
                produto.fornecedor.Codigo = Convert.ToInt32(txtFornec.Text);
                if (produto.fornecedor.PegaId() == 1)
                {
                    lblCod.Visible = false;
                }
                else
                {
                    lblCod.Visible = true;
                }
            }
            
        }


        //Volta para o registro de produtos 
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Editar produto")
            {
                FrmListarProduto tela = new FrmListarProduto();
                tela.Show();
            }

            Close();
        }

        //ação feita ao sair do Form, fechando a tela de registro de fornecedores, se aberta
        private void FrmCadProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFornecedor>().Count() > 0)
            {
                Application.OpenForms["FrmListarFornecedor"].Close();
            }
        }
    }
}

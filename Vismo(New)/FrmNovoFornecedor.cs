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


namespace Vismo_New_
{
    public partial class FrmNovoFornecedor : Form
    {
        Produto produto;

        public FrmNovoFornecedor(int codigo)
        {
            InitializeComponent();

            produto = new Produto();

            produto.fornecedor.CodigoF = codigo;

            if (codigo > 0)
            {
                if (produto.fornecedor.PegaNome() == 1)
                {
                    txtNome.Text = produto.fornecedor.Nome;

                    Text = "Editar Fornecedor - Vismo";
                    lblTitulo.Text = "Editar fornecedor";

                    btnSalvar.Visible = false;
                    btnEditar.Visible = true;

                    if (produto.fornecedor.Status == "Desabilitado")
                    {
                        lblStatus.Text = "Habilitar fornecedor";
                    }

                    lblStatus.Visible = true;
                    lblRemover.Visible = true;

                    if (produto.Busca() == 0)
                    {
                        Pagamento pagamento = new Pagamento();

                        pagamento.fornecedor.CodigoF = produto.fornecedor.CodigoF;

                        if (pagamento.Busca() == 0)
                        {
                            lblRemover.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao procurar pelo registro.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Close();
                }
            }  
        }


        //checa se nome informado já está registrado
        private void TxtNome_Leave(object sender, EventArgs e)
        {
            produto.fornecedor.Nome = txtNome.Text;

            if (produto.fornecedor.Checa() == 1)
            {
                lblNome.Visible = true;
            }
            else
            {
                lblNome.Visible = false;
            }
        }

        //ação para cadastrar um novo fornecedor
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //caso o campo for preenchido e nome já não estiver registrado
            if (!txtNome.Text.Equals("") && lblNome.Visible == false) 
            {
                //mensagem de confirmação
                if (MessageBox.Show("Adicionar o fornecedor " + txtNome.Text
                     + " ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (produto.fornecedor.Inserir() == 1) 
                        {
                            MessageBox.Show("Fornecedor cadastrado com sucesso.");

                            txtNome.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu algum erro ao tentar cadastrar registro.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        //exibe mensagem em caso de erro
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
        }

        //ação para editar um fornecedor
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //caso o campo for preenchido e nome já não estiver registrado
            if (!txtNome.Text.Equals("") && lblNome.Visible == false)
            {
                try
                {
                    if (produto.fornecedor.Atualizar() == 1)
                    {
                        MessageBox.Show("Fornecedor atualizado com sucesso.");

                        FrmListarFornecedor tela = new FrmListarFornecedor();
                        tela.Show();

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu algum erro ao tentar cadastrar registro.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        //ação para voltar ao menu principal
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (Text == "Editar Fornecedor - Vismo")
            {
                FrmListarFornecedor tela = new FrmListarFornecedor();
                tela.Show();
            }

            Close();
        }

        private void LblDesabilitar_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Desabilitar fornecedor")
            {
                if (MessageBox.Show("Essa ação não removerá o registro, mas fará com que não " +
               "esteja disponível em relacionamentos com o sistema.\n\n" +
               "Todos os produtos registrados em nome do fornecedor também serão " +
               "desabalitados, ficando indisponíveis para venda.\n\n" +
               "Você poderá desfazer essa ação futuramente.\n\n" +
               "Continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produto.Busca() > 0)
                    {
                        if (produto.MudaStatus() >= 1)
                        {
                            if (produto.fornecedor.MudaStatus("Desabilitado") == 1)
                            {
                                MessageBox.Show("Registro desabilitado.", "Confirmação",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FrmListarFornecedor tela = new FrmListarFornecedor();
                                tela.Show();

                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao alterar registro", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar registro", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (produto.fornecedor.MudaStatus("Desabilitado") == 1)
                        {
                            MessageBox.Show("Registro desabilitado.", "Confirmação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmListarFornecedor tela = new FrmListarFornecedor();
                            tela.Show();

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar registro", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Habilitar registro de fornecedor e permitir relacionamentos " +
                    "com o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produto.fornecedor.MudaStatus("Habilitado") == 1)
                    {
                        MessageBox.Show("Registro habilitado.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (produto.AchaStatus() == 1)
                        {
                            FrmListarProduto tela = new FrmListarProduto();

                            tela.dgvProduto.Columns["Selecionar"].Visible = true;

                            tela.lblMsg.Visible = false;
                            tela.lblNomeProd.Visible = false;
                            tela.txtNome.Visible = false;
                            tela.btnPesquisar.Visible = false;
                            tela.btnVoltar.Visible = false;

                            tela.btnConfirmar.Visible = true;
                            tela.lblSelecionar.Visible = true;
                            tela.chkSelecionar.Visible = true;
                            tela.lblCod.Text = Convert.ToString(produto.fornecedor.CodigoF);

                            tela.Show();
                        }
                        else
                        {
                            FrmListarFornecedor tela = new FrmListarFornecedor();
                            tela.Show();
                        }
                       
                        Close();
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
                if (produto.fornecedor.Remover() == 1)
                {
                    MessageBox.Show("Registro removido.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmListarFornecedor tela = new FrmListarFornecedor();
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

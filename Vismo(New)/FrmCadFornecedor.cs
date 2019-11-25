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
    public partial class FrmCadFornecedor : Form
    {
        Produto produto;

        public FrmCadFornecedor(int codigo)
        {
            InitializeComponent();

            produto = new Produto();

            produto.fornecedor.Codigo = codigo;

            if (codigo > 0)
            {
                //ao abrir o Form, é preparado para ações de alteração de registro
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

                    //checa se fornecedor está relacionado com algum produto ou pagamento no sistema
                    if (produto.Busca() == 0)
                    {
                        Pagamento pagamento = new Pagamento();

                        pagamento.fornecedor.Codigo = produto.fornecedor.Codigo;

                        if (pagamento.Busca() == 0)
                        {
                            //se não estiver, é possivel remover o fornecedor do sistema
                            lblRemover.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao procurar pelo registro.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //fecha o Form caso ocorra algum erro ao carregar as informações do fornecedor
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

        //ação para desabilitar ou habilitar registro
        private void LblStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Desabilitar fornecedor")
            {
                //confirmação para desabilitar registro
                if (MessageBox.Show("Essa ação não removerá o registro, mas fará com que não " +
               "esteja disponível em relacionamentos com o sistema.\n\n" +
               "Todos os produtos registrados em nome do fornecedor também serão " +
               "desabalitados, ficando indisponíveis para venda.\n\n" +
               "Você poderá desfazer essa ação futuramente.\n\n" +
               "Continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //checa novamente se fornecedor está registrado com algum produto
                    if (produto.Busca() > 0)
                    {
                        string comando = "UPDATE Produto SET status = 'Desabilitado' " +
                        "WHERE codFornecedor = @codFornecedor";

                        //se estiver desabilita todos os produtos relacionados
                        if (produto.MudaStatus(comando) >= 1)
                        {
                            //desabilita o fornecedor
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
                        //desabilita o fornecedor somente, caso não esteja relacionado a algum produto
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
                //confirmação para habilitar registro
                if (MessageBox.Show("Habilitar registro de fornecedor e permitir relacionamentos " +
                    "com o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //habilita o fornecedor
                    if (produto.fornecedor.MudaStatus("Habilitado") == 1)
                    {
                        MessageBox.Show("Registro habilitado.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*procura por produtos desabilitados relacionados com o fornecedor, se encontrar
                          abre os registros de produtos para uma possível habilitação de produto*/
                        if (produto.AchaStatus() == 1)
                        {
                            //prepara a tela de registro de produtos para habilitação
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
                            tela.lblCod.Text = Convert.ToString(produto.fornecedor.Codigo);

                            tela.Show();
                        }
                        else
                        {
                            /*caso não encontre produtos relacionados desabilitados,
                              volta para o registro de fornecedores */ 
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

        //ação para remover registro
        private void LblRemover_Click(object sender, EventArgs e)
        {
            //confirmação
            if (MessageBox.Show("Remover registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //remove o registro
                if (produto.fornecedor.Remover() == 1)
                {
                    MessageBox.Show("Registro removido.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //volta para o registro de fornecedores
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
    }
}

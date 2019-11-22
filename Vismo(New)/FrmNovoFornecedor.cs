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
        Fornecedor fornecedor;

        public FrmNovoFornecedor(int codigo)
        {
            InitializeComponent();

            fornecedor = new Fornecedor();

            fornecedor.CodigoF = codigo;

            if (codigo > 0)
            {
                if (fornecedor.PegaNome() == 1)
                {
                    txtNome.Text = fornecedor.Nome;

                    Text = "Editar Fornecedor - Vismo";
                    lblTitulo.Text = "Editar fornecedor";

                    btnSalvar.Visible = false;
                    btnEditar.Visible = true;
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
            fornecedor.Nome = txtNome.Text;

            if (fornecedor.Checa() == 1)
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
                        if (fornecedor.Inserir() == 1) 
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
                    if (fornecedor.Atualizar() == 1)
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
    }
}

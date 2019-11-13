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
    public partial class FrmCadastroPagamento : Form
    {
        public FrmCadastroPagamento()
        {
            InitializeComponent();
        }

        //Ação para abrir o registro de fornecedores
        private void txtCod_Enter(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }

        // Ação para cadastrar um pagamento
        private void btnOk_Click(object sender, EventArgs e)
        {
            //compara se todos os campos foram preenchidos
            if(!txtValor.Text.Equals("") &&
                !txtCod.Text.Equals("") &&
                !txtDesc.Text.Equals("") &&
                !txtPrazo.Text.Equals(""))
            {
                try
                {
                    Pagamento pagamento = new Pagamento();

                    //atribuição dos campos do formulário aos atributos da classe Pagamento
                    pagamento.Valor = txtValor.Text;
                    pagamento.fornecedor.CodigoF = Convert.ToInt32(txtCod.Text);
                    pagamento.Descricao = txtDesc.Text;

                    /*compara se a data inserida como prazo de pagamento é válida;
                      o prazo deve ser de no mínimo um dia*/
                    if (Convert.ToDateTime(txtPrazo.Text) > DateTime.Now)
                    {
                        pagamento.Validade = Convert.ToDateTime(txtPrazo.Text);

                        //chamada do método de inserção
                        if (pagamento.Inserir() == 1)
                        {
                            //limpa o formulário para um possível novo cadastro
                            txtValor.Clear();
                            txtCod.Clear();
                            txtDesc.Clear();
                            txtPrazo.Clear();

                            txtValor.Focus();

                            MessageBox.Show("Pagamento registrado", "Sucesso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //em caso de erro
                            MessageBox.Show("Falha ao registrar pagamento", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //caso a data estiver inválida
                        MessageBox.Show("Insira uma data válida antes de continuar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos antes de continuar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //volta ao Menu Principal
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

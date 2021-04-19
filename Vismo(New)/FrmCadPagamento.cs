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
    public partial class FrmCadPagamento : Form
    {
        public FrmCadPagamento()
        {
            InitializeComponent();
        }

        // Ação para cadastrar um pagamento
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //compara se todos os campos foram preenchidos
            if(!txtValor.Text.Equals("") &&
                !txtCod.Text.Equals("") &&
                !txtDesc.Text.Equals("") &&
                !txtPrazo.Text.Equals("") &&
                lblAlto.Visible == false && lblCod.Visible == false &&
                lblPrazo.Visible == false && lblDataInv.Visible == false)
            {
                try
                {
                    Pagamento pagamento = new Pagamento();

                    //atribuição dos campos do formulário aos atributos da classe Pagamento
                    double valor = Convert.ToDouble(txtValor.Text.Replace("R$", ""));
                    pagamento.Valor = valor;

                    pagamento.fornecedor.Codigo = Convert.ToInt32(txtCod.Text);
                    pagamento.Descricao = txtDesc.Text;

                    pagamento.Validade = Convert.ToDateTime(txtPrazo.Text);

                    //chamada do método de inserção
                    if (pagamento.Inserir() == 1)
                    {
                        //limpa o formulário para um possível novo cadastro
                        txtValor.Clear();
                        txtCod.Clear();
                        txtDesc.Clear();
                        txtPrazo.Clear();

                        txtValor.Enabled = true;
                        lblValor.Visible = false;

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //caso algum campo não for preenchido
                MessageBox.Show("Preencha todos os campos corretamente antes de continuar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //tratamento da caixa de texto para receber somente valores numéricos
        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //chehca se o valor é válido e insere uma máscara de valor monetário
        private void TxtValor_Leave(object sender, EventArgs e)
        {
            if (!txtValor.Text.Equals(""))
            {
                float valor = float.Parse(txtValor.Text);
                txtValor.Text = String.Format("{0:c}", valor);

                if (valor > 0 && valor <= 9999.99)
                {
                    txtValor.Enabled = false;
                    lblAlto.Visible = false;
                    lblValor.Visible = true;
                }
                else
                {
                    lblAlto.Visible = true;
                    txtValor.Clear();
                }
            }
        }

        //limpa e libera o campo de preço para alteração 
        private void LblValor_Click(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
            txtValor.Clear();
            txtValor.Focus();

            lblValor.Visible = false;
        }

        //checa se código de fornecedor informado está registrado
        private void TxtCod_Leave(object sender, EventArgs e)
        {
            if (!txtCod.Text.Equals(""))
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.Codigo = Convert.ToInt32(txtCod.Text);

                if (fornecedor.PegaId() == 1)
                {
                    lblCod.Visible = false;
                }
                else
                {
                    lblCod.Visible = true;
                }
            }
        }

        //abre os registros de fornecedores
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

        //checa se data informada é válida e se é da data atual ou superior
        private void TxtPrazo_Leave(object sender, EventArgs e)
        {
            txtPrazo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!txtPrazo.Text.Equals(""))
            {
                try
                {
                    txtPrazo.TextMaskFormat = MaskFormat.IncludeLiterals;

                    DateTime data = Convert.ToDateTime(txtPrazo.Text);

                    lblDataInv.Visible = false;

                    if (data >= DateTime.Today)
                    {
                        lblPrazo.Visible = false;
                    }
                    else
                    {
                        lblPrazo.Visible = true;
                    }
                }
                catch
                {
                    lblDataInv.Visible = true;
                    lblPrazo.Visible = false;
                }
            }  
        }

        //permite somente valores numérios e vírgula no campo de texto de preço
        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        //volta ao Menu Principal
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

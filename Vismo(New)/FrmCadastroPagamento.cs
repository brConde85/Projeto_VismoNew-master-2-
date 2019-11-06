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

        private void txtCod_Enter(object sender, EventArgs e)
        {
            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!txtValor.Text.Equals("") &&
                !txtCod.Text.Equals("") &&
                !txtDesc.Text.Equals("") &&
                !txtPrazo.Text.Equals(""))
            {
                try
                {
                    Pagamento pagamento = new Pagamento();

                    pagamento.Valor = txtValor.Text;
                    pagamento.fornecedor.CodigoF = Convert.ToInt32(txtCod.Text);
                    pagamento.Descricao = txtDesc.Text;

                    if (Convert.ToDateTime(txtPrazo.Text) > DateTime.Now)
                    {
                        pagamento.Validade = Convert.ToDateTime(txtPrazo.Text);

                        if (pagamento.Inserir() == 1)
                        {
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
                            MessageBox.Show("Falha ao registrar pagamento", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
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
                MessageBox.Show("Preencha todos os campos antes de continuar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

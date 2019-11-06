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
        Fornecedor fornecedor = new Fornecedor();
        public FrmNovoFornecedor()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            if (!txtNome.Text.Equals("")) //caso o campo dor preenchido
            {
                //mensagem de confirmação
                if (MessageBox.Show("Adicionar o fornecedor " + txtNome.Text
                     + " ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //atribui o valor da caixa de texto ao atributo de nome do fornecedor 
                        fornecedor.Nome = txtNome.Text;

                        //método Checa(), compara se o nome recebido já está nos registros do sistema
                        if (fornecedor.Checa() == 0)
                        {
                           
                            //caso não esteja é chamado o método Inserir(), que insere um novo registro
                            int x = fornecedor.Inserir();

                            if (x > 0) //o retorno do método Inserir() deve ser mais que 0 para o sucesso
                            {
                                MessageBox.Show("Fornecedor cadastrado com sucesso.");
                                txtNome.Text = "";
                            }
                        }
                        else
                        {
                            //caso o nome já estiver nos registros
                            MessageBox.Show("Erro, fornecedor já cadastrado.");
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


        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

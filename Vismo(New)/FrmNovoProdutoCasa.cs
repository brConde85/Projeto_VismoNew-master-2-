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
    public partial class FrmNovoProdutoCasa : Form
    {
        Produto produto = new Produto();
        public FrmNovoProdutoCasa()
        {
            InitializeComponent();
        }
         
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {           
            //caso todos os campos forem preenchidos
            if (!txtNome.Text.Equals("") &&
                !txtPreco.Text.Equals("") &&
               (!cboPalavra.Text.Equals("")))
            {
                try
                {
                    //atribuição dos compos do formulário para os atributos do produto
                    produto.Nome = txtNome.Text;
                    produto.Preco = Convert.ToDouble(txtPreco.Text);
                    produto.Pchave = cboPalavra.Text;
                   
                    //chamada do método Inserir(), que insere os registros no banco
                    int x = produto.InserirProdutoCasa();

                    if (x > 0) //o retorno do método deve ser maior que 0 para sucesso
                    {
                        MessageBox.Show("Produto cadastrado com sucesso.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtPreco.Clear();
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

        private void FrmNovoProdutoCasa_Load(object sender, EventArgs e)
        {
            cboPalavra.SelectedIndex = 0;
        }
    }
}

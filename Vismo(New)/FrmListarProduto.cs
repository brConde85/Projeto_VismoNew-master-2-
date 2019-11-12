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
    public partial class FrmListarProduto : Form
    {
        Produto produto = new Produto();

        //Preenche o datagrid quando o form for aberto 
        public FrmListarProduto()
        {
            InitializeComponent();
           
            ListarGrid();
        }

        //Ação para abrir form de atualização de produto
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double preco = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int qtd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int fornec = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            string pchave = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            FrmAtualizarProduto tela = new FrmAtualizarProduto(id, nome, preco, qtd, fornec, pchave);
            tela.Show();
        }

        //Para carregar o datagrid ao entrar no form
        private void ListarGrid()
        {
            try
            {
               dataGridView1.AutoGenerateColumns = false;

               dataGridView1.DataSource = produto.ListarDataGrid();
               
               dataGridView1.DataMember = produto.ListarDataGrid().Tables[0].TableName;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos","Erro"+ MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }

        //Ação de excluir produto
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            try  //Tenta fazer algo (executar qualquer sequência de código), se não der certo
            {
                // chamando metodo para apagar produto
                if (produto.DelProd() == 1)
                {
                    MessageBox.Show("Produto removido", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
             catch (Exception ex) //Entra no catch (tratamento do erro) e o programa não fecha 
            //Quando o erro acontecer um objeto da classe Exception vai armazenar as informações do erro
            {
                MessageBox.Show("Falha no sistema: " + ex.Message);  //Atributo que descreve a falha que aconteceu
                //return 0;
            }

            // exibindo o nome capturado pelo usuario
            MessageBox.Show("Você escolheu a receita: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " ID: " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}


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
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            //produto.UpdateProduto();
        }
        private void ListarGrid()
        {
            try
            {
               dataGridView1.AutoGenerateColumns = false;

               dataGridView1.DataSource = produto.ListarDataGrid();
               
               dataGridView1.DataMember = produto.ListarDataGrid().Tables[0].TableName;
               
               //dataGridView1.Rows[0].Cells[0].Value = produto.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos","Erro"+ MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }

        private void FrmListarProduto_Load(object sender, EventArgs e)
        {
            ListarGrid();            
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            //.CurrentRow.Cells[0].Value.ToString();
            //this.DataGridView.Rows[ IndiceDaLinha ].Cells[ IndiceDaCelula ].Value.ToString();
            produto.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DelProd();// chamando metodo para apagar produto
            
        }
        public void DelProd()
        {

            try  //Tenta fazer algo (executar qualquer sequência de código), se não der certo
            {

                //URL de conexão
                string connectionString = @"Data Source=BRCONDE\SQLEXPRESS;Initial Catalog=db_loja;Integrated Security=True;";
                //Se tivesse senha "...Password = 123456"
                SqlConnection connection = new SqlConnection(connectionString);  //Conectando o Projeto ao BD
                connection.Open();  //Abrindo a conexão com o MySQL
                SqlCommand comandoDelete = connection.CreateCommand();  //Criando um comando 
                                                                        //Colocando o método para linkar o database e a ide
                                                                        // selecionando a coluna do datagrid que sera capturada pelo atributo

                string delete = "DELETE FROM produto where codigo ='" + produto.Id + "';";

                //MessageBox.Show(delete);  //Exibindo o que acabei de update
                comandoDelete.CommandText = delete; //Setar a query dentro do comando (extração de informações)
                comandoDelete.ExecuteNonQuery();  //<---Executar a query e retorna a quantidade de linhas afetadas
                connection.Close();
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


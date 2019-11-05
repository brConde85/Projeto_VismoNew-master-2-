using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control
{
    public class Venda
    {
        // atributo venda
        private int codigo;
        private DateTime data;
        private double valor;

        // Gette e Setter
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO venda ([datas], [valor])" +
                    " VALUES (@data, @valor)";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                cn.Parameters.Add("valor", SqlDbType.Float).Value = valor;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        public void PegaId()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM venda WHERE datas = @data";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    codigo = reader.GetInt32(0);
                }
            }
        }

        public int Confirma()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM venda WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return 1; 
                }

                return 0;
            }
        }
        public void CancelarVenda(string venda)
        {
            using (SqlConnection con = new SqlConnection())
            {                
                con.ConnectionString = Properties.Settings.Default.banco;
                con.Open();
                SqlCommand cn = con.CreateCommand();                                
               
                cn.CommandText = venda;                
                cn.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo;               
                
                cn.ExecuteNonQuery();
                con.Close();
            }
        }
        public void CancelarProdutoVenda(string vendaProduto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                con.Open();
                SqlCommand cn = con.CreateCommand();

                cn.CommandText = vendaProduto;
                cn.Parameters.Add("@codigoVenda", SqlDbType.Int).Value = Codigo;
                

                cn.ExecuteNonQuery();
                con.Close();
            }
        }

        //SqlConnection connection = new SqlConnection(connectionString);  //Conectando o Projeto ao BD
        //connection.Open();  //Abrindo a conexão com o MySQL
        //        SqlCommand comandoDelete = connection.CreateCommand();  //Criando um comando 
        //                                                                //Colocando o método para linkar o database e a ide
        //                                                                // selecionando a coluna do datagrid que sera capturada pelo atributo

        //string delete = "DELETE FROM produto where codigo ='" + produto.Codigo + "';";
        //string deletePV = " DELETE FROM dbo.produto_venda where codigoProduto ='" + produto.Codigo + "';";

        ////MessageBox.Show(delete);  //Exibindo o que acabei de update
        //comandoDelete.CommandText = deletePV; //Setar a query dentro do comando (extração de informações)                
        //        comandoDelete.CommandText = delete; //Setar a query dentro do comando (extração de informações)
        //        comandoDelete.ExecuteNonQuery();  //<---Executar a query e retorna a quantidade de linhas afetadas
        //        connection.Close();
        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM venda";
                
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

    }
}

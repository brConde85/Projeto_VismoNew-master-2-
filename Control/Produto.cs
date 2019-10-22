using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization; // para exibir valores monetarios

namespace Control
{
    public class Produto
    {
        //atributos produto
        private int codProduto;
        private string nomeProduto;
        private double preco;
        private int qtdEstoque;
        private string pchave;

        public Fornecedor fornecedor;

        public Produto()
        {
            fornecedor = new Fornecedor();
        }

        // getter e setter produto

        public int Codigo
        {
            get
            {
                return codProduto;
            }

            set
            {
                codProduto = value;
            }
        }

        public string Nome
        {
            get
            {
                return nomeProduto;
            }

            set
            {
                nomeProduto = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int QtdEstoque
        {
            get
            {
                return qtdEstoque;
            }

            set
            {
                qtdEstoque = value;
            }
        }

        public string Pchave
        {
            get
            {
                return pchave;
            }

            set
            {
                pchave = value;
            }
        }


        //métodos
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Produto ([nome], [preco], [qtdEstoque], [codFornecedor], [pchave])" +
                    " VALUES (@nome, @preco, @qtdEstoque, @codFornecedor, @pchave)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nomeProduto;
                cn.Parameters.Add("preco", SqlDbType.Money).Value = preco;
                cn.Parameters.Add("qtdEstoque", SqlDbType.Int).Value = qtdEstoque;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Parameters.Add("pchave", SqlDbType.VarChar).Value = pchave;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }
        public int Update()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                /*  UPDATE DEPARTAMENTO
                    SET SALARIO = 1000
                    WHERE CODIGODEP = 1
                    codigo = 
                 */
                cn.CommandText = ("UPDATE produto SET nome = @nome, preco = @preco, " +
                    "qtdEstoque = @qtdEstoque, codFornecedor = @codFornecedor, pchave = @pchave " +
                    "WHERE codigo = @codigo");

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codProduto;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nomeProduto;
                cn.Parameters.Add("preco", SqlDbType.Money).Value = preco;
                cn.Parameters.Add("qtdEstoque", SqlDbType.Int).Value = qtdEstoque;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Parameters.Add("pchave", SqlDbType.VarChar).Value = pchave;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }


        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Produto WHERE codigo = @codProduto";
                cn.Parameters.Add("codProduto", SqlDbType.Int).Value = codProduto;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }
        public DataSet ListarDataGrid()
        {
            Fornecedor fornecedor = new Fornecedor();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand("SELECT * FROM produto;");
                cn.CommandType = CommandType.Text;

                con.Open();
                //cn.CommandText = "SELECT * FROM produto;";

                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                //SqlDataReader dr;

                //dr = cn.ExecuteReader();
                /*private SqlConnection conexao = new SqlConnection("strConection");

                  conexao.Open();

                  //criando o select e o objeto de consulta
                  string sql = "select * from clientes";
                  SqlCommand cmd = new SqlCommand(sql, conexao);
                  cmd.Connection = conexao;
                  cmd.CommandText = sql;
  
                  // cria o dataadapter...
                  SqlDataAdapter adapter = new SqlDataAdapter();
                  adapter.SelectCommand = cmd;

                  // preenche o dataset...
                  DataSet dataSet = new DataSet();
                  adapter.Fill(dataSet);

                  dataGridView1.DataSource = dataSet;
                  dataGridView1.DataMember = dataSet.Tables[0].TableName;
                  conexao.Close();
                 */

                //if (dr.HasRows)
                //{
                //    //dr.Read();

                //    while (dr.Read())
                //    {
                        //codProduto = dr.GetInt32(0);
                        //Id = Convert.ToInt32(dr["codigo"]);
                        //Nome = Convert.ToString(dr["nome"]);
                        //Preco = Convert.ToDouble(dr["preco"]);
                        //QtdEstoque = Convert.ToInt32(dr["qtdEstoque"]);
                        //fornecedor.Codigo = Convert.ToInt32(dr["codFornecedor"]);
                        //Pchave = Convert.ToString(dr["pchave"]);

                //    }
                //    con.Close();
                //}
                return dataSet;
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
                cn.CommandText = "SELECT codigo FROM Produto WHERE codigo = @codProduto";
                cn.Parameters.Add("codProduto", SqlDbType.Int).Value = codProduto;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    codProduto = reader.GetInt32(0);
                }
            }
        }

        public int NovaQtd(int x)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Produto SET qtdEstoque -=" + x + "WHERE codigo = @codProduto";
                cn.Parameters.Add("codProduto", SqlDbType.Int).Value = codProduto;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }
        public int UpdateProduto(int cod)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Produto SET nome = " + cod + " WHERE codigo = @codProduto";
                cn.Parameters.Add("codProduto", SqlDbType.Int).Value = codProduto;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }


        }

    }
}

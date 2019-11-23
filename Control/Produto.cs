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
        //atributos
        private int codigo;
        private string nome;
        private double preco;
        private int qtdEstoque;
        private string pchave;
        private string status;


        //relacionamento com a classe Fornecedor
        public Fornecedor fornecedor;

        public Produto()
        {
            status = "Habilitado";

            //instânciamento da classe relacionada
            fornecedor = new Fornecedor();
        }


        //encapsulamento de atributos da classe
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
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

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }


        //métodos

        //insere um novo produto
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Produto VALUES (@nome, @preco, @qtdEstoque, @codFornecedor, @pchave, @status)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("preco", SqlDbType.Money).Value = preco;
                cn.Parameters.Add("qtdEstoque", SqlDbType.Int).Value = qtdEstoque;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Parameters.Add("pchave", SqlDbType.VarChar).Value = pchave;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        public int MudaStatus()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Produto SET status = 'Desabilitado' " +
                    "WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        public int InserirProdutoCasa()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO produtoCasa ([nome], [preco], [pChave])" +
                    " VALUES (@nome, @preco, @pChave)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("preco", SqlDbType.Money).Value = preco;
                cn.Parameters.Add("pChave", SqlDbType.VarChar).Value = pchave;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //atualiza o produto
        public int Update()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Produto SET nome = @nome, preco = @preco, " +
                    "qtdEstoque = @qtdEstoque, codFornecedor = @codFornecedor, pchave = @pchave " +
                    "WHERE codigo = @codigo";

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("preco", SqlDbType.Money).Value = preco;
                cn.Parameters.Add("qtdEstoque", SqlDbType.Int).Value = qtdEstoque;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Parameters.Add("pchave", SqlDbType.VarChar).Value = pchave;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //faz a listagem de produtos registrados
        public DataSet ListarDataGrid()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Produto ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        //faz a listagem de produto contido em Produtos da Casa
        public DataSet ListarProdCasa(string nome)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM dbo.produtoCasa WHERE lower(nome) like lower('%" + nome + "%') " +
                    "ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return dataSet;
                }
                con.Close();
                return null;
            }
        }

        //faz a listagem de produto por ID
        public DataSet Listar1()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Produto WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nome = reader.GetString(1);
                        preco = reader.GetDouble(2);
                        qtdEstoque = reader.GetInt32(3);
                        fornecedor.CodigoF = reader.GetInt32(4);
                        pchave = reader.GetString(5);
                        status = reader.GetString(6);
                    }

                    return dataSet;
                }

                return null;
            }
        }

        //faz a listagem de produto por nome
        public DataSet Listar2(string nome)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM produto WHERE lower(nome) like lower('%"+ nome +"%') " +
                    "ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return dataSet;
                }

                return null;
            }
        }

        //faz a listagem de produtos por tipo
        public DataSet Listar3()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Produto WHERE pchave = @pchave ORDER BY nome";
                cn.Parameters.Add("pchave", SqlDbType.NVarChar).Value = pchave;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return dataSet;
                }

                return null;
            }
        }

        //faz a listagem de produtos por tipo e nome
        public DataSet Listar4(string nome)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM produto WHERE lower(nome) like lower('%" + nome + "%') " +
                    "AND pchave = @pchave ORDER BY nome";
                cn.Parameters.Add("pchave", SqlDbType.NVarChar).Value = pchave;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return dataSet;
                }

                return null;
            }
        }

        //atualiza a quantidade de produto em estoque
        public int NovaQtd(int x)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Produto SET qtdEstoque -=" + x + "WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //faz a listagem de produtos que estão em sua quantidade de estoque igual ou inferior a 10
        public DataSet Pedido()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT t1.*, t2.nome AS nomeFornec FROM Produto t1, Fornecedor t2 " +
                "WHERE t1.codFornecedor = t2.codFornecedor AND t1.qtdEstoque <= 10 ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        //faz a listagem de produtos mais vendidos em um intervalo de tempo
        public DataSet MaisVendidos(int a, int b)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT t1.codigoProduto, t2.nome, SUM(t1.quantidade) AS quantidadeVendida " +
                "FROM produto_venda t1, produto t2, venda t3 WHERE " +
                "t1.codigoProduto = t2.codigo AND t3.codigo = t1.codigoVenda AND MONTH(t3.datas)BETWEEN "+ a +" AND "+ b +" " +
                "GROUP BY t1.codigoProduto, t2.nome " +
                "ORDER BY quantidadeVendida DESC;";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        //remove um produto dos registros
        public int DelProd()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                string delete = "DELETE FROM Produto where codigo = @codigo";
                string deletePV = " DELETE FROM produto_venda where codigoProduto = @codigo";

                cn.CommandText = deletePV; //Setar a query dentro do comando (extração de informações)  
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;

                cn.CommandText = delete; //Setar a query dentro do comando (extração de informações)
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;

                return cn.ExecuteNonQuery();  //<---Executar a query e retorna a quantidade de linhas afetadas
            } 
        }

        public int Busca()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM Produto WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return 1;
                }

                return 0;
            }
        }
    }
}

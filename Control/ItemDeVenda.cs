using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control
{
    public class ItemDeVenda
    {
        //atributos
        private int idVenda;
        private int idProduto;
        private int idProdCasa;
        private int qtd;


        //relacionamento com a classe Venda
        public Venda venda;

        public ItemDeVenda()
        {
            //instânciamento da classe relacionada
            venda = new Venda();
        }


        //encapsulamento de atributos da classe
        public int IdVenda
        {
            get
            {
                return idVenda;
            }
            set
            {
                idVenda = value;
            }
        }

        public int IdProduto
        {
            get
            {
                return idProduto;
            }
            set
            {
                idProduto = value;
            }
        }

        public int IdProdCasa
        {
            get
            {
                return idProdCasa;
            }
            set
            {
                idProdCasa = value;
            }
        }

        public int Qtd
        {
            get
            {
                return qtd;
            }
            set
            {
                qtd = value;
            }
        }


        //métodos

        //realiza listagem do registro de vendas
        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT t1.codigoVenda AS codigo, t1.codigoProduto, t1.quantidade, t2.nome, t3.datas, t3.valor " +
                    "FROM produto_venda t1, Produto t2, Venda t3 " +
                    "WHERE t1.codigoProduto = t2.codigo AND t1.codigoVenda = @codigo AND t3.codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = venda.Codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        //insere um item de venda para um produto com quantidade em estoque
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO produto_venda ([codigoProduto], [codigoVenda], [quantidade])" +
                    "VALUES (@idProduto, @idVenda, @qtd)";
                cn.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
                cn.Parameters.Add("idVenda", SqlDbType.Int).Value = idVenda;
                cn.Parameters.Add("qtd", SqlDbType.Int).Value = qtd;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //insere um item de venda para um produto da casa
        public int Inserir2()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO produto_venda ([codigoVenda], [quantidade], [codigoProdCasa])" +
                    "VALUES (@idVenda, @qtd, @idProdCasa)";
                cn.Parameters.Add("idVenda", SqlDbType.Int).Value = idVenda;
                cn.Parameters.Add("qtd", SqlDbType.Int).Value = qtd;
                cn.Parameters.Add("idProdCasa", SqlDbType.Int).Value = idProdCasa;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //remove registro de um item de venda
        public void CancelarProdutoVenda()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                con.Open();
                SqlCommand cn = con.CreateCommand();

                cn.CommandText = "DELETE FROM produto_venda WHERE codigoVenda = @codigoVenda";
                cn.Parameters.Add("@codigoVenda", SqlDbType.Int).Value = idVenda;

                cn.ExecuteNonQuery();
                con.Close();
            }
        }

        public int Busca()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                con.Open();
                SqlCommand cn = con.CreateCommand();

                cn.CommandText = "SELECT codigoProduto FROM produto_venda WHERE codigoProduto = @codigo";
                cn.Parameters.Add("@codigo", SqlDbType.Int).Value = idProduto;

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
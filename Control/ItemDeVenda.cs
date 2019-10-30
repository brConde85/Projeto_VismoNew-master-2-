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
        private int idVenda;
        private int idProduto;
        private int qtd;

        public Venda venda;

        public ItemDeVenda()
        {
            venda = new Venda();
        }

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

        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT t1.*, t2.nome, t3.datas FROM produto_venda t1, Produto t2, Venda t3 " +
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
    }
}
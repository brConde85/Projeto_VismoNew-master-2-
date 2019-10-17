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
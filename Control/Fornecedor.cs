using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Control
{
   public class Fornecedor
    {
        // atributos fornecedor
        private int id;
        private string nomeFornecedor;

        //Getter e setter fornecedor
      
        public int Codigo
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nomeFornecedor;
            }

            set
            {
                nomeFornecedor = value;
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
                cn.CommandText = "INSERT INTO Fornecedor ([nome]) VALUES (@nome)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nomeFornecedor;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        public int Checa()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Fornecedor WHERE nome = @nome";
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = Codigo;
                cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = nomeFornecedor;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    Codigo = reader.GetInt32(0);

                    return 1;
                }

                return 0;
            }
        }
    }
}

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
      
        public int CodigoF
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

        public void PegaNome()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT nome FROM Fornecedor WHERE codFornecedor = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    nomeFornecedor = reader.GetString(0);
                }
            }
        }

        public int PegaId()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codFornecedor FROM Fornecedor WHERE codFornecedor = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);

                    return 1;
                }

                return 0;
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
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = id;
                cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = nomeFornecedor;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    CodigoF = reader.GetInt32(0);

                    return 1;
                }

                return 0;
            }
        }

        public DataSet ListarDataGrid()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Fornecedor ORDER BY nome";
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

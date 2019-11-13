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
        //atributos
        private int id;
        private string nomeFornecedor;


        //encapsulamento de atributos da classe
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

        //insere um novo fornecedor
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

        //confere se ID de fornecedor inrofmado é existente nos registros
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

        //confere se nome de fornecedor inrofmado é existente nos registros
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

        //realiza a listagem de funcionários registrados
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

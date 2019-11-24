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
        private int codigo;
        private string nome;
        private string status;

        public Fornecedor()
        {
            status = "Habilitado";
        }


        //encapsulamento de atributos da classe
        public int CodigoF
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

        //insere um novo fornecedor
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Fornecedor VALUES (@nome, @status)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
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
                cn.CommandText = "SELECT codFornecedor FROM Fornecedor WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    codigo = reader.GetInt32(0);

                    return 1;
                }

                return 0;
            }
        }

        public int MudaStatus(string status)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Fornecedor SET status = '"+ status +"' " +
                    "WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //faz uma busca de fornecedor por nome
        public DataSet ListarNome(string comando)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = comando;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
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
                cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = nome;
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

        //atualiza o registro de um fornecedor
        public int Atualizar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Fornecedor SET nome = @nome WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = nome;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //realiza a listagem de funcionários registrados
        public DataSet ListarDataGrid(string comando)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = comando;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public int Remover()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "DELETE FROM Fornecedor WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                return cn.ExecuteNonQuery(); 
            }
        }

        public int PegaNome()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT nome, status FROM Fornecedor WHERE codFornecedor = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nome = reader.GetString(0);
                        status = reader.GetString(1);
                    }
                   
                    return 1;
                }

                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Control
{    
    public class Funcionario
    {
        //atributos
        private string nome;
        private string cpf;
        private string login;
        private string senha;
        private string senhaAux;
        private string status;
        private string tipo;


        //encapsulamento de atributos da classe
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

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string SenhaAux
        {
            get
            {
                return senhaAux;
            }

            set
            {
                senhaAux = value;
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

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }


        //métodos

        //insere um novo funcionário
        public int Inserir()
        {
            // instanciando sql connection para abrir uma conexão
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                // abrindo conexão com o banco                
                con.Open();
                cn.CommandText = "INSERT INTO funcionario ([logins],[senha],[nome],[cpf],[statuss],[tipo]) VALUES (@logins, @senha,@nome,@cpf,@statuss,@tipo)";
                cn.Parameters.Add("logins", SqlDbType.VarChar).Value = login;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = senha;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = cpf;
                cn.Parameters.Add("statuss", SqlDbType.VarChar).Value = status;
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = tipo;

                // Abrindo uma outra conexção
                cn.Connection = con;

                // retornando o execute 
                return cn.ExecuteNonQuery();
            }
        }

        //verifica login e senha informados para realizar Login
        public bool VerificarLogin()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                // procurando senha e login no banco
                cn.CommandText = "SELECT * FROM funcionario WHERE logins = @login AND senha = @senha";
                // utlizado para subistituir os paramentros por parametros que temos que enviar
                cn.Parameters.AddWithValue("login", login);
                cn.Parameters.AddWithValue("senha", senha);

                // metodo que abre a conexão
                cn.Connection = con;
                // para executar a linha sem trazer informação e guardala

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)// verificar se foi encontrado a informação com o banco
                {
                    // para verificar ate chegar na linha afetada para capturar o tipo
                    while (reader.Read())
                    {
                        Tipo = reader.GetString(6);
                    }

                    return true;
                }

                return false;
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
                cn.CommandText = "SELECT * FROM Funcionario ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        //busca o status e nome do funcionário logado
        public void PegaStatus()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
               
                con.Open();
                cn.CommandText = "SELECT statuss, nome FROM funcionario WHERE logins = @login AND senha = @senha";
                cn.Parameters.Add("login", SqlDbType.VarChar).Value = login;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = senha;
 
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    status = reader.GetString(0);
                    nome = reader.GetString(1);
                }
            }
        }

        //altera o status do funcionário logado
        public int AlteraStatus(int num)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Funcionario set statuss = '" + num + "' WHERE logins = @login " +
                    "AND senha = @senha";
                cn.Parameters.AddWithValue("@login", login);
                cn.Parameters.AddWithValue("@senha", senha);

                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }    
        }
    }
}

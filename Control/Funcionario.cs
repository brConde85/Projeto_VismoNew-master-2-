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
        //atributos funcionario
        private int codigo;
        private string nome;
        private string cpf;
        private string login;
        private string senha;
        private string senhaAux;
        private string status;
        // metodo para acessar o sistema
        private bool confirmAcess = false;
        private bool confirmCadast;
        public string mensagemControle;
        public string mensagem = "";


        // getter's e setter's funcionario   
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                value = codigo;
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

        public bool ConfirmAcess
        {
            get
            {
                return confirmAcess;
            }

            set
            {
                confirmAcess = value;
            }
        }

        public bool ConfirmCadast
        {
            get
            {
                return confirmCadast;
            }

            set
            {
                confirmCadast = value;
            }
        }

        public string Tipo { get; set; }

        public Funcionario()
        {
            //conexão com o banco "Botão direito no banco de dados, propriedades e depois copiar cadeia de conxão "  
            con.ConnectionString = Properties.Settings.Default.banco;
        }

        // metodos de inserção no banco de dados
        public int Inserir(Funcionario objTabela)
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
                cn.Parameters.Add("logins", SqlDbType.VarChar).Value = objTabela.Login;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                cn.Parameters.Add("statuss", SqlDbType.VarChar).Value = objTabela.Status;
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = objTabela.Tipo;

                // Abrindo uma outra conexção
                cn.Connection = con;

                // retornando o execute 
                return cn.ExecuteNonQuery();
            }
        }

      

        // confirmação de acesso
        public bool Acessar (String login, String senha)
        {
            // se a mensagem não ficar vazia houve um erro de login
            if (!mensagem.Equals(""))
            {
                this.mensagem = mensagemControle;
            }
            return ConfirmAcess = VerificarLogin(login, senha); 
        }
        // verifica se o login existe no banco
        SqlCommand cmd = new SqlCommand(); // comando sql para procurar no banco 

        SqlDataReader dr;
        public bool VerificarLogin(String login, String senha)
        {
            // procurando senha e login no banco
            cmd.CommandText = "SELECT * FROM funcionario WHERE logins = @login AND senha = @senha";
            // utlizado para subistituir os paramentros por parametros que temos que enviar
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                // metodo que abre a conexão
                cmd.Connection = conectar();
                // para executar a linha sem trazer informação e guardala
                dr = cmd.ExecuteReader();
                if (dr.HasRows)// verificar se foi encontrado a informação com o banco
                {
                    // para verificar ate chegar na linha afetada para capturar o tipo
                    while (dr.Read())
                    {
                        Tipo = dr.GetString(6);
                    }

                    ConfirmCadast = true;
                }
            }
            catch (SqlException)
            {

                this.mensagemControle = "Erro com Banco de Dados!";
            }
            return ConfirmCadast;
        }
        
        // metodo para conferencia no banco
        SqlConnection con = new SqlConnection();
        
        // metoda para conferir se a conexão do cliente
        public SqlConnection conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
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
                cn.CommandText = "SELECT * FROM Funcionario ORDER BY nome";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public void PegaStatus()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
               
                con.Open();
                cn.CommandText = "SELECT statuss FROM funcionario WHERE logins = @login AND senha = @senha";
                cn.Parameters.Add("login", SqlDbType.VarChar).Value = login;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = senha;
 
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    status = reader.GetString(0);
                }
            }
        }

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

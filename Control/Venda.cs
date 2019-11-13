using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control
{
    public class Venda
    {
        //atributos
        private int codigo;
        private DateTime data;
        private double valor;


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

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        

        //métodos

        //insere um registro de venda
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO venda ([datas], [valor])" +
                    " VALUES (@data, @valor)";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                cn.Parameters.Add("valor", SqlDbType.Float).Value = valor;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

        //busca um código de uma venda baseado em uma data informada 
        public void PegaId()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM venda WHERE datas = @data";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    codigo = reader.GetInt32(0);
                }
            }
        }

        //confirma se código de venda informado está nos registros
        public int Confirma()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM venda WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return 1; 
                }

                return 0;
            }
        }

        //realiza cancelamento de venda
        public void CancelarVenda()
        {
            using (SqlConnection con = new SqlConnection())
            {                
                con.ConnectionString = Properties.Settings.Default.banco;
                con.Open();
                SqlCommand cn = con.CreateCommand();                                
               
                cn.CommandText = "DELETE FROM venda WHERE codigo = @codigo";                
                cn.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo;               
                
                cn.ExecuteNonQuery();
                con.Close();
            }
        }

        //faz a listagem de vendas registradas
        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Venda";

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

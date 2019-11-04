using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control
{
    public class Pagamento
    {
        //atributos pagamento
        private int codPagamento;
        private string descricao;
        private DateTime validade;
        private string valor;
        private string situacao; 

        public Fornecedor fornecedor;

        public Pagamento()
        {
            situacao = "Pendente";

            fornecedor = new Fornecedor();
        }

        // Getter e setter pagamento
        public int CodPagamento
        {
            get
            {
                return codPagamento;
            }

            set
            {
                codPagamento = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public DateTime Validade
        {
            get
            {
                return validade;
            }

            set
            {
                validade = value;
            }
        }

        public string Valor
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

        public string Situacao
        {
            get
            {
                return situacao;
            }
            set
            {
                situacao = value;
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
                cn.CommandText = "INSERT INTO Pagamento VALUES (@valor, @descricao, @validade, @situacao, @codFornecedor)";
                cn.Parameters.Add("valor", SqlDbType.NVarChar).Value = valor;
                cn.Parameters.Add("descricao", SqlDbType.NVarChar).Value = descricao;
                cn.Parameters.Add("validade", SqlDbType.Date).Value = validade;
                cn.Parameters.Add("situacao", SqlDbType.NVarChar).Value = situacao;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }

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

        public void Atualiza()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Pagamento SET situacao = 'Atrasado' WHERE validade < GETDATE() AND situacao != 'Realizado com atraso'";
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
            }
        }

        public void AtualizaPagamento(string comando)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = comando;
                cn.Parameters.Add("codPagamento", SqlDbType.Int).Value = codPagamento;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);                             
            }
        }
    }
}


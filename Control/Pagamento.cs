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

        public Fornecedor fornecedor;

        public Pagamento()
        {
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

        //métodos
        public int Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Pagamento VALUES (@valor, @descricao, @validade, @codFornecedor)";
                cn.Parameters.Add("valor", SqlDbType.NVarChar).Value = valor;
                cn.Parameters.Add("descricao", SqlDbType.NVarChar).Value = descricao;
                cn.Parameters.Add("validade", SqlDbType.Date).Value = validade;
                cn.Parameters.Add("codFornecedor", SqlDbType.Int).Value = fornecedor.CodigoF;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }
    }
}

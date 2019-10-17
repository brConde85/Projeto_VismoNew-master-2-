using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Pagamento
    {
        //atributos pagamento
        private int codPagamento;
        private string descricao;
        private DateTime validade;

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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ItemDeReposicao
    {
        // atributos item de reposição
        private int codItemReposicao;
        private DateTime dataItemReposicao;

        //Getter e setter item de reposição
        public int CodItemReposicao
        {
            get
            {
                return codItemReposicao;
            }

            set
            {
                codItemReposicao = value;
            }
        }

        public DateTime DataItemReposicao
        {
            get
            {
                return dataItemReposicao;
            }

            set
            {
                dataItemReposicao = value;
            }
        }

    }
}

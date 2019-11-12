using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vismo_New_
{
    public partial class FrmPedidoReposicao : Form
    {
        public FrmPedidoReposicao()
        {
            InitializeComponent();
        }

        // para carregar o datagrid ao entrar no form
        private void FrmPedidoReposicao_Load(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();

                dgPedido.AutoGenerateColumns = false;
                dgPedido.DataSource = produto.Pedido();
                dgPedido.DataMember = produto.Pedido().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

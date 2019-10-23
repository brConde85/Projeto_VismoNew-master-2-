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
    public partial class FrmListarFornecedor : Form
    {
        public FrmListarFornecedor()
        {
            InitializeComponent();
        }

        private void FrmListarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = fornecedor.ListarDataGrid();
                dataGridView1.DataMember = fornecedor.ListarDataGrid().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}

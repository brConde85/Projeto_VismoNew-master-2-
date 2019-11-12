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
    public partial class FrmListarFuncionario : Form
    {
        public FrmListarFuncionario()
        {
            InitializeComponent();
        }

        // Ação de preencher o datagrid ao entrar no form
        private void FrmListarFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = funcionario.ListarDataGrid();
                dataGridView1.DataMember = funcionario.ListarDataGrid().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}

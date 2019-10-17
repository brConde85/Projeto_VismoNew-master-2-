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
    public partial class FrmListarProduto : Form
    {
        Produto produto = new Produto();
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            produto.Update();
        }
        private void ListarGrid()
        {
            try
            {
               dataGridView1.AutoGenerateColumns = false;

               dataGridView1.DataSource = produto.ListarDataGrid();
               
               dataGridView1.DataMember = produto.ListarDataGrid().Tables[0].TableName;
               
               dataGridView1.Rows[0].Cells[0].Value = produto.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos","Erro"+ MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }

        private void FrmListarProduto_Load(object sender, EventArgs e)
        {
            ListarGrid();            
        }
    }
}

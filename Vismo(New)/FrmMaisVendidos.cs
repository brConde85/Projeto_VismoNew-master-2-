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
    public partial class FrmMaisVendidos : Form
    {
        public FrmMaisVendidos()
        {
            InitializeComponent();
        }

        private void FrmMaisVendidos_Load(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();

                dgVendidos.AutoGenerateColumns = false;
                dgVendidos.DataSource = produto.MaisVendidos();
                dgVendidos.DataMember = produto.MaisVendidos().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}

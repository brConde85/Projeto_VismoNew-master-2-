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
    public partial class FrmRegistroVenda : Form
    {
        public FrmRegistroVenda()
        {
            InitializeComponent();
        }

        private void BtnPenquisar_Click(object sender, EventArgs e)
        {
            if (!txtCod.Text.Equals(""))
            {
                ItemDeVenda item = new ItemDeVenda();

                item.venda.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    if (item.venda.Confirma() == 1)
                    {
                        dgVenda.AutoGenerateColumns = false;
                        dgVenda.DataSource = item.Listar();
                        dgVenda.DataMember = item.Listar().Tables[0].TableName;
                    }
                    else
                    {
                        dgVenda.DataSource = null;

                        MessageBox.Show("Registro de venda não encontrado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insira um código de venda para realizar uma pesquisa", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

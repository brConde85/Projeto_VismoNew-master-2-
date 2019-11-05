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
                        dgVenda.Columns["CodProduto"].Visible = true;
                        dgVenda.Columns["Produto"].Visible = true;
                        dgVenda.Columns["Quantidade"].Visible = true;
                        //dgVenda.Columns["CodVenda"].Visible = true;
                        dgVenda.Columns["Codigo"].Visible = false;
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

        private void BtnCanVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Codigo = Convert.ToInt32(dgVenda.CurrentRow.Cells[0].Value.ToString());

            MessageBox.Show("Id selecionado: " + dgVenda.CurrentRow.Cells[0].Value.ToString() +" foi apagado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            string comandoVenda = "DELETE FROM venda WHERE codigo = @codigo ;";
            string comandoProdVenda = "DELETE FROM produto_venda WHERE codigoVenda = @codigoVenda ;";


            //MessageBox.Show(Convert.ToString(venda.Codigo));
            venda.CancelarProdutoVenda(comandoProdVenda);
            venda.CancelarVenda(comandoVenda);
            dgVenda.DataSource = venda.Listar();
            dgVenda.DataMember = venda.Listar().Tables[0].TableName;

        }

        private void FrmRegistroVenda_Load(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            try
            {                       
                    dgVenda.AutoGenerateColumns = false;
                    dgVenda.DataSource = venda.Listar();
                    dgVenda.DataMember = venda.Listar().Tables[0].TableName;             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

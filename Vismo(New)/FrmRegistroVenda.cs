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

        // Ação para pesquisar uma venda com base em um código inserido 
        private void BtnPenquisar_Click(object sender, EventArgs e)
        {
            //compara se foi inserido um código de venda
            if (!txtCod.Text.Equals(""))
            {
                ItemDeVenda item = new ItemDeVenda();

                //guarda o código no atributo da classe Venda
                item.venda.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    //compara se código de venda é existente nos registros
                    if (item.venda.Confirma() == 1)
                    {
                        //altera modo de exibição do dataGrid
                        dgVenda.Columns["CodProduto"].Visible = true;
                        dgVenda.Columns["Produto"].Visible = true;
                        dgVenda.Columns["Quantidade"].Visible = true;                        
                        dgVenda.Columns["Codigo"].Visible = false;
                        dgVenda.AutoGenerateColumns = false;
                        dgVenda.DataSource = item.Listar();
                        dgVenda.DataMember = item.Listar().Tables[0].TableName;
                    }
                    else
                    {
                        //limpa o dataGrid
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
                //caso o código não for encontrado
                MessageBox.Show("Insira um código de venda para realizar uma pesquisa", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Ação para cancelamento de venda
        private void BtnCanVenda_Click(object sender, EventArgs e)
        {
            //mensagem de confirmação
            if (MessageBox.Show("Deseja realmente cancelar o registro de venda selecionado?", "Conformação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ItemDeVenda item = new ItemDeVenda();

                    //gurda o código da venda no atributo da classe Venda
                    item.venda.Codigo = Convert.ToInt32(dgVenda.CurrentRow.Cells[0].Value.ToString());

                    MessageBox.Show("ID selecionado: " + dgVenda.CurrentRow.Cells[0].Value.ToString() + " foi apagado!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //remove os registros da venda
                    item.CancelarProdutoVenda();
                    item.venda.CancelarVenda();

                    //atualiza o dataGrid
                    dgVenda.DataSource = item.venda.Listar();
                    dgVenda.DataMember = item.venda.Listar().Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Ação para preencher o datagrid ao ser carregado
        private void FrmRegistroVenda_Load(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            try
            {
                //preenche o dataGrid
                dgVenda.AutoGenerateColumns = false;
                dgVenda.DataSource = venda.Listar();
                dgVenda.DataMember = venda.Listar().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //guarda o código no atributo da classe Venda
            ItemDeVenda item = new ItemDeVenda();

            //gurda o código da venda no atributo da classe Venda
            item.venda.Codigo = Convert.ToInt32(dgVenda.CurrentRow.Cells[0].Value.ToString());

            try
            {
                //compara se código de venda é existente nos registros
                if (item.venda.Confirma() == 1)
                {
                    //altera modo de exibição do dataGrid
                    dgVenda.Columns["CodProduto"].Visible = true;
                    dgVenda.Columns["Produto"].Visible = true;
                    dgVenda.Columns["Quantidade"].Visible = true;
                    dgVenda.Columns["Codigo"].Visible = false;
                    dgVenda.AutoGenerateColumns = false;
                    dgVenda.DataSource = item.Listar();
                    dgVenda.DataMember = item.Listar().Tables[0].TableName;
                }
                else
                {
                    //limpa o dataGrid
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

        private void DgVenda_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            label3.Text = "Para detalhes de dois click's na venda desejada \n" +
                " ou informe o código para pesquisa.";
            label3.Visible = true;
        }

        private void DgVenda_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            label3.Text = "";
            label3.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmRegistroVenda tela = new FrmRegistroVenda();
            tela.Show();
        }
    }
    
}

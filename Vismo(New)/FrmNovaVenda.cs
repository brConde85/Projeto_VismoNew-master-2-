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
using System.Data.SqlClient;

namespace Vismo_New_
{
    public partial class frmNovaVenda : Form
    {
        Produto produto = new Produto();

        public frmNovaVenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtCod.Text.Equals(""))
            {
                //atribuição do campo de id ao atributo de id do produto
                produto.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    dataGridView2.AutoGenerateColumns = false;

                    //chamada do método de listagem de produto
                    dataGridView2.DataSource = produto.Listar1();
                    dataGridView2.DataMember = produto.Listar1().Tables[0].TableName;

                    if (dataGridView2.Rows[0].Cells[1].Value != null)
                    {
                        dataGridView2.Rows[0].Cells[0].Value = produto.Codigo;
                    }
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            else if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;

                try
                {
                    dataGridView2.AutoGenerateColumns = false;

                    //chamada do método de listagem de produto
                    dataGridView2.DataSource = produto.Listar2();
                    dataGridView2.DataMember = produto.Listar2().Tables[0].TableName;

                    if (dataGridView2.Rows[0].Cells[1].Value != null)
                    {
                        dataGridView2.Rows[0].Cells[0].Value = produto.Codigo;
                    }
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            else if (!cboPalavra.Text.Equals(""))
            {
                produto.Pchave = cboPalavra.Text;

                try
                {
                    dataGridView2.AutoGenerateColumns = false;

                    //chamada do método de listagem de produto
                    dataGridView2.DataSource = produto.Listar3();
                    dataGridView2.DataMember = produto.Listar3().Tables[0].TableName;

                    if (dataGridView2.Rows[0].Cells[1].Value != null)
                    {
                        dataGridView2.Rows[0].Cells[0].Value = produto.Codigo;
                    }
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[0].Value != null)
            {
                //compara se a quantidade em estoque do produto é maior que 0
                if (Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value) > 0)
                {
                    //compara se a o valor presente na caixa de texto de quantidade é maior que 0
                    if (Convert.ToInt32(txtQtd.Text) > 0)
                    {
                        //existe um campo no segundo datagrid que guarda a quantidade de peças de produtos que serão vendidas
                        if (Convert.ToInt32(txtQtd.Text) <= Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value))
                        {
                            //a variável "preco" recebe o valor do produto e é multiplicada pela quantidade que será vendida
                            double preco = Convert.ToDouble(dataGridView2.Rows[0].Cells[2].Value);
                            preco *= Convert.ToDouble(txtQtd.Text);

                            //a variável "soma" soma o valor presente no campo de Total com o preço do novo produto 
                            double soma = Convert.ToDouble(txtTotal.Text) + preco;
                            txtTotal.Text = soma.ToString("N2");

                            //adiciona um campo vazio no datagrid responsável por guardar os registros da venda
                            dataGridView1.RowCount += 1;

                            //preenchimento do segundo datagrid com o registro do produto adicionado
                            for (int i = 0; i < 5; i++)
                            {
                                dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[i].Value =
                                    dataGridView2.Rows[0].Cells[i].Value;
                            }
                            dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[5].Value = txtQtd.Text;

                            dataGridView2.Rows[0].Cells[3].Value = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value) - Convert.ToInt32(txtQtd.Text);
                            txtQtd.Text = "1"; //resseta a quantidade de produto a ser vendida

                            //txtRow é um texbox não visível que guarda o número de linhas existenes no segundo datagrig
                            int x = Convert.ToInt32(txtRow.Text) + 1;
                            txtRow.Text = Convert.ToString(x);
                        }
                        else
                        {
                            MessageBox.Show("Quantidade superior a presente em estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira uma quantidade válida antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //exibe mensagem caso o produto estiver em falta
                    MessageBox.Show("Produto em falta nos registros, não é possível adicioná-lo na fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtTotal.Text) == 0)
            {
                MessageBox.Show("Nenhum registro de produto encontrado", "Erro");
                txtPago.Text = "";
            }
            else
            {
                //calculo do troco da venda
                double x = Convert.ToDouble(txtPago.Text) - Convert.ToDouble(txtTotal.Text);

                txtTroco.Text = x.ToString("N2");

                if (x >= 0)
                {
                    txtTroco.BackColor = Color.White;
                    btnOk.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro de validação", "Erro");
                    txtTroco.BackColor = Color.Red;
                    btnOk.Enabled = false;
                }
            }

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value) != "X")
            {
                if (MessageBox.Show("Cancelar registro?",
                            "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //guarda o valor do preço do produto que será cancelado e sua quantidade
                    double preco = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                    int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
                    preco *= qtd;

                    //retira o registro do produto cancelado do segundo datagrig
                    for (int i = 0; i < 6; i++)
                    {
                        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value = "X";
                    }

                    //subtração do valor total da venda com o produto removido
                    double total = Convert.ToDouble(txtTotal.Text);
                    total -= preco;
                    txtTotal.Text = Convert.ToString(total);
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            for (int i = 0; i <= Convert.ToInt32(txtRow.Text) - 1; i++)
            {
                //atualizando a quantidade em estoque dos produtos
                produto.Codigo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                produto.NovaQtd(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
            }

            Venda venda = new Venda();

            venda.Data = DateTime.Now; //pega a data e hora em que foi realizado a venda
            venda.Valor = Convert.ToDouble(txtTotal.Text);

            try
            {
                if (venda.Inserir() == 1)
                {
                    venda.PegaId();

                    ItemDeVenda ivenda = new ItemDeVenda();
                    ivenda.IdVenda = venda.Codigo;

                    for (int i = 0; i <= Convert.ToInt32(txtRow.Text) - 1; i++)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) != "X")
                        {
                            ivenda.IdProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            ivenda.Qtd = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            ivenda.Inserir();
                        }
                        else
                        {
                            MessageBox.Show("ok");
                        }
                    }

                    MessageBox.Show("Venda realizada com sucesso.");

                    Close();
                    frmNovaVenda tela = new frmNovaVenda();
                    tela.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();

            FrmLogGerente tela = new FrmLogGerente();
            tela.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmRegistroVenda tela = new FrmRegistroVenda();
            tela.Show();
        }
    }
}

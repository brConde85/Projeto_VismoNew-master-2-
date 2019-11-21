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
    public partial class FrmNovaVenda : Form
    {
        Produto produto = new Produto();

        public FrmNovaVenda()
        {
            InitializeComponent();
        }

        //método usado para atualizar quantidade em estoque de produto conforme for adiconado na fila
        public void AtualizaQtd()
        {
            if (txtRow.Value != 0)
            {
                int aux = 0;
                int qtd;

                for (int i = 0; i < txtRow.Value; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) ==
                        Convert.ToString(dataGridView2.Rows[0].Cells[0].Value))
                    {
                        aux += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

                        if (i == txtRow.Value - 1)
                        {
                            qtd = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                            qtd -= aux;
                            dataGridView2.Rows[0].Cells[3].Value = qtd;
                        }
                    }
                }
            }
        }


        // Ação para pesquisar um produto já registrado
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            lblAdicionar.Visible = false;

            //compara se o nome informado está contido em Produto da Casa
            if (lblOpPesquisa.Text == "3")
            {
                if (!txtNome.Text.Equals(""))
                {
                    lblFalhaPesquisa3.Visible = false;

                    produto.Nome = txtNome.Text;

                    try
                    {
                        //chamada do método de listagem de produto
                        if (produto.ListarProdCasa(produto.Nome) != null)
                        {
                            lblFalhaPesquisa2.Visible = false;

                            dataGridView2.AutoGenerateColumns = false;

                            dataGridView2.DataSource = produto.ListarProdCasa(txtNome.Text);
                            dataGridView2.DataMember = produto.ListarProdCasa(txtNome.Text).Tables[0].TableName;   
                        }
                        else
                        {
                            dataGridView2.DataSource = null;

                            lblFalhaPesquisa2.Visible = true;
                        }

                        lblFalhaPesquisa1.Visible = false;
                    }

                    catch (Exception ex)
                    {
                        //exibe mensagem em caso de erro
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
                else
                {
                    lblFalhaPesquisa3.Visible = true;
                }
            }
            
            //compara se o ID de produto foi inserido
            else if (!txtCod.Text.Equals(""))
            {
                //atribuição do campo de id ao atributo de id do produto
                produto.Codigo = Convert.ToInt32(txtCod.Text);

                if (produto.Listar1() != null)
                {
                    try
                    {
                        lblFalhaPesquisa2.Visible = false;

                        dataGridView2.AutoGenerateColumns = false;

                        //chamada do método de listagem de produto
                        dataGridView2.DataSource = produto.Listar1();
                        dataGridView2.DataMember = produto.Listar1().Tables[0].TableName;

                        AtualizaQtd();
                    }

                    catch (Exception ex)
                    {
                        //exibe mensagem em caso de erro
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    dataGridView2.DataSource = null;

                    lblFalhaPesquisa2.Visible = true;
                }

                lblFalhaPesquisa1.Visible = false;
            }

            //pesquisa por nome de produto e palavra chave se ambos selecionados
            else if (!txtNome.Text.Equals("") && cboPalavra.Text.Equals(""))
            {
                try
                {
                    //chamada do método de listagem de produto
                    if (produto.Listar2(txtNome.Text) != null)
                    {
                        lblFalhaPesquisa2.Visible = false;

                        dataGridView2.AutoGenerateColumns = false;

                        dataGridView2.DataSource = produto.Listar2(txtNome.Text);
                        dataGridView2.DataMember = produto.Listar2(txtNome.Text).Tables[0].TableName;

                        AtualizaQtd();
                    }
                    else
                    {
                        dataGridView2.DataSource = null;

                        lblFalhaPesquisa2.Visible = true;
                    }

                    lblFalhaPesquisa1.Visible = false;
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            //pesquisa por nome de produto
            else if (!txtNome.Text.Equals("") && !cboPalavra.Text.Equals(""))
            {
                produto.Pchave = cboPalavra.Text;

                try
                {
                    //chamada do método de listagem de produto
                    if (produto.Listar4(txtNome.Text) != null)
                    {
                        lblFalhaPesquisa2.Visible = false;

                        dataGridView2.AutoGenerateColumns = false;

                        dataGridView2.DataSource = produto.Listar4(txtNome.Text);
                        dataGridView2.DataMember = produto.Listar4(txtNome.Text).Tables[0].TableName;

                        AtualizaQtd();
                    }
                    else
                    {
                        dataGridView2.DataSource = null;

                        lblFalhaPesquisa2.Visible = true;
                    }

                    lblFalhaPesquisa1.Visible = false;
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            //pesquisa por tipo de produto
            else if (!cboPalavra.Text.Equals("") && txtNome.Text.Equals(""))
            {
                produto.Pchave = cboPalavra.Text;

                try
                {
                    if (produto.Listar3() != null)
                    {
                        lblFalhaPesquisa2.Visible = false;

                        dataGridView2.AutoGenerateColumns = false;

                        //chamada do método de listagem de produto
                        dataGridView2.DataSource = produto.Listar3();
                        dataGridView2.DataMember = produto.Listar3().Tables[0].TableName;

                        AtualizaQtd();
                    }
                    else
                    {
                        dataGridView2.DataSource = null;

                        lblFalhaPesquisa2.Visible = true;
                    }

                    lblFalhaPesquisa1.Visible = false;
                }

                catch (Exception ex)
                {
                    //exibe mensagem em caso de erro
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            //caso não for inserido ID, nome ou tipo de produto
            else
            {
                dataGridView2.DataSource = null;

                lblFalhaPesquisa1.Visible = true;
                lblFalhaPesquisa2.Visible = false;
            }

        }

        // Ação para adicionar um produto na lista, a um segundo datagrid (automático)
        private void BtnAdicionar_Click(object sender, EventArgs e)
        { 
            if (dataGridView2.DataSource != null)
            {
                if (dataGridView2.RowCount > 1)
                {
                    MessageBox.Show("Mais de um produto encontrado.\nSelecione quais irão ser adicionados à fila", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // insere no datagrid1 os valores do datagrid2 que não precisaam de quantidade 
                    if (dataGridView2.Rows[0].Cells[3].Value == null)
                    {
                        //-----------------------------------------------
                        
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

                        dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[3].Value = "-";
                        dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[5].Value = txtQtd.Text;

                        //txtRow é um texbox não visível que guarda o número de linhas existenes no segundo datagrig
                        int x = Convert.ToInt32(txtRow.Text) + 1;
                        txtRow.Text = Convert.ToString(x);

                        //-------------------------------------------------------
                    }

                    //compara se a quantidade em estoque do produto é maior que 0
                    else if (Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value) > 0) // Aplicação não entra nesse bloco por causa do IF acima
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
                                for (int i = 0; i < 6; i++)
                                {
                                    if (i < 5)
                                    {
                                        dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[i].Value =
                                        dataGridView2.CurrentRow.Cells[i].Value;
                                    }
                                    else
                                    {
                                        dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[i].Value =
                                        txtQtd.Text;
                                    }
                                }

                                //txtRow é um texbox não visível que guarda o número de linhas existenes no segundo datagrid
                                int x = Convert.ToInt32(txtRow.Text) + 1;
                                txtRow.Text = Convert.ToString(x);

                                int aux;
                                int qtd = 0;

                                //atualiza a quantidade disponível de produto
                                for (int i = 0; i < txtRow.Value; i++)
                                {
                                    if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) ==
                                        Convert.ToString(dataGridView2.Rows[0].Cells[0].Value))
                                    {
                                        aux = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                                        qtd = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                                        qtd -= aux;  
                                    }
                                }

                                dataGridView2.Rows[0].Cells[3].Value = qtd;

                                txtQtd.Text = "1"; //resseta a quantidade de produto a ser vendida
                            }
                            else
                            {
                                MessageBox.Show("Quantidade superior a presente em estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insira uma quantidade válida antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //exibe mensagem caso o produto estiver em falta
                        MessageBox.Show("Produto em falta nos registros, não é possível adicioná-lo na fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }  
            }
            else
            {
                lblAdicionar.Visible = true;
            }
        }

        // Ação para adicionar um produto na lista, a um segundo datagrid (por clique de célula)
        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.DataSource != null)
            {
                // insere no datagrid2 os valores do datagrid1 que não precisaam de quantidade 
                if (dataGridView2.CurrentRow.Cells[3].Value == null)
                {
                    //a variável "preco" recebe o valor do produto e é multiplicada pela quantidade que será vendida
                    double preco = Convert.ToDouble(dataGridView2.CurrentRow.Cells[2].Value);
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
                            dataGridView2.CurrentRow.Cells[i].Value;
                    }

                    dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[3].Value = "-";
                    dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[5].Value = txtQtd.Text;

                    //txtRow é um texbox não visível que guarda o número de linhas existenes no segundo datagrig
                    int x = Convert.ToInt32(txtRow.Text) + 1;
                    txtRow.Text = Convert.ToString(x);
                }

                //compara se a quantidade em estoque do produto é maior que 0
                else if (Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value) > 0)
                {
                    //compara se a o valor presente na caixa de texto de quantidade é maior que 0
                    if (Convert.ToInt32(txtQtd.Text) > 0)
                    {
                        //existe um campo no segundo datagrid que guarda a quantidade de peças de produtos que serão vendidas
                        if (Convert.ToInt32(txtQtd.Text) <= Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value))
                        {
                            //a variável "preco" recebe o valor do produto e é multiplicada pela quantidade que será vendida
                            double preco = Convert.ToDouble(dataGridView2.CurrentRow.Cells[2].Value);
                            preco *= Convert.ToDouble(txtQtd.Text);

                            //a variável "soma" soma o valor presente no campo de Total com o preço do novo produto 
                            double soma = Convert.ToDouble(txtTotal.Text) + preco;
                            txtTotal.Text = soma.ToString("N2");

                            //adiciona um campo vazio no datagrid responsável por guardar os registros da venda
                            dataGridView1.RowCount += 1;

                            //preenchimento do segundo datagrid com o registro do produto adicionado
                            for (int i = 0; i < 6; i++)
                            {
                                if (i <= 4)
                                {
                                    dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[i].Value =
                                    dataGridView2.CurrentRow.Cells[i].Value;
                                }
                                else
                                {
                                    dataGridView1.Rows[Convert.ToInt32(txtRow.Text)].Cells[5].Value = txtQtd.Text;
                                }
                            }
               
                            //txtRow é um texbox não visível que guarda o número de linhas existenes no segundo datagrig
                            int x = Convert.ToInt32(txtRow.Text) + 1;
                            txtRow.Text = Convert.ToString(x);

                            int aux;
                            int qtd = 0;

                            //atualiza a quantidade disponível de produto
                            for (int i = 0; i < txtRow.Value; i++)
                            {
                                if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) ==
                                    Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value))
                                {
                                    aux = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                                    qtd = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
                                    qtd -= aux;
                                }
                            }

                            dataGridView2.CurrentRow.Cells[3].Value = qtd;

                            txtQtd.Text = "1"; //resseta a quantidade de produto a ser vendida
                        }
                        else
                        {
                            MessageBox.Show("Quantidade superior a presente em estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira uma quantidade válida antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //exibe mensagem caso o produto estiver em falta
                    MessageBox.Show("Produto em falta nos registros, não é possível adicioná-lo na fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblAdicionar.Visible = true;
            }
        }

        // Ação para validar venda
        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (!txtPago.Text.Equals(""))
            {
                pctExclamation.Visible = false;

                if (Convert.ToDouble(txtTotal.Text) == 0)
                {
                    MessageBox.Show("Nenhum registro de produto encontrado", "Erro");
                    txtPago.Text = "";
                }
                else
                {
                    double pago;

                    if (Double.TryParse(txtPago.Text, out pago) == true)
                    {
                        pctExclamation.Visible = false;
                        lblValor.Visible = false;

                        //calculo do troco da venda
                        double x = pago - Convert.ToDouble(txtTotal.Text);

                        txtTroco.Text = x.ToString("N2");

                        if (x >= 0)
                        {
                            txtTroco.BackColor = Color.White;
                            btnOk.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro de validação, valor informado menor \nque o total de compras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTroco.BackColor = Color.Red;
                            btnOk.Enabled = false;
                        }
                    }
                    else
                    {
                        pctExclamation.Visible = true;
                        lblValor.Visible = true;
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o valor a ser pago.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                pctExclamation.Visible = true;
                txtTroco.Text = null;
            }
        }

        // Ação para remover um produto inserido na lista
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Cancelar registro?",
                            "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //guarda o valor do preço do produto que será cancelado e sua quantidade
                double preco = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                int qtd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
                preco *= qtd;

                int x;
                int aux;

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value) ==
                        Convert.ToString(dataGridView2.Rows[i].Cells[0].Value))
                    {
                        x = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
                        aux = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value) + x;

                        dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value = aux;
                    }
                }

                dataGridView1.Rows.RemoveAt(e.RowIndex);
                txtRow.Value -= 1;

                //subtração do valor total da venda com o produto removido
                double total = Convert.ToDouble(txtTotal.Text);
                total -= preco;
                txtTotal.Text = Convert.ToString(total);
            }
        }

        // Ação para efetuar a venda 
        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int var = 0;

                for (int i = 0; i <= Convert.ToInt32(txtRow.Text) - 1; i++)
                {
                    var += 1;

                    Venda venda = new Venda();

                    venda.Data = DateTime.Now; //pega a data e hora em que foi realizado a venda
                    venda.Valor = Convert.ToDouble(txtTotal.Text);

                    if (venda.Inserir() == 1)
                    {
                        venda.PegaId();

                        ItemDeVenda ivenda = new ItemDeVenda();
                        ivenda.IdVenda = venda.Codigo;
                        ivenda.Qtd = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

                        if (Convert.ToString(dataGridView1.Rows[i].Cells[4].Value) != "Produto da casa")
                        {
                            ivenda.IdProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                            if (ivenda.Inserir() == 1)
                            {
                                Produto produto = new Produto();

                                //atualizando a quantidade em estoque dos produtos
                                produto.Codigo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                                if (Convert.ToString(dataGridView1.Rows[i].Cells[4].Value) != "Produto da casa")
                                {
                                    produto.NovaQtd(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                                }

                            }
                            else
                            {
                                MessageBox.Show("Erro ao concluir venda.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            ivenda.IdProdCasa = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);


                            if (ivenda.Inserir2() == 1)
                            {
                                Produto produto = new Produto();

                                //atualizando a quantidade em estoque dos produtos
                                produto.Codigo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                                if (Convert.ToString(dataGridView1.Rows[i].Cells[4].Value) != "Produto da casa")
                                {
                                    produto.NovaQtd(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                                }

                            }
                            else
                            {
                                MessageBox.Show("Erro ao concluir venda.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    if (i == Convert.ToInt32(txtRow.Text) - 1 && var > 0)
                    {
                        MessageBox.Show("Venda realizada com sucesso.");

                        Close();

                        FrmNovaVenda tela = new FrmNovaVenda();
                        tela.Show();
                    }
                }

                if (var == 0)
                {
                    MessageBox.Show("A fila está vazia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        // Ação para voltar ao Menu Principal
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar tela de venda e voltar ao Menu Principal?", "Confirmação",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }  
        }

        // Ação para abrir o registro de venda para o cancelamento de uma venda 
        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRegistroVenda tela = new FrmRegistroVenda();
            tela.Show();
        }

        // Ações das teclas de atalho
        private void FrmNovaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Q)
            {
                BtnPesquisar_Click(sender, e);
            }

            if (e.Control == true && e.KeyCode == Keys.W)
            {
                BtnAdicionar_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                BtnValidar_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.R)
            {
                if (btnOk.Enabled == true)
                {
                    BtnOk_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir a venda", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (e.Control == true && e.KeyCode == Keys.T)
            {
                BtnRelatorio_Click(sender, e);
            }
        }


        // Tratamento das caixas de texto 
        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnPesquisar_Click(sender, e);
            }
        }

        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnPesquisar_Click(sender, e);
            }
        }

        private void TxtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text == "")
            {
                txtQtd.Text = "1";
            }
        }

        private void TxtRow_ValueChanged(object sender, EventArgs e)
        {
            //desabilita a opção de validar venda e limpa o campo de troco
            if (txtRow.Value == 0)
            {
                btnOk.Enabled = false;
                txtTroco.Clear();
            }
        }


        // Opções de pesquisa de produto
        private void LblOpcao_MouseEnter(object sender, EventArgs e)
        {
            lblOpcao.BackColor = Color.Gainsboro;
        }

        private void LblOpcao_MouseLeave(object sender, EventArgs e)
        {
            lblOpcao.BackColor = Color.Transparent;
        }

        private void LblOpcao_Click(object sender, EventArgs e)
        {
            short opcao = Convert.ToInt16(lblOpPesquisa.Text);

            switch (opcao)
            {
                case 1:
                    lblNome.Visible = true;
                    lblChave.Visible = true;
                    txtNome.Visible = true;
                    cboPalavra.Visible = true;

                    lblCod.Visible = false;
                    txtCod.Visible = false;

                    txtCod.Clear();

                    lblOpPesquisa.Text = "2";

                    dataGridView2.DataSource = null;
                    dataGridView2.Columns["QtdEstoque"].Visible = true;

                    break;

                case 2:
                    txtNome.Clear();

                    cboPalavra.Items.Add("Produto da casa");
                    cboPalavra.SelectedIndex = 6;
                    cboPalavra.Enabled = false;

                    lblOpPesquisa.Text = "3";

                    dataGridView2.DataSource = null;
                    dataGridView2.Columns["QtdEstoque"].Visible = false;

                    break;

                case 3:
                    lblNome.Visible = false;
                    lblChave.Visible = false;
                    txtNome.Visible = false;
                    cboPalavra.Visible = false;

                    txtNome.Clear();

                    cboPalavra.DropDownStyle = ComboBoxStyle.DropDown;
                    cboPalavra.Text = "";
                    cboPalavra.Items.Remove("Produto da casa");
                    cboPalavra.Enabled = true;

                    lblCod.Visible = true;
                    txtCod.Visible = true;

                    lblOpPesquisa.Text = "1";

                    dataGridView2.DataSource = null;
                    dataGridView2.Columns["QtdEstoque"].Visible = true;

                    break;
            }

            lblFalhaPesquisa1.Visible = false;
            lblFalhaPesquisa2.Visible = false;
            lblFalhaPesquisa3.Visible = false;
        }

        private void CboPalavra_Enter(object sender, EventArgs e)
        {
            cboPalavra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPalavra.SelectedIndex = -1;
        }


        // Ações do ToolTip dos botões do Form
        private void BtnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPesquisar, "Pesquisar um produto (Ctrl+Q)");
        }

        private void BtnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdicionar, "Adicionar um produto na fila (Ctrl+W)");
        }

        private void BtnValidar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnValidar, "Confirmar valor pago (Ctrl+E)");
        }

        private void BtnOk_MouseEnter(object sender, EventArgs e)
        {
            if (btnOk.Enabled == true)
            {
                toolTip1.SetToolTip(btnOk, "Realizar venda (Ctrl+R)");
            }
        }

        private void BtnRelatorio_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnRelatorio, "Exibir relátorio de vendas (Ctrl+T)");
        }


        // Tratamento de aviso de pesquisa de produto
        private void TxtCod_Click(object sender, EventArgs e)
        {
            lblAdicionar.Visible = false;
        }

        private void TxtNome_Click(object sender, EventArgs e)
        {
            lblAdicionar.Visible = false;
        }

        private void CboPalavra_Click(object sender, EventArgs e)
        {
            lblAdicionar.Visible = false;
        }



        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_novaVendaAjuda>().Count() == 0)
            {
                Frm_novaVendaAjuda tela = new Frm_novaVendaAjuda();
                tela.Show();
            }  
        }

        private void FrmNovaVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_novaVendaAjuda>().Count() == 1)
            {
                Application.OpenForms["Frm_novaVendaAjuda"].Close();
            }
        }
    }
}

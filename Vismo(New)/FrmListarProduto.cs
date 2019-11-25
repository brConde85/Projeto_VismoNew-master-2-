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
    public partial class FrmListarProduto : Form
    {
        //Preenche o datagrid quando o form for aberto 
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        //método para confirmar ação de editar produto
        private void EditarRegistro()
        {
            if (MessageBox.Show("Editar registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(dgvProduto.CurrentRow.Cells[1].Value);

                FrmCadProduto tela = new FrmCadProduto(codigo);

                tela.Show();

                Close();
            }
        }

        //lista os registros de produtos ao entrar no Form
        private void FrmListarProduto_Load(object sender, EventArgs e)
        {
            if (lblCod.Text == "0")
            {
                try
                {
                    Produto produto = new Produto();

                    string comando = "";

                    if (chkDesabilitados.Checked == true)
                    {
                        comando = "SELECT t1.*, t2.nome AS fornecedor FROM Produto t1, Fornecedor t2 " +
                    "WHERE t1.codFornecedor = t2.codFornecedor";
                    }
                    else
                    {
                        comando = "SELECT t1.*, t2.nome AS fornecedor FROM Produto t1, Fornecedor t2 " +
                    "WHERE t1.codFornecedor = t2.codFornecedor " +
                    "AND t1.status = 'Habilitado' ORDER BY t1.nome";
                    }
                    
                   
                    dgvProduto.DataSource = produto.ListarDataGrid(comando);
                    dgvProduto.DataMember = produto.ListarDataGrid(comando).Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Produto produto = new Produto();

                    produto.fornecedor.Codigo = Convert.ToInt32(lblCod.Text);

                    dgvProduto.AutoGenerateColumns = false;
                    dgvProduto.DataSource = produto.ProdutoFornec();
                    dgvProduto.DataMember = produto.ProdutoFornec().Tables[0].TableName;

                    int row = dgvProduto.RowCount;

                    for (int i = 0; i < row; i++)
                    {
                        dgvProduto.Rows[i].Cells[0].Value = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                lblNome.Visible = false;

                try
                {
                    Produto produto = new Produto();

                    produto.Nome = txtNome.Text;

                    //preenche o dataGrid
                    dgvProduto.AutoGenerateColumns = false;

                    string comando = "";

                    if (chkDesabilitados.Checked == true)
                    {
                        comando = "SELECT * FROM produto WHERE lower(nome) " +
                        "like lower('%" + produto.Nome + "%') ORDER BY nome";
                    }
                    else
                    {
                        comando = "SELECT * FROM produto WHERE lower(nome) " +
                        "like lower('%" + produto.Nome + "%') " +
                        "AND status = 'Habilitado' ORDER BY nome";
                    }
                        
                    dgvProduto.DataSource = produto.ListarDataGrid(comando);

                    if (dgvProduto.RowCount > 0)
                    {
                        lblEncontrado.Visible = false;
                    }
                    else
                    {
                        lblEncontrado.Visible = true;
                    }

                    lblRegistro.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblNome.Visible = true;
            }
        }

        private void LblRegistro_Click(object sender, EventArgs e)
        {
            FrmListarProduto_Load(sender, e);

            lblRegistro.Visible = false;
            lblNome.Visible = false;
            lblEncontrado.Visible = false;

            txtNome.Clear();
            txtNome.Focus();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnPesquisar_Click(sender, e);
            }
        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNome.Focused == false)
            {
                EditarRegistro();
            }
        }

        private void DgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarRegistro();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelecionar.Checked == true)
            {
                int row = dgvProduto.RowCount;

                for (int i = 0; i < row; i++)
                {
                    dgvProduto.Rows[i].Cells[0].Value = true;
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int row = dgvProduto.RowCount;
            int cont = 0;

            for (int i = 0; i < row; i++)
            {
                if (Convert.ToString(dgvProduto.Rows[i].Cells[0].Value) != "False")
                {
                    Produto produto = new Produto();

                    produto.Codigo = Convert.ToInt32(dgvProduto.Rows[i].Cells[1].Value);

                    try
                    {
                        string comando = "UPDATE Produto SET status = 'Habilitado' " +
                    "WHERE codigo = @codigo";

                        if (produto.MudaStatus(comando) == 0)
                        {
                            cont += 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            
            if (cont == 0)
            {
                MessageBox.Show("Alterações salvas.", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Um ou mais registros não foram alterados com sucesso.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FrmListarFornecedor tela = new FrmListarFornecedor();
            tela.Show();

            Close();
        }

        private void ChkDesabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesabilitados.Checked == true)
            {
               
            }
        }
    }
}


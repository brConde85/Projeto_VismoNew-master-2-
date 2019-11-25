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

        //método para confirmar ação de editar fornecedor
        private void EditarRegistro()
        {
            //permite edição de registro caso não esteja em uma edição de produto
            if (Application.OpenForms.OfType<FrmCadProduto>().Count() == 0 &&
                Application.OpenForms.OfType<FrmCadPagamento>().Count() == 0)
            {
                if (MessageBox.Show("Editar registro?", "Confirmação",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);

                    FrmCadFornecedor tela = new FrmCadFornecedor(codigo);

                    tela.Show();

                    Close();
                }
            }  
        }


        //tratamento do Form para opção de editar registro
        private void FrmListarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNome.Focused == false)
            {
                EditarRegistro();
            }
        }

        //tratamento de interface
        private void LblRegistro_Click(object sender, EventArgs e)
        {
            FrmListarFornecedor_Load(sender, e);

            lblRegistro.Visible = false;
            lblNome.Visible = false;
            lblEncontrado.Visible = false;

            txtNome.Clear();
            txtNome.Focus();
        }


        //lista todos os fornecedore registrados
        private void FrmListarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();

                string comando = "";

                if (chkDesabilitados.Checked == true)
                {
                    comando = "SELECT * FROM Fornecedor ORDER BY nome";
                }
                else
                {
                    comando = "SELECT * FROM Fornecedor WHERE status = 'Habilitado' ORDER BY nome";
                }

                //preecnhe o dataGrid
                dgvFornecedor.DataSource = fornecedor.ListarDataGrid(comando);
                dgvFornecedor.DataMember = fornecedor.ListarDataGrid(comando).Tables[0].TableName;

                lblPesquisa.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }

        //busca o registros de fornecedores por nome informado 
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                lblNome.Visible = false;

                try
                {
                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Nome = txtNome.Text;

                    string comando = "";

                    if (chkDesabilitados.Checked == true)
                    {
                        comando = "SELECT * FROM Fornecedor WHERE lower(nome) like lower('%" + fornecedor.Nome + "%')";
                    }
                    else
                    {
                        comando = "SELECT * FROM Fornecedor WHERE lower(nome) like lower('%" + fornecedor.Nome + "%') " +
                            "AND status = 'Habilitado'";
                    }

                    //preenche o dataGrid
                    dgvFornecedor.DataSource = fornecedor.ListarNome(comando);

                    lblPesquisa.Text = "2";

                    if (dgvFornecedor.RowCount > 0)
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
                    MessageBox.Show("Erro ao listar fornecedores", "Erro" + MessageBoxButtons.OK
                        + MessageBoxIcon.Error + ex.Message);
                }
            }
            else
            {
                lblNome.Visible = true;
            }
        }

        //confirmação para edição de regitro de fornecedor
        private void DgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarRegistro();
        }

        //tratamento da caixa de texto para pesquisa por nome
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnPesquisar_Click(sender, e);
            }
        }

        //fecha o Form
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkDesabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (lblPesquisa.Text == "1")
            {
                FrmListarFornecedor_Load(sender, e);
            }
            else
            {
                BtnPesquisar_Click(sender, e);
            }
        }
    }
}

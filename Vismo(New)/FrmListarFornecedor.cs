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
            if (MessageBox.Show("Editar registro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmNovoFornecedor tela =
                new FrmNovoFornecedor(Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value));

                tela.Show();

                Close();
            }
        }


        //lista todos os fornecedore registrados
        private void FrmListarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();

                //preecnhe o dataGrid
                dgvFornecedor.AutoGenerateColumns = false;
                dgvFornecedor.DataSource = fornecedor.ListarDataGrid();
                dgvFornecedor.DataMember = fornecedor.ListarDataGrid().Tables[0].TableName;
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

                    //preenche o dataGrid
                    dgvFornecedor.AutoGenerateColumns = false;
                    dgvFornecedor.DataSource = fornecedor.ListarNome();
                    dgvFornecedor.DataMember = fornecedor.ListarNome().Tables[0].TableName;

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
                    MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                        + MessageBoxIcon.Error + ex.Message);
                }
            }
            else
            {
                lblNome.Visible = true;
            }
        }

        //confirmação para edição de regitro de fornecedor
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void FrmListarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNome.Focused == false)
            {
                EditarRegistro();  
            }
        }

        private void LblRegistro_Click(object sender, EventArgs e)
        {
            FrmListarFornecedor_Load(sender, e);

            lblRegistro.Visible = false;
            lblNome.Visible = false;
            lblEncontrado.Visible = false;

            txtNome.Clear();
            txtNome.Focus();
        }
    }
}

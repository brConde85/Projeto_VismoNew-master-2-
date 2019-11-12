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
    public partial class FrmRegistroPagamento : Form
    {
        public FrmRegistroPagamento()
        {
            InitializeComponent();
        }

        // Ação de voltar para alterar esconder e exibir os objetos do form (datagrid, imagens, botões e exibir labels)
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            dgPagamento.Visible = false;
            pictureBox1.Visible = false;

            btnVoltar.Visible = false;
            btnAtualizar.Visible = false;

            lblRes.Visible = true;
            lblPen.Visible = true;
            lblAtra.Visible = true;
        }

        // Ação para exibir os pagamentos realizados
        private void LblRes_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;

            string comando = "SELECT * FROM Pagamento WHERE situacao = 'Realizado' OR situacao = 'Realizado com atraso'";
            dgPagamento.DataSource = pagamento.ListarDataGrid(comando);
            dgPagamento.DataMember = pagamento.ListarDataGrid(comando).Tables[0].TableName;

            dgPagamento.Visible = true;
            pictureBox1.Visible = true;

            btnVoltar.Visible = true;

            lblRes.Visible = false;
            lblPen.Visible = false;
            lblAtra.Visible = false;
        }

        // Ação para exibir os pagamentos pendentes
        private void LblPen_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;

            string comando = "SELECT * FROM Pagamento WHERE situacao = 'Pendente'";
            dgPagamento.DataSource = pagamento.ListarDataGrid(comando);
            dgPagamento.DataMember = pagamento.ListarDataGrid(comando).Tables[0].TableName;

            dgPagamento.Visible = true;
            pictureBox1.Visible = true;

            btnVoltar.Visible = true;

            lblRes.Visible = false;
            lblPen.Visible = false;
            lblAtra.Visible = false;

            if (dgPagamento.Rows.Count > 0)
            {
                btnAtualizar.Visible = true;
            }
        }

        //Ação para exibir os pagamentos atrasados
        private void LblAtra_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;

            string comando = "SELECT * FROM Pagamento WHERE situacao = 'Atrasado'";
            dgPagamento.DataSource = pagamento.ListarDataGrid(comando);
            dgPagamento.DataMember = pagamento.ListarDataGrid(comando).Tables[0].TableName;

            dgPagamento.Visible = true;
            pictureBox1.Visible = true;

            btnVoltar.Visible = true;

            lblRes.Visible = false;
            lblPen.Visible = false;
            lblAtra.Visible = false;

            if (dgPagamento.Rows.Count > 0)
            {
                btnAtualizar.Visible = true;
            }
        }

        //Ação para atualizar o status de pagamento ao carregar o form
        private void FrmRegistroPagamento_Load(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Atualiza();
        }

        //Ação para atualizar pagamentos pendentes e atrasados 
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.CodPagamento = Convert.ToInt32(dgPagamento.CurrentRow.Cells[0].Value.ToString());

            MessageBox.Show("Pagamento: '" + dgPagamento.CurrentRow.Cells[2].Value.ToString() +
                   "' foi atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Convert.ToString(dgPagamento.CurrentRow.Cells[4].Value) == "Atrasado")
            {
                string comando = "UPDATE Pagamento SET situacao = 'Realizado com atraso' WHERE codigo = @codPagamento";
                pagamento.AtualizaPagamento(comando);

                LblAtra_Click(sender, e);
            }
            else
            {
                string comando = "UPDATE Pagamento SET situacao = 'Realizado' WHERE codigo = @codPagamento";
                pagamento.AtualizaPagamento(comando);

                LblPen_Click(sender, e);
            }  
        }
    }
}

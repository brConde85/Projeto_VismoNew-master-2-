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

        private void LblRes_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;
            dgPagamento.DataSource = pagamento.ListarDataGrid("Realizado");
            dgPagamento.DataMember = pagamento.ListarDataGrid("Realizado").Tables[0].TableName;

            dgPagamento.Visible = true;
            pictureBox1.Visible = true;

            btnVoltar.Visible = true;

            lblRes.Visible = false;
            lblPen.Visible = false;
            lblAtra.Visible = false;
        }

        private void LblPen_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;
            dgPagamento.DataSource = pagamento.ListarDataGrid("Pendente");
            dgPagamento.DataMember = pagamento.ListarDataGrid("Pendente").Tables[0].TableName;

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

        private void LblAtra_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            dgPagamento.AutoGenerateColumns = false;
            dgPagamento.DataSource = pagamento.ListarDataGrid("Atrasado");
            dgPagamento.DataMember = pagamento.ListarDataGrid("Atrasado").Tables[0].TableName;

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

        private void FrmRegistroPagamento_Load(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Atualiza();
        }
    }
}

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
    public partial class FrmMaisVendidos : Form
    {
        public FrmMaisVendidos()
        {
            InitializeComponent();
        }

        //Ação para pesquisa 
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!cboMes1.Text.Equals("") && !cboMes2.Text.Equals(""))
            {
                if (cboMes1.SelectedIndex <= cboMes2.SelectedIndex)
                {
                    try
                    {
                        dgVendidos.DataSource = null;

                        Produto produto = new Produto();

                        int mes1 = cboMes1.SelectedIndex + 1;
                        int mes2 = cboMes2.SelectedIndex + 1;

                        dgVendidos.AutoGenerateColumns = false;
                        dgVendidos.DataSource = produto.MaisVendidos(mes1, mes2);
                        dgVendidos.DataMember = produto.MaisVendidos(mes1, mes2).Tables[0].TableName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                            + MessageBoxIcon.Error + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um intervalo válido para continuar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Escolha os meses para a pesquisa antes de continuar", "Aviso",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        //Ação para exibir conteúdo do banco ao entrar no form
        private void FrmMaisVendidos_Load(object sender, EventArgs e)
        {
            try
            {
                int mes1 = Convert.ToInt32(DateTime.Now.Month.ToString());
                int mes2 = Convert.ToInt32(mes1 - 1);

                Produto produto = new Produto();

                dgVendidos.AutoGenerateColumns = false;
                dgVendidos.DataSource = produto.MaisVendidos(mes2, mes1);
                dgVendidos.DataMember = produto.MaisVendidos(mes2, mes1).Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}

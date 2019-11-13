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
            //compara se os campos de intervalo de tempo foram preenchidos
            if (!cboMes1.Text.Equals("") && !cboMes2.Text.Equals(""))
            {
                //compara se o mês de início e inferior ao mês final
                if (cboMes1.SelectedIndex <= cboMes2.SelectedIndex)
                {
                    try
                    {
                        //limpa o dataGrig
                        dgVendidos.DataSource = null;

                        Produto produto = new Produto();

                        /*as variáveis são usadas como parâmetro para pesquisa no banco de dados sendo que,
                          os comboBox têm seu SelectedIndex representando a numeração dos meses do ano.

                          Ex: cboMes1.SelectedIndex = 0 representa o mês de Janeiro,
                          cboMes1.SelectedIndex = 1 representa o mês de Fevereiro, etc.
                          Como inicia em 0, as variáveis recebem +1, assim igualando a numeração dos meses.
                          
                          Os parâmetros são usados na string de conexão, limitando a pesquisa
                          de produtos mais vendidos em um intervalo de meses*/
                        int mes1 = cboMes1.SelectedIndex + 1;
                        int mes2 = cboMes2.SelectedIndex + 1;

                        dgVendidos.AutoGenerateColumns = false;
                        dgVendidos.DataSource = produto.MaisVendidos(mes1, mes2);
                        dgVendidos.DataMember = produto.MaisVendidos(mes1, mes2).Tables[0].TableName;
                    }
                    catch (Exception ex)
                    {
                        //em aso de erro ao listar
                        MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                            + MessageBoxIcon.Error + ex.Message);
                    }
                }
                else
                {
                    //caso o intervalo de meses for inválido
                    MessageBox.Show("Escolha um intervalo válido para continuar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //caso não for fornecido um intervalo
                MessageBox.Show("Escolha os meses para a pesquisa antes de continuar", "Aviso",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        //ao entrar no Form, é exibido o registro de produtos mais vendidos no mês passado
        private void FrmMaisVendidos_Load(object sender, EventArgs e)
        {
            try
            {
                //aqui as variáveis recebem a numeração do mês passado e do atual para o parâmetro
                int mes1 = Convert.ToInt32(DateTime.Now.Month.ToString());
                int mes2 = mes1 - 1;

                Produto produto = new Produto();

                //preenche o dataGrid
                dgVendidos.AutoGenerateColumns = false;
                dgVendidos.DataSource = produto.MaisVendidos(mes2, mes1);
                dgVendidos.DataMember = produto.MaisVendidos(mes2, mes1).Tables[0].TableName;
            }
            catch (Exception ex)
            {
                //em caso de erro
                MessageBox.Show("Erro ao listar produtos", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ChatCaixa : Form
    {

        public ChatCaixa()
        {
            InitializeComponent();
        }
        TelaDisponivel telaDisponivel = new TelaDisponivel();
        private void ChatCaixa_Load(object sender, EventArgs e)
        {
            ConexãoChat conexãoChat = new ConexãoChat();

            MessageBox.Show(conexãoChat.msgGerente);
          
            rtbCaixa.Text = conexãoChat.msgGerente;
          
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            ConexãoChat conexãoChat = new ConexãoChat();
            conexãoChat.msgCaixa = txtCaixa.Text;
            rtbCaixa.Text = "Caixa: " + txtCaixa.Text;
            txtCaixa.Text = "";

        }
    }
}

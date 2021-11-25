using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLoja
{
    public partial class CriarUser : Form
    {
        public CriarUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UtilFunctions.CreateUser(Txt_UserName, Txt_Senha, Txt_ConfirmaSenha, Txt_NomeEmpresa, Txt_Token, Txt_Caminho))
            {
                MessageBox.Show("Parabéns! Voce realizou o seu cadastro");
                Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_UserName_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Txt_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (Login.TryLogin(Txt_Login, Txt_Password))
            {
                MessageBox.Show("Login efetuado com sucesso!", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                SistemaInterno sis = new SistemaInterno();
                sis.Show();
            }
            else
            {
                MessageBox.Show("Erro ao tentar acessar o sistema, por favor, verifique seu usuário e senha!", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarUser newUser = new CriarUser();
            newUser.ShowDialog();
        }
    }
}

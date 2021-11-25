using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLoja
{
    public class UtilFunctions
    {
        public static void DefineUserName(Label label, string txtBox)
        {
            label.Text = txtBox;
        }

        public static bool CreateUser(TextBox user, TextBox senha, TextBox confirmaSenha, TextBox nomeEmpresa, TextBox token, TextBox caminho)
        {

            if(senha.Text == confirmaSenha.Text && token.Text == "4883")
            {
                System.IO.File.AppendAllText(@"C:\Users\Vinicius\Acessos.txt", user.Text + Environment.NewLine);
                System.IO.File.AppendAllText(@"C:\Users\Vinicius\Acessos.txt", senha.Text + Environment.NewLine);
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}

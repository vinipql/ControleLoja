using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLoja
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public static bool TryLogin(TextBox userName, TextBox Password)
        {
            string login = userName.Text.ToString();
            string senha = Password.Text.ToString();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Vinicius\Acessos.txt");

            int linesSize = lines.Count();
            int x = 0;
            try
            {
                while (x <= linesSize)
                {

                    if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                    {
                        if (lines[x] == login && lines[x + 1] == senha)
                        {
                            SistemaInterno systema = new SistemaInterno();
                            x++;
                            return true;
                        }
                        x++;
                    }
                    x++;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        
    }
}

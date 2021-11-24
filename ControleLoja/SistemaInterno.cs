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
    public partial class SistemaInterno : Form
    {
        public SistemaInterno()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Vinicius\Acessos.txt");
            InitializeComponent();
            UtilFunctions.DefineUserName(Lbl_UserName, lines[0]);
        }

        private void Lbl_UserName_Click(object sender, EventArgs e)
        {

        }

        private void SistemaInterno_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class tela_Autenticação : Form
    {
        public tela_Autenticação()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Principal objTelaPrincipal = new Tela_Principal();
            this.Hide();
            objTelaPrincipal.Show();
         }
    }
}

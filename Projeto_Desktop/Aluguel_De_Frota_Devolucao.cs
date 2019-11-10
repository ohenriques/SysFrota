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
    public partial class Aluguel_De_Frota_Devolucao : Form
    {
        public Aluguel_De_Frota_Devolucao()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Aluguel_De_Frota_Devolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysCarDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysCarDataSet.Cliente);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

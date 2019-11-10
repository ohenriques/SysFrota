using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class Frota_Pesquisar : Form
    {
        public Frota_Pesquisar()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frota_Pesquisar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConxao = "Data Source=DESKTOP-P8BLD71\\SQLEXPRESS;Initial Catalog=SysCar;Integrated Security=True";
            string Query = "Select * from Veiculo";
            if (txtIDPesquisa.Text.Trim() != "")
            {
                Query += " Where Chassi=" + txtIDPesquisa.Text;
            }else;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgTabela.DataSource = dt;
        
            
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

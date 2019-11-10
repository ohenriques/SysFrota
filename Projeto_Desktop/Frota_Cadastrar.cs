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
    public partial class Frota_Cadastrar : Form
    {
        public Frota_Cadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            DBBase db = new DBBase();
            string Query = "INSERT INTO Veiculo(Placa,IDVeiculo,Marca,Modelo,Ano,Chassi)VALUES('" + txtPlaca.Text + "','" + txtIDVeiculo.Text + "','" + txtMarca.Text + "','" + txtIDVeiculo.Text + "','" + txtAno.Text + "','"+txtChassi.Text+"')";
            db.ExecutaInstrucaoNaBase(Query);
            lblStatus.Text = "Registro Inserido Com Sucesso";
        }
    }
}

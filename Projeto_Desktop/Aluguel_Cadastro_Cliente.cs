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
    public partial class Aluguel_Cadastro_Cliente : Form
    {
        public Aluguel_Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            DBBase db = new DBBase();
            string Query = "INSERT INTO Cliente(ID,NomeFantasia,RazaoSocial,RamoAtuacao,CNPJ)VALUES('" + txtIdCliente.Text + "','" + txtNomeFantasia.Text + "','" + txtRazaoSocial.Text + "','" + tipoDeAtuacao.Text +"','" + txtCNPJ.Text + "')";
            db.ExecutaInstrucaoNaBase(Query);
            lblStatus.Text = "Registro Inserido Com Sucesso";
        }   

        private void comboBoxTipoAtuacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

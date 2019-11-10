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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Funcionario_Cadastrar _objCadastrarFuncionario = new Funcionario_Cadastrar();
            _objCadastrarFuncionario.MdiParent = this;
            _objCadastrarFuncionario.Show();

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario_Pesquisar _objPesquisarFuncionario = new Funcionario_Pesquisar();
            _objPesquisarFuncionario.ShowDialog();
        }
    }
}

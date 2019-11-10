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
            _objPesquisarFuncionario.MdiParent = this;
            _objPesquisarFuncionario.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frota_Cadastrar _objCadastrarFrota = new Frota_Cadastrar();
            _objCadastrarFrota.MdiParent = this;
            _objCadastrarFrota.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frota_Pesquisar _objPesquisarFrota = new Frota_Pesquisar();
            _objPesquisarFrota.MdiParent = this;
            _objPesquisarFrota.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Viagem_Cadastrar _objCadastrarViagem = new Viagem_Cadastrar();
            _objCadastrarViagem.MdiParent = this;
            _objCadastrarViagem.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Viagem_Pesquisar _objPesquisarViagem = new Viagem_Pesquisar();
            _objPesquisarViagem.MdiParent = this;
            _objPesquisarViagem.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Relatorio_Cadastro _objCadastrarRelatorio = new Relatorio_Cadastro();
            _objCadastrarRelatorio.MdiParent = this;
            _objCadastrarRelatorio.Show();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Relatorio_Pesquisar _objPesquisarRelatorio = new Relatorio_Pesquisar();
            _objPesquisarRelatorio.MdiParent = this;
            _objPesquisarRelatorio.Show();
        }

        private void acompanhanmentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Acompanhamento _objAcompanhamentoRelatorio = new Relatorio_Acompanhamento();
            _objAcompanhamentoRelatorio.MdiParent = this;
            _objAcompanhamentoRelatorio.Show();
        }

        private void verificaçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Relatorio_VerificarDados _objVerificarDados = new Relatorio_VerificarDados();
            _objVerificarDados.MdiParent = this;
            _objVerificarDados.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario_Dados _objFuncionarioDados = new Funcionario_Dados();
            _objFuncionarioDados.MdiParent = this;
            _objFuncionarioDados.Show();
        }

        private void erroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_ErroLogin _obTelaAutenticacao = new Tela_ErroLogin();
            _obTelaAutenticacao.ShowDialog();

        }

        private void autemtocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_Autenticação _obTelaAutenticacao = new tela_Autenticação();
           _obTelaAutenticacao.ShowDialog();
        }

        private void toolStripTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripTextBox1.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Estoque_Click(object sender, EventArgs e)
        {

        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque_Pecas _obEstoquePecas = new Estoque_Pecas();
            _obEstoquePecas.MdiParent = this;
            _obEstoquePecas.Show();
        }

        private void pneusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque_Pneus _obEstoquePneus = new Estoque_Pneus();
            _obEstoquePneus.MdiParent = this;
            _obEstoquePneus.Show();
        }

        private void finançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financas _objFinancas = new Financas();
            _objFinancas.MdiParent = this;
            _objFinancas.Show();
        }

        private void corretivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manutencao_Corretiva _objManutencao_Corretiva = new Manutencao_Corretiva();
            _objManutencao_Corretiva.MdiParent = this;
            _objManutencao_Corretiva.Show();
        }

        private void preditivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manutencao_Preventiva _objManutencao_Preventiva = new Manutencao_Preventiva();
            _objManutencao_Preventiva.MdiParent = this;
            _objManutencao_Preventiva.Show();
        }

        private void sinístrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sinistros _objSinistros = new Sinistros();
            _objSinistros.MdiParent = this;
            _objSinistros.Show();
        }

        private void avisosAutomáticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avisos_Automaticos _objAvisos_Automaticos = new Avisos_Automaticos();
            _objAvisos_Automaticos.MdiParent = this;
            _objAvisos_Automaticos.Show();
        }

        private void aluguelFrotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cadastrarManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manutencao_Cadastro _objCadastroManutencao = new Manutencao_Cadastro();
            _objCadastroManutencao.MdiParent = this;
            _objCadastroManutencao.Show();
        }

        private void alugarFrotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel_De_Frota_Retirada _De_Frota_Retirada = new Aluguel_De_Frota_Retirada();
            _De_Frota_Retirada.MdiParent = this;
            _De_Frota_Retirada.Show();
        }

        private void devolverFrotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel_De_Frota_Devolucao _De_Frota_Devolucao = new Aluguel_De_Frota_Devolucao();
            _De_Frota_Devolucao.MdiParent = this;
            _De_Frota_Devolucao.Show();
        }

        private void testeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel_Cadastro_Cliente _Cadastro_Cliente = new Aluguel_Cadastro_Cliente();
            _Cadastro_Cliente.MdiParent = this;
            _Cadastro_Cliente.Show();
        }
    }
}

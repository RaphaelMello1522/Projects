using BilheteriaEletronica.Entidades;
using BilheteriaEletronica.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilheteriaEletronica
{
    public partial class Administrativo : Form
    {
        private List<Pessoas> listaPessoas;
        public Administrativo()
        {
            InitializeComponent();
            listaPessoas = new List<Pessoas>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.InserirPessoa formPessoas = new Forms.InserirPessoa(listaPessoas);
            formPessoas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirPassagem excluirPassagem = new ExcluirPassagem(listaPessoas);
            excluirPassagem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarDados alterarDados = new AlterarDados(listaPessoas);
            alterarDados.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarPassageiros listarPassageiros = new ListarPassageiros(listaPessoas);
            listarPassageiros.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPessoas;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisarPassageiro pesquisarPassageiro = new PesquisarPassageiro(listaPessoas);
            pesquisarPassageiro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Encerramento do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Application.Exit();
        }
    }
}

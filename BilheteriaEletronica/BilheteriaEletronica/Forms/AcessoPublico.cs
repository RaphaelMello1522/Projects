using BilheteriaEletronica.Entidades;
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
    public partial class AcessoPublico : Form
    {
        private List<Pessoas> listaPessoas;
        public AcessoPublico()
        {
            InitializeComponent();
            listaPessoas = new List<Pessoas>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Encerramento do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.InserirPessoa formPessoas = new Forms.InserirPessoa(listaPessoas);
            formPessoas.Show();
        }
    }
}

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

namespace BilheteriaEletronica.Forms
{
    public partial class PesquisarPassageiro : Form
    {
        private List<Pessoas> listaPessoas;
        public PesquisarPassageiro(List<Pessoas> listaPessoas)
        {
            InitializeComponent();
            this.listaPessoas = listaPessoas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String busca = textBoxPesquisa.Text;
            richTextBoxPesquisa.Clear();
            List<Pessoas> resultaPessoas = listaPessoas.FindAll(pessoas =>
                pessoas.Nome.Contains(busca) ||
                pessoas.RG_CPF.Contains(busca) ||
                pessoas.Destino.Contains(busca) ||
                pessoas.Vagão.Contains(busca)
                
        );
            resultaPessoas.ForEach(pessoas =>
            {
                richTextBoxPesquisa.AppendText(pessoas.ToString());
            });
        }
    }
}

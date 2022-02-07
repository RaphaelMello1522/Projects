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
    public partial class AlterarDados : Form
    {
        private List<Pessoas> listaPessoas;
        private Pessoas pessoas;
        public AlterarDados(List<Pessoas> listaPessoas)
        {
            InitializeComponent();
            this.listaPessoas = listaPessoas;
            MostraPessoas(listaPessoas);
        }
        
        private void MostraPessoas(List<Pessoas> listaPessoas)
        {
            listaPessoas.ForEach(pessoas =>
            richTextBoxListar.AppendText(pessoas.ToString())
            );
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            pessoas.Nome = textBoxNome.Text;
            pessoas.RG_CPF = textBoxRG_CPF.Text;
            pessoas.Destino = comboBoxDestino.Text;
            pessoas.Vagão = comboBoxVagao.Text;
            pessoas.Passagens = comboBoxPassagens.Text;
            pessoas.Data = dateTimePicker1.Text;
            pessoas.Preco = labelTotal.Text;
            richTextBoxListar.Clear();
            MostraPessoas(listaPessoas);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idBusca = Convert.ToInt32(textBoxBusca.Text);
            pessoas = listaPessoas.Find(pessoas => pessoas.ID == idBusca);
            textBoxNome.Text = pessoas.Nome;
            textBoxRG_CPF.Text = pessoas.RG_CPF;
            comboBoxDestino.Text = pessoas.Destino;
            comboBoxPassagens.Text = pessoas.Passagens;
            comboBoxVagao.Text = pessoas.Vagão;
        }

        private void btnNovoTotal_Click(object sender, EventArgs e)
        {
            float PrecoBase = 0;
            float Subtotal;
            float PrecoTotal = 0;

            if (comboBoxPassagens.SelectedIndex == 0)
                PrecoBase = 30;
            if (comboBoxPassagens.SelectedIndex == 1)
                PrecoBase = 60;
            if (comboBoxPassagens.SelectedIndex == 2)
                PrecoBase = 90;
            if (comboBoxPassagens.SelectedIndex == 3)
                PrecoBase = 120;
            if (comboBoxPassagens.SelectedIndex == 4)
                PrecoBase = 150;
            if (comboBoxPassagens.SelectedIndex == 5)
                PrecoBase = 180;


            Subtotal = PrecoBase;
            PrecoTotal = Subtotal;

            labelTotal.Text = "Total:   " + PrecoTotal.ToString("C");
        }

        private void comboBoxPassagens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

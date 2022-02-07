using BilheteriaEletronica.Entidades;
using BilheteriaEletronica.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilheteriaEletronica.Forms
{
    public partial class InserirPessoa : Form
    {
        private List<Pessoas> listaPessoas;
        public InserirPessoa(List<Pessoas> listaPessoas)
        {
            InitializeComponent();
            this.listaPessoas = listaPessoas;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();

            pessoas.ID = ID.getNewID(listaPessoas);
            pessoas.Nome = textBoxNome.Text;
            pessoas.RG_CPF = textBoxRG_CPF.Text;
            pessoas.Passagens = comboBoxPassagens.Text;
            pessoas.Destino = comboBoxDestino.Text;
            pessoas.Vagão = comboBoxVagao.Text;
            pessoas.Passagens = comboBoxPassagens.Text;
            pessoas.Data = dateTimePicker1.Text;
            pessoas.Preco = labelTotal.Text;
            listaPessoas.Add(pessoas);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}

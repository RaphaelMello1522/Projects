using Cadastro_Hospital_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Hospital_1.Forms_Pacientes
{
    public partial class PesquisaPaciente : Form
    {
        private List<Pacientes> listaPacientes;
        public PesquisaPaciente(List<Pacientes> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxPesquisa.Clear();
            String busca = textBoxPesquisa.Text;

            List<Pacientes> resultaPacientes = listaPacientes.FindAll(pacientes =>
                pacientes.Nome.Contains(busca) ||
                pacientes.RG.Contains(busca) ||
                pacientes.Bairro.Contains(busca) ||
                pacientes.Sintoma.Contains(busca) 
            );

            resultaPacientes.ForEach(pacientes =>
            {
                richTextBoxPesquisa.AppendText(pacientes.ToString());
            });

        }

        private void richTextBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

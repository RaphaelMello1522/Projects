using Cadastro_Hospital_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Hospital_1.Forms_Pacientes
{
    
    public partial class AlterarPaciente : Form
    {
        private List<Pacientes> listaPacientes;
        private Pacientes pacientes;
        public AlterarPaciente(List<Pacientes> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
            MostraPacientes(listaPacientes);
        }
        private void MostraPacientes(List<Pacientes> listaPacientes)
        {
            listaPacientes.ForEach(pacientes => 
                richTextBoxListar.AppendText(pacientes.ToString())
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idBusca = Convert.ToInt32(textBoxBusca.Text);
            pacientes = listaPacientes.Find(paciente => paciente.ID == idBusca);
            textBoxNome.Text = pacientes.Nome;
            textBoxRG.Text = pacientes.RG;
            textBoxSintoma.Text = pacientes.Sintoma;
            
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            pacientes.Nome = textBoxNome.Text;
            pacientes.RG = textBoxRG.Text;
            pacientes.Sintoma = textBoxSintoma.Text;
            richTextBoxListar.Clear();
            MostraPacientes(listaPacientes);
        }

        private void richTextBoxListar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

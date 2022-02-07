using Cadastro_Hospital_1.Entidades;
using Cadastro_Hospital_1.Servicos;
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
    public partial class InserirPacientes : Form
    {
        private List<Pacientes> listaPacientes;

        public InserirPacientes(List<Pacientes> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();

            pacientes.ID = GeraID.getNewID(listaPacientes);
            pacientes.Bairro = comboBox1.Text;
            pacientes.Nome = textBoxNome.Text;
            pacientes.RG = textBoxRG.Text;
            pacientes.Sintoma = textBoxSexo.Text;
            pacientes.Sexo = textBoxSexo.Text;

            listaPacientes.Add(pacientes);
            this.Close();
            
        }

        private void InserirPacientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

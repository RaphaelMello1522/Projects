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
    public partial class ExcluirPaciente : Form
    {
        public List<Pacientes> listaPacientes;
        public ExcluirPaciente(List<Pacientes> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idExcluir = Convert.ToInt32(textBoxIDExcluir.Text);
            Pacientes pacientes = listaPacientes.Find(paciente => paciente.ID == idExcluir);
            listaPacientes.Remove(pacientes);
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIDExcluir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

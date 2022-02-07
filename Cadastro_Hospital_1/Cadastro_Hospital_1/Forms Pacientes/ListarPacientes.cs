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
    public partial class ListarPacientes : Form
    {
        
        public ListarPacientes(List<Pacientes> listaPacientes)
        {
            InitializeComponent();
            MostraPacientes(listaPacientes); 

        }

        private void MostraPacientes(List<Pacientes> listaPacientes)
        {
            listaPacientes.ForEach(pacientes =>
            {
                richTextBoxPacientes.AppendText(pacientes.ToString());
            });
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBoxPacientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListarPacientes_Load(object sender, EventArgs e)
        {

        }
    }
}

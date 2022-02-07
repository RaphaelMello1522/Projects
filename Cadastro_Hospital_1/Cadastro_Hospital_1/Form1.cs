using Cadastro_Hospital_1.Entidades;
using Cadastro_Hospital_1.Forms_Pacientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Hospital_1
{
    public partial class Form1 : Form
    {
        private List<Pacientes> listaPacientes;
        public Form1()
        {
            InitializeComponent();
            listaPacientes = new List<Pacientes>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O sistema está encerrando");
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms_Pacientes.InserirPacientes formPacientes = new Forms_Pacientes.InserirPacientes(listaPacientes);
            formPacientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarPacientes listarPacientes = new ListarPacientes(listaPacientes);
            listarPacientes.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPacientes;
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirPaciente excluirPacientes = new ExcluirPaciente(listaPacientes);
            excluirPacientes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisaPaciente pesquisaPaciente = new PesquisaPaciente(listaPacientes);
            pesquisaPaciente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarPaciente alterarPaciente = new AlterarPaciente(listaPacientes);
            alterarPaciente.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

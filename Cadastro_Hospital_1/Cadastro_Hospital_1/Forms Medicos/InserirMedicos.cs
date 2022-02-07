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

namespace Cadastro_Hospital_1.Forms_Medicos
{
    public partial class InserirMedicos : Form
    {
        private List<InserirMedicos> listaMedicos;

        public InserirMedicos(List<InserirMedicos> listaMedicos)
        {
            InitializeComponent();
            this.listaMedicos = listaMedicos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicos medicos = new Medicos();

            
            medicos.Nome = textBoxNomeM.Text;
            medicos.CRM = textBoxCRM.Text;
            medicos.Sexo = textBoxSexoM.Text;

            Close();
        }
    }
}

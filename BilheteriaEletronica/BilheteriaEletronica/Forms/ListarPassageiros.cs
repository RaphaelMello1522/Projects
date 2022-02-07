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
    public partial class ListarPassageiros : Form
    {
        public ListarPassageiros(List<Pessoas> listaPessoas)
        {
            InitializeComponent();
            MostraPassageiros(listaPessoas);
        }

        private void MostraPassageiros(List<Pessoas> listaPessoas)
        {
            listaPessoas.ForEach(pessoas =>
            {
                richTextBoxPacientes.AppendText(pessoas.ToString());
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class ExcluirPassagem : Form
    {
        public List<Pessoas> listaPessoas;
        public ExcluirPassagem(List<Pessoas> listaPessoas)
        {
            InitializeComponent();
            this.listaPessoas = listaPessoas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idExcluir = Convert.ToInt32(textBoxIDExcluir.Text);
            Pessoas pessoas = listaPessoas.Find(pessoa => pessoa.ID == idExcluir);
            listaPessoas.Remove(pessoas);
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilheteriaEletronica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnACADM_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            AcessoPublico acessoPublico = new AcessoPublico();
            acessoPublico.Show();
        }
    }
}

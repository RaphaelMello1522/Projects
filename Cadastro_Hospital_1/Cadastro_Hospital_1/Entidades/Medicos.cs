using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Hospital_1.Entidades
{
    public class Medicos
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public String CRM { get; set; }
        public String Sexo { get; set; }




        public override string ToString()
        {
            return ",Nome: " + Nome + ", CRM:" + CRM + ",Sexo:" + Sexo;
        }
    }
}


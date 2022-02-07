using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Hospital_1.Entidades
{
    public class Pacientes
    {
        public int ID { get; set; }
        public String Bairro { get; set; }
        public String Nome { get; set; }
        public String RG { get; set; }
        public String Sintoma { get; set; }
        public String Sexo { get; set; }
        



        public override string ToString()
        {
            return "ID:" + ID + ",Nome: " + Nome + ", RG:" + RG + ", Sintoma:" + Sintoma + ",Sexo:" + Sexo + ", Bairro:" + Bairro;
        }
    }
}

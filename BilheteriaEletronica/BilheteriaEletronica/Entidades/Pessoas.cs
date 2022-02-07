using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilheteriaEletronica.Entidades
{
   public class Pessoas
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string RG_CPF { get; set; }
        public string Destino { get; set; }
        public string Passagens { get; set; }

        public string Data { get; set; }
        public string Vagão { get; set; }
        public string Preco { get; set; }

        public override string ToString()
        {
            return "ID:" + ID + ",Nome: " + Nome + ", RG_CPF:" + RG_CPF + ", Passagens:" + Passagens + ",Vagão:" + Vagão + ",Destino" + Destino + ",Preco" + Preco + ",Data" + Data;
        }
    }
}

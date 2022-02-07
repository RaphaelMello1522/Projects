using BilheteriaEletronica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilheteriaEletronica.Serviços
{
    class ID
    {
        public static int getNewID(List<Pessoas> listaPessoas)
        {
            int maiorID = 0;
            listaPessoas.ForEach(pessoas =>
            {
                if (pessoas.ID > maiorID)
                {
                    maiorID = pessoas.ID;
                }
            });
            return maiorID + 1;
        }
    }
}

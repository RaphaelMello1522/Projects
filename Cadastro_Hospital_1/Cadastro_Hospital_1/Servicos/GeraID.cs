using Cadastro_Hospital_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Hospital_1.Servicos
{
    class GeraID
    {
        public static int getNewID(List<Pacientes> listaPacientes)
        {
            int maiorID = 0;
            listaPacientes.ForEach(pacientes =>
            {
                if(pacientes.ID > maiorID)
                {
                    maiorID = pacientes.ID;
                }
            });
            return maiorID + 1;
        }
        public static int getNewID(List<Medicos> listaMedicos)
        {
            int maiorID = 0;
            listaMedicos.ForEach(medicos =>
            {
                if (medicos.ID > maiorID)
                {
                    maiorID = medicos.ID;
                }
            });
            return maiorID + 1;
        }
    }
}

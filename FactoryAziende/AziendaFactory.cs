using FactoryAziende.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAziende
{
    public class AziendaFactory
    {
        public static IAzienda FactoryAzienda(int scelta)
        {

            IAzienda azienda = null;
            //creazione sulla base del param
            if (scelta <= 20)
            {
                azienda = new Piccola();
            }
            else if (scelta <= 100)
            {
                azienda = new Media();
            }
            else if (scelta <=500)
            {
                azienda = new Grande();
            }
            else if (scelta >=500)
            {
                azienda = new Multinazionale();
            }
            else
            {
                return azienda;
            }

            return azienda;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAziende.Entities
{
    public class Grande : IAzienda
    {
        public string CreaAzienda(int dipendenti)
        {
            return $"Sei una Grande azienda con {dipendenti} dipendenti in totale" ;
        }

    }
}

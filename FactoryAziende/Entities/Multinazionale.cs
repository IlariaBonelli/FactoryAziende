using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAziende.Entities
{
    public class Multinazionale : IAzienda
    {
        public string CreaAzienda(int dipendenti)
        {
            return $"Sei un'azienda multinazionale con {dipendenti} dipendenti in totale";
        }
    }
}

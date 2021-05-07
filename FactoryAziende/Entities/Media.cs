using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAziende.Entities
{
    public class Media : IAzienda
    {
       
        
            public string CreaAzienda(int dipendenti)
            {
                return $"Sei una media azienda con {dipendenti} dipendenti in totale";
            }

        
    }
}

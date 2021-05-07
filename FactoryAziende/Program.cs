using FactoryAziende.Entities;
using System;

namespace FactoryAziende
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            do
            {
                Console.WriteLine("Crea la tua azienda");
                Console.WriteLine("Quanti dipendenti hai?");
            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0);

            IAzienda azienda = AziendaFactory.FactoryAzienda(scelta);
            Console.WriteLine(azienda.CreaAzienda(scelta));

        }
    }
}

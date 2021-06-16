using System;

namespace Ontwerp4
{
    public class Program
    {
        private static void Main()
        {
            var sinterklaas1 = Sinterklaas.GetInstance();
            sinterklaas1.VertelUwNaam();
            var sinterklaas2 = Sinterklaas.GetInstance();
            sinterklaas2.VertelUwNaam();
            var sinterklaas3 = Sinterklaas.GetInstance();
            sinterklaas3.VertelUwNaam();

            if (sinterklaas1.Equals(sinterklaas2))
                Console.WriteLine("De instanties zijn gelijk aan elkaar");
            else
                Console.WriteLine("De instanties zijn niet gelijk aan elkaar.");
        }
    }
    
}
using System;

namespace Opdracht1
{
    class Program
    {
        static void Main()
        {
            Directeur Directeur1 = new Directeur("Leo", 56);
            Directeur Directeur2 = new Directeur("Piet", 33);

            Leerkracht Leerkracht1 = new Leerkracht("Dirk", 45);
            Leerkracht Leerkracht2 = new Leerkracht("Ann", 25);

            Student Student1 = new Student("Karel", 42);
            Student Student2 = new Student("Peter", 29);

            //door polymorfisme kan ik zelfs een array gebruiken die dezelfde types vereist.
            //elk object doet zich voor als een persoon
            Persoon[] werknemers = new Persoon[6];
            werknemers[0] = Directeur1;
            werknemers[1] = Directeur2;
            werknemers[2] = Leerkracht1;
            werknemers[3] = Leerkracht2;
            werknemers[4] = Student1;
            werknemers[5] = Student2;

            //vermits het allemaal personen zijn, kan ik ze op dezelfde manier behandelen
            foreach (Persoon persoon in werknemers)
            {
                Console.WriteLine("Ik ben " + persoon.Naam + ". Ik ben " + persoon.Ouderdom + " jaar");
                persoon.DoeUwDing();
            }

        }
    }
}

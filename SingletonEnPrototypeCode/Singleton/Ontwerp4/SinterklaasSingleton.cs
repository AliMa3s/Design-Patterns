using System;

namespace Ontwerp4
{
    public class Sinterklaas
    {
        private const string Naam = "Echte Sint";

        private static Sinterklaas _instance = new Sinterklaas();
        public static Sinterklaas GetInstance() {
            lock (_instance)
                return _instance ??= _instance = new Sinterklaas();
        }
        public  void VertelUwNaam() {
            Console.WriteLine("Mijn naam is " + Naam);
        }
        private Sinterklaas() {
            Console.WriteLine("Hallo, ik ben een nieuwe Sinterklaas!");
        }
    }
}
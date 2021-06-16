using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var koffie = new Koffie();
            Console.Out.WriteLine(koffie.getOmschrijving());
            Console.Out.WriteLine( "Prijs: " + koffie.getPrijs() + " euro");

            var koffieMetMelk = new Melk(new Koffie());
            Console.Out.WriteLine(koffieMetMelk.getOmschrijving());
            Console.Out.WriteLine( "Prijs: " + koffieMetMelk.getPrijs() + " euro");
            
            var koffieMetMelkEnSuiker = new Suiker(new Melk(new Koffie()));
            Console.Out.WriteLine(koffieMetMelkEnSuiker.getOmschrijving());
            Console.Out.WriteLine( "Prijs: " + koffieMetMelkEnSuiker.getPrijs() + " euro");
            
        }
    }
}
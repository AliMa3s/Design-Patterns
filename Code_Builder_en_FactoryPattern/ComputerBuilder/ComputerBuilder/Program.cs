using System;

namespace ComputerBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Builder Pattern Demo ***");
            Console.WriteLine("*** We gaan een paar computers bouwen ***");

            var computerConfigurator = new ComputerConfigurator();

            var computer1 = new ComputerBouwer("Klant 1");
            var computer2 = new ComputerBouwer("Klant 2");

            computerConfigurator.BouwVolledigeComputer(computer1);
            var p1 = computer1.GetPc();
            p1.Toon();

            computerConfigurator.BouwComputerZonderGeheugen(computer2);
            var p2= computer2.GetPc();
            p2.Toon();
        }
    }
}

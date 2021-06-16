using System;

namespace visitorPattern
{
    public class Program {
        
        public static void Main(string[] args) {
            Console.WriteLine("***Visitor Pattern Demo***\n");
            var getalVerzameling = new GetalVerzameling();
            getalVerzameling.toonLijst();
            Console.WriteLine();
            var verhoogGetalVisitor = new VerhoogGetalVisitor();
            Console.WriteLine("VerhoogGetalVisitor gaat de lijst bezoeken: ");
            getalVerzameling.visit(verhoogGetalVisitor);
            Console.WriteLine();
            getalVerzameling.toonLijst();
        }
        
    }
}

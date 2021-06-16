using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public class VerhoogGetalVisitor : IVisitor {
        public void visitKleineGetallen(KleinGetal getal) {
            var temp = getal.waarde;
            Console.WriteLine($"{getal.type} is {getal.waarde}; " +
                $"Ik gebruik het als {++temp} voor de rest van mijn code.");
        }
        public void visitGroteGetallen(GrootGetal getal) {
            var temp = getal.waarde;
            Console.WriteLine($"{getal.type} is {getal.waarde}; " +
                $"Ik gebruikt het als {temp + 10} voor de rest van mijn code.");
        }
    }
}


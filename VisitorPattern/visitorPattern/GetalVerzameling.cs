using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public class GetalVerzameling {
        
        private readonly List<Getal> getallenLijst = new List<Getal>();
        public GetalVerzameling() {
            getallenLijst.Add(new KleinGetal("klein-1", 10));
            getallenLijst.Add(new KleinGetal("klein-2", 20));
            getallenLijst.Add(new KleinGetal("klein-3", 30));
            getallenLijst.Add(new GrootGetal("groot-1", 200));
            getallenLijst.Add(new GrootGetal("groot-2", 150));
            getallenLijst.Add(new GrootGetal("groot-3", 70));
        }
        public void voegGetalToeAanLijst(Getal getal) {
            getallenLijst.Add(getal);
        }
        public void toonLijst() {
            Console.WriteLine("Huidige lijst:");
            
            foreach (var getal in getallenLijst) 
                Console.Write(getal.waarde + "\t");
            
            Console.WriteLine();
        }
        public void visit(IVisitor visitor) {
            foreach (var n in getallenLijst)
                n.visit(visitor);
        }
    }
}

using System;

namespace ConsoleApplication3
{
    public class Vierkant: Vorm {
        
        public Vierkant(IKleur kleur) : base(kleur) {
            this.kleur = kleur;
        }

        public new void teken() {
            Console.WriteLine("Ik teken een vierkant in " + kleur.getKleur());
        }
    }
}
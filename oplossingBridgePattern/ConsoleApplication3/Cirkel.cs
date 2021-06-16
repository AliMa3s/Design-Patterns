using System;

namespace ConsoleApplication3
{
    public class Cirkel: Vorm
    {
        public Cirkel(IKleur kleur) : base(kleur) {
            this.kleur = kleur;
        }

        public new void teken() {
            Console.WriteLine("Ik teken een cirkel in " + kleur.getKleur());
        }
    }
}
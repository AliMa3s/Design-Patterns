using System;

namespace ConsoleApplication3
{
    public abstract class Vorm
    {
        public  IKleur kleur;
       
        public Vorm(IKleur kleur) {
            this.kleur = kleur;
        }

        public void teken() {
            Console.WriteLine("Ik teken een vorm in " + kleur.getKleur());
        }

        public void setKleurTint(string tint) {
            kleur.setKleurTint(tint);
        }

        public void setKleurOpacity(double opacity)
        {
            kleur.setKleurOpacity(opacity);
        }
    }
}
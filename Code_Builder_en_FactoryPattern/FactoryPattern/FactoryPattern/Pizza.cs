using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
         protected string naam;
         protected string saus;
         protected string deeg;
         public  void voorbereiden() {
            Console.WriteLine("Voorbereiden van " + naam);
            Console.WriteLine(deeg + " rollen... ");
            Console.WriteLine(saus + " toevoegen ");
        }
        public  void bakken() {
            Console.WriteLine("25 minuten op 350 graden bakken " );
        }
        public virtual void snijden() {
            Console.WriteLine("De  pizza in stukken snijden");
        }
        public  void inpakken() {
            Console.WriteLine("De pizza in een officiele doos plaatsen");
        }
        public  string geefBeschrijving() {
           return "We gaan een " + naam + " maken met " + deeg + " met " + saus;
        }
    }
}

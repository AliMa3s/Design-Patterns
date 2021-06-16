using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    /**
     * De klasse Persoon implementeert de interface IPersoon
     * Dus belooft de klasse Persoon (op zijn plechtige communiezieltje)
     * dat hij de methoden en eigenschappen zal implementeren
     * en zo geschiede...
     * */
    class Persoon : IPersoon
    {
        public string Naam { get;set; }
        
        public int Ouderdom { get; set; }
        
        //we implemeteren deze methode voor het geval
        //dat we een persoon hebben die geen leerkracht, student of directeur is
        //maar door deze methode virtual te maken, mag iedereen die overerft zijn eigen 
        //invulling aan deze methode geven.
        virtual public void DoeUwDing()
        {
            Console.WriteLine("Ik doe iets...");
        }
    }
}

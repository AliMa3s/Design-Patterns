using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    /**
     * De klasse Directeur erft over van Persoon 
     * Dus de klasse directeur heeft ook de eigenschappen ouderdom en naam en de methode DoeUwDing();
     * De directeur wil tonen dat hij geen gewone persoon is en doet zijn eigen ding
     * dus wordt de methode DoeUwDing() in de Persoon klasse overriden
     * Door middel van een constructor kunnen we de eigenschappen al meegeven bij het instantieren van een directeur.
     * */
    class Directeur: Persoon
    {

        //De directeur wil zijn eigen ding kunnen doen 
        //en override dus de methode DoeUwDing()
         override public void DoeUwDing()
        {
            Console.WriteLine("Ik doe niets zoals gewoonlijk...");
        }

        //constructor
        public Directeur(string Naam, int Ouderdom)
        {
            base.Naam = Naam;
            base.Ouderdom = Ouderdom;
        }
    }
}

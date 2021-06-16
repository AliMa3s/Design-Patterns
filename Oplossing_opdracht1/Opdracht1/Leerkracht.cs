using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{

    /**
    * De klasse Leerkracht erft over van Persoon.
    * Dus de klasse Leerkracht heeft ook de eigenschappen ouderdom en naam en de methode DoeUwDing();
    * De leerkracht wil tonen dat hij geen gewone persoon is en doet zijn eigen ding
    * dus wordt de methode DoeUwDing() in de Persoon klasse overriden
    * Door middel van een constructor kunnen we de eigenschappen al meegeven bij het instantieren van een leerkracht.
    * */
    class Leerkracht : Persoon
    {
        //De Leerkracht wil zijn eigen ding kunnen doen 
        //en override dus de methode DoeUwDing()
        public override void DoeUwDing()
        {
            Console.WriteLine("Ik geef les...");
        }

        //constructor
        public Leerkracht(string Naam, int Ouderdom)
        {
            base.Naam = Naam;
            base.Ouderdom = Ouderdom;
        }
    }
}

using System;

namespace Opdracht1
{
    /**
    * De klasse Student erft over van Persoon 
    * Dus de klasse Student heeft ook de eigenschappen ouderdom en naam en de methode DoeUwDing();
    * De student wil tonen dat hij geen gewone persoon is en doet zijn eigen ding
    * dus wordt de methode DoeUwDing() in de Persoon klasse overriden
    * Door middel van een constructor kunnen we de eigenschappen al meegeven bij het instantieren van een student.
    * */
    class Student : Persoon
    {
        //De student wil zijn eigen ding kunnen doen 
        //en override dus de methode DoeUwDing()
        public override void DoeUwDing()
        {
            Console.WriteLine("Ik volg les...");
        }

        //constructor
        public Student(string Naam, int Ouderdom)
        {
            base.Naam = Naam;
            base.Ouderdom = Ouderdom;
        }
    }
}

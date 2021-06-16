using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaHawai : Pizza
    {
        public PizzaHawai()
        {
            naam = "PizzaHawai";
            deeg = "dunne brosse bodem";
            saus = "zonder saus";
        }

        override public void snijden()
        {
            Console.WriteLine("De pizza in vierkante stukken snijden");
        }
    }
}

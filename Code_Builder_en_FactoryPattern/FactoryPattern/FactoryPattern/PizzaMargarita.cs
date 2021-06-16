using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaMargarita: Pizza
    {

        public PizzaMargarita()
        {
            naam = "PizzaMargarita";
            deeg = "extra dikke krokante bodem";
            saus = "zonder saus";
        }

        public override void snijden()
        {
            Console.WriteLine("De pizza in vierkante stukken snijden");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaMargaritaFactory : PizzaFactory
    {
        public override Pizza MaakPizza(EPizza soort)
        {

            Console.WriteLine();
            Pizza pizza = null;

            if (soort.Equals(EPizza.PizzaMargaritaMetJachtsaus))
                pizza = new PizzaMargaritaMetJachtsaus();

            if (soort.Equals(EPizza.PizzaMargaritaMetKaassaus))
                pizza = new PizzaMargaritaMetKaassaus();


            return pizza;
        }
    }
}

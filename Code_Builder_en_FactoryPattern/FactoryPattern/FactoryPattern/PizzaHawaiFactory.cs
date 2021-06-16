using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaHawaiFactory : PizzaFactory
    {
        public override Pizza MaakPizza(EPizza soort)
        {
            Console.WriteLine();
            Pizza pizza = null;

            if (soort.Equals(EPizza.PizzaHawaiMetChocoladeSaus))
                pizza = new PizzaHawaiMetChocoladeSaus();

            if (soort.Equals(EPizza.PizzaHawaiMetTomatenSaus))
                pizza = new PizzaHawaiMetTomatenSaus();

            return pizza;
        }
    }
}

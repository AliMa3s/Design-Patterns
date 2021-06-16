using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaMozarellaFactory : PizzaFactory
    {
        public override Pizza MaakPizza(EPizza soort)
        {
            Pizza pizza = soort switch
            {
                EPizza.PizzaMozarellaMetCurrySaus 
                    => new PizzaMozarellaMetCurrySaus(),
                EPizza.PizzaMozarellaMetTomatenSaus 
                    => new PizzaMozarellaMetTomatenSaus(),
                _ => null
            };
            return pizza;
        }
    }
}

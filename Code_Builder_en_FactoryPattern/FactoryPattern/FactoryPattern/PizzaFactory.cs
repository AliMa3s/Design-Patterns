using System;

namespace FactoryPattern
{
     public abstract class PizzaFactory
    {
        public  static Pizza LeverPizza(EPizza soort){
            if (soort.ToString().Contains("Hawai"))
                return new PizzaHawaiFactory().BestelPizza(soort);
            if (soort.ToString().Contains("Margarita"))
                return new PizzaMargaritaFactory().BestelPizza(soort);
            if (soort.ToString().Contains("Mozarella"))
                return new PizzaMozarellaFactory().BestelPizza(soort);
            
            return null;
        }
        public Pizza BestelPizza(EPizza soort) {
            var pizza = MaakPizza(soort);
            Console.WriteLine(pizza.geefBeschrijving());
            pizza.voorbereiden();
            pizza.bakken();
            pizza.snijden();
            pizza.inpakken();
            return pizza;
        }
        public abstract Pizza MaakPizza(EPizza soort);
    }
}

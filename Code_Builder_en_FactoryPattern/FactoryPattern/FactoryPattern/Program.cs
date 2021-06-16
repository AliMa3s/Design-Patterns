using System;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args) {
            
            var pizza= PizzaFactory.LeverPizza(EPizza.PizzaHawaiMetChocoladeSaus);
             pizza= PizzaFactory.LeverPizza(EPizza.PizzaHawaiMetTomatenSaus);
             pizza= PizzaFactory.LeverPizza(EPizza.PizzaMargaritaMetJachtsaus);
             pizza= PizzaFactory.LeverPizza(EPizza.PizzaMargaritaMetKaassaus);
             pizza= PizzaFactory.LeverPizza(EPizza.PizzaMozarellaMetCurrySaus);
             pizza= PizzaFactory.LeverPizza(EPizza.PizzaMozarellaMetTomatenSaus);
        }

        public Pizza orderPizza(string type) {
            Pizza pizza = type switch
            {
                "PizzaHawaiMetChocoladeSaus" => new PizzaHawaiMetChocoladeSaus(),
                "PizzaHawaiMetTomatenSaus" => new PizzaHawaiMetTomatenSaus(),
                "PizzaMargaritaMetJachtsaus" => new PizzaMargaritaMetJachtsaus(),
                "PizzaMargaritaMetKaassaus" => new PizzaMargaritaMetKaassaus(),
                "PizzaMozarellaMetCurrySaus" => new PizzaMozarellaMetCurrySaus(),
                "PizzaMozarellaMetTomatenSaus" => new PizzaMozarellaMetTomatenSaus(),
                _ => new PizzaMargarita()
            };

            pizza.voorbereiden();
            pizza.bakken();
            pizza.snijden();
            pizza.inpakken();
            return pizza;
        }
    }
}
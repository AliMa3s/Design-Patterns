using System;

namespace FactoryPattern
{
    public class PizzaHawaiMetChocoladeSaus : PizzaHawai
    {
        public PizzaHawaiMetChocoladeSaus()
        {
            naam = "PizzaHawaiMetChocoladeSaus";
            saus = "ChocoladeSaus";
        }
    }
}
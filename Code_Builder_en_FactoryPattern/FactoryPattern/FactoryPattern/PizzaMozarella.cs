using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaMozarella : Pizza {
        
        public PizzaMozarella() {
            naam = "PizzaMozarella";
            deeg = "extra dunne bodem";
            saus = "zonder saus";
        }
        public override void snijden() {
            Console.WriteLine("De pizza in ronde stukken snijden");
        }
    }
    
}

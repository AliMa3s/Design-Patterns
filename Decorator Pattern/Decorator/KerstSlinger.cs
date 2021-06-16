using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
     public class KerstSlinger:Versiering {
         
        private readonly Versiering Versiering;
        public KerstSlinger(Versiering Versiering) {
            this.Versiering = Versiering;
        }
        public string Versier() {
            return Versiering.Versier() + ", met een slinger";
        }
    }
}

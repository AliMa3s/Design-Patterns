using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class KerstBal:Versiering {
        
        private readonly Versiering Versiering;
        private readonly int Aantal;
        public KerstBal(int Aantal, Versiering Versiering) {
            this.Aantal = Aantal;
            this.Versiering = Versiering;
        }
        public string Versier() {
            return Versiering.Versier() + ", met " + Aantal + " kerstballen";
        }
    }
}

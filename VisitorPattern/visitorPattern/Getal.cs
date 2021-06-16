using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public abstract class Getal {
        
        public readonly int waarde;
        public readonly string type;

        protected Getal(string type, int waarde) {
            this.type = type;
            this.waarde = waarde;
        }
        public abstract void visit(IVisitor visitor);
    }
}

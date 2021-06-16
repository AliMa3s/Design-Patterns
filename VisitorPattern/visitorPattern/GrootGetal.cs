using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public class GrootGetal: Getal {
        public GrootGetal(string type, int waarde) : 
            base(type, waarde){ }
        public override void visit(IVisitor visitor) {
            visitor.visitGroteGetallen(this);
        }
    }
}

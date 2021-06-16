using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public class KleinGetal:Getal {
        public KleinGetal(string type, int number) :
            base(type, number){ }
        public override void visit(IVisitor visitor) {
            visitor.visitKleineGetallen(this);
        }
    }
}

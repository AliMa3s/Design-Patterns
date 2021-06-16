using System;
using System.Collections.Generic;
using System.Text;

namespace visitorPattern
{
    public interface IVisitor {
        void visitKleineGetallen(KleinGetal getal);
        void visitGroteGetallen(GrootGetal getal);
    }
}

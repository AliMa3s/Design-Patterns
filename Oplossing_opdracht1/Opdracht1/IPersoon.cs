using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
   /**
    * Al wie deze interface implementeert,
    * belooft de eigenschappen naam en ouderdom te bezitten
    * en de methode DoeUwDing te implementeren.
    * */
    interface IPersoon
    {
      string Naam { get; set; }
      int Ouderdom { get; set; }

      void DoeUwDing();
    }
}

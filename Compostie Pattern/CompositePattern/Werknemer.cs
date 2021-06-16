using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
     public class Werknemer: IWerknemer {
        public string naam { get; set; }
        public string afdeling { get; set; }
        public string aanstelling { get; set; }
        public void toonDetails() {
            Console.WriteLine($"\t{naam} werkt in " +
                $"{ afdeling}. Aanstelling: { aanstelling} ");
        }
     }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public interface IWerknemer {
        string naam { get; set; }
        string afdeling { get; set; }
        string aanstelling { get; set; }
        void toonDetails();
    }
}

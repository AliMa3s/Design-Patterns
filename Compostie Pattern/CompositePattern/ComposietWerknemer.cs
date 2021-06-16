using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class ComposietWerknemer : IWerknemer
    {
        public string naam { get; set; }
        public string afdeling { get; set; }
        public string aanstelling { get; set; }

        private readonly List<IWerknemer> ondergeschiktenLijst
            = new List<IWerknemer>();

        public void voegWerknemerToe(IWerknemer e)
        {
            ondergeschiktenLijst.Add(e);
        }

        public void verwijderWerknemer(IWerknemer e)
        {
            ondergeschiktenLijst.Remove(e);
        }

        public void toonDetails()
        {
            Console.WriteLine($"\n{naam} werkt in {afdeling}." +
                              $" Aanstelling: {aanstelling} ");

            foreach (var e in ondergeschiktenLijst)
                e.toonDetails();
        }
    }
}
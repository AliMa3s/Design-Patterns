using System;

namespace ComputerBuilder
{
    public class Computer {
        
        private readonly System.Collections.ArrayList _onderdelen;
        public Computer() {
            _onderdelen = new System.Collections.ArrayList();
        }
        public void voegOnderdeelToe(string part) {
            _onderdelen.Add(part);
        }
        public void Toon() {
            Console.WriteLine("\nDe Computer bevat volgende onderdelen:");
            foreach (string onderdeel in _onderdelen)
                Console.WriteLine(onderdeel);
            Console.WriteLine("Vergeet niet de sticker van de firma op de computer te kleven!");
        }
    }

}


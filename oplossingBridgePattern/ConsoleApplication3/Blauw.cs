using System;
using System.Management.Instrumentation;

namespace ConsoleApplication3
{
    public class Blauw : IKleur
    {
        
        private readonly string kleur = "blauw";
        private string tint = "licht";
        private double opacity;
        
        public string getKleur() {
            return tint + kleur + " met opacity: " + opacity;
        }

        public void setKleurTint(string nieuweTint) {
            tint = nieuweTint;
        }

        public void setKleurOpacity(double nieuwOpacity) {
            opacity = nieuwOpacity;
        }
    }
}
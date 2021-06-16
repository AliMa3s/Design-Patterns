namespace ConsoleApplication3
{
    public class Groen: IKleur
    {
        private const string kleur = "groen";
        private string tint = "licht";
        private double opacity = 0.5;
        
        
        public string getKleur() {
            return tint + kleur + " met opacity: " + opacity;
        }

        public void setKleurTint(string nieuweTint)
        {
            tint = nieuweTint;
        }

        public void setKleurOpacity(double nieuwOpacity)
        {
            opacity = nieuwOpacity;
        }
    }
}
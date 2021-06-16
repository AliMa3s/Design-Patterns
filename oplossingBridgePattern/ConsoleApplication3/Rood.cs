namespace ConsoleApplication3
{
    public class Rood: IKleur
    {
        private const string kleur = "rood";
        private  string tint = "licht";
        private  double opacity = 0.3;

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
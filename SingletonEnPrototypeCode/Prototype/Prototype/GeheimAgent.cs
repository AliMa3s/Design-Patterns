using System;

namespace Prototype
{
    [Serializable]
    public class GeheimAgent
    {
        public Wapen Wapen = new Wapen();
        public Zonnebril Zonnebril=new Zonnebril();
        public string Naam;
        public  GeheimAgent Clone() {
            return (GeheimAgent) 
                this.MemberwiseClone();
        }
        public GeheimAgent(string naam) {
            this.Naam = naam;
        }
    }
}

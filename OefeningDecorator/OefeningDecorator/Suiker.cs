namespace ConsoleApplication2
{
    public class Suiker
    {
        private IDrank drank;
        private const double Prijs = 0.2;
        
        public Suiker(IDrank drank)
        {
            this.drank = drank;
        }
        
        public string getOmschrijving()
        {
            return  drank.getOmschrijving() + " met suiker";
        }
        
        public double getPrijs()
        {
            return  drank.getPrijs() + Prijs;
        }
    }
}
namespace ConsoleApplication2
{
    public class Melk: IDrank
    {

        private IDrank drank;
        private const double Prijs = 0.1;

        public Melk(IDrank drank)
        {
            this.drank = drank;
        }
        
        public string getOmschrijving()
        {
            return  drank.getOmschrijving() + " met melk";
        }

        public double getPrijs()
        {
            return  drank.getPrijs() + Prijs;
        }
    }
}
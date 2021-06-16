namespace ConsoleApplication2
{
    public class Koffie: IDrank
    {
        private const double Prijs = 1.5;

        public string getOmschrijving()
        {
          return  "Een lekker geurende koffie";
        }

        public double getPrijs()
        {
            return Prijs;
        }
        
    }
}
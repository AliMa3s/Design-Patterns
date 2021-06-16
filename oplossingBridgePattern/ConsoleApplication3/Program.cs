namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cirkel = new Cirkel(new Blauw());
            cirkel.teken();
            cirkel.setKleurTint("donker");
            cirkel.setKleurOpacity(.22);
            cirkel.teken();
            var cirkel2 = new Cirkel(new Rood());
            cirkel2.teken();

        }
    }
}
using System;

namespace ComputerBuilder
{
    public class ComputerBouwer : IComputerBouwer {
        
        private readonly Computer _computer;
        private readonly string _klant;
        public ComputerBouwer(string klant){
            _computer = new Computer();
            _klant = klant;
        }
        public void StartBouwPc(){ 
            Console.WriteLine("\nWe starten met een de bouw van een pc voor: " + _klant);
        }
        public Computer GetPc(){return _computer;}

        public void StopBouwPc(){Console.WriteLine("PC is geassembleerd!");}

        public void VoegGeheugenToe() {
            _computer.voegOnderdeelToe("4 latjes geheugen van 4 GB...");
        }
        public void VoegGrafischeKaartToe() {
            _computer.voegOnderdeelToe("Een Razor 3000 is toegevoegd...");
        }
        public void VoegProcessorToe(){
            _computer.voegOnderdeelToe("Een Intel I9 7920 toegevoegd...");
        }
        public void VoegVoedingToe() {
            Console.WriteLine("Welk merk van voeding wil je?");
            var merk=Console.ReadLine();
            Console.WriteLine("Welk vermogen wil je?");
            var vermogen =Console.ReadLine();
            var voeding = new Voeding(vermogen,merk);
            _computer.voegOnderdeelToe("Je hebt een voeding van " + voeding.Vermogen +
                                       " Watt gekozen van het merk: " + voeding.Merk);
        }
    }
}
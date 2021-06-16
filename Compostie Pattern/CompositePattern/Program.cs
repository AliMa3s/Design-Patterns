using System;

namespace CompositePattern
{
    public class Program
    {
        public static void Main(string[] args) {
            
            Console.WriteLine("***Composite Pattern Demo. ***");
            
            var hoofdWiskunde = new ComposietWerknemer {naam ="Mevr Rita Vermeulen", afdeling = "Wiskunde", aanstelling = "Hoofd-Wiskunde"};
            var wiskundeLector1 = new Werknemer {naam = "Leo Verstappen", afdeling ="Wiskunde", aanstelling = "Lector"};
            var wiskundeLector2 = new Werknemer {naam = "Peter Boonen", afdeling ="Wiskunde", aanstelling = "Lector"};
           
            hoofdWiskunde.voegWerknemerToe(wiskundeLector1);
            hoofdWiskunde.voegWerknemerToe(wiskundeLector2);
     
            var hoofdComputerWetenschappen = new ComposietWerknemer 
                {naam = "Luc Vervoort", afdeling = "Computerwetenschappen", aanstelling = "Hoofd-Computerwetenschappen"};
            var computerWetenschappenLector1 = new Werknemer {naam = "Dirk Wuytack", afdeling ="Computerwetenschappen", aanstelling = "Lector"};
            var computerWetenschappenLector2 = new Werknemer {naam = "David Breckx", afdeling = "Computerwetenschappen", aanstelling = "Lector"};
            var computerWetenschappenLector3 = new Werknemer {naam = "Annick Burms", afdeling ="Computerwetenschappen", aanstelling = "Lector"};
         
            hoofdComputerWetenschappen.voegWerknemerToe(computerWetenschappenLector1);
            hoofdComputerWetenschappen.voegWerknemerToe(computerWetenschappenLector2);
            hoofdComputerWetenschappen.voegWerknemerToe(computerWetenschappenLector3);
     
            var directeur = new ComposietWerknemer {naam = "Koen Goethals", afdeling = "Management", aanstelling = "Directeur"};
      
            directeur.voegWerknemerToe(hoofdWiskunde);
            directeur.voegWerknemerToe(hoofdComputerWetenschappen);
      
            Console.WriteLine("\nDetails directeur:");
            directeur.toonDetails();
            
            hoofdComputerWetenschappen.verwijderWerknemer(computerWetenschappenLector2);
            Console.WriteLine("\nNa het ontslag van David Breckx heeft de organisatie de volgende leden: ");
            
            directeur.toonDetails();
        }
    }
}

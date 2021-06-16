using System;
using System.Collections;

namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            var agent = new GeheimAgent("Dirk Wuytack");
            agent.Wapen.Merk = "Beretta";
            agent.Wapen.TypeKogel = ".45";
            agent.Wapen.LengteLoop = 22;
            agent.Zonnebril.Merk = "RayBan";
            agent.Zonnebril.TypeGlas = "donker";
            agent.Zonnebril.Prijs = 500;

            var mi6 = new ArrayList();

            for (var x = 1; x < 500; x++) {
                var gehAgent = agent.Clone();
                gehAgent.Naam = x.ToString();
                mi6.Add(gehAgent);
            }

            foreach (GeheimAgent geheimAgent in mi6)
                Console.WriteLine("Geheim Agent " + geheimAgent.Naam +
                                  " aangemaakt. Uitrusting wapen: "
                                  + geheimAgent.Wapen.Merk + ' ' +
                                  geheimAgent.Wapen.TypeKogel +
                                  " met een loop van " + geheimAgent.Wapen.LengteLoop +
                                  "cm en een zonnebril merk " +
                                  geheimAgent.Zonnebril.Merk +
                                  " met " + geheimAgent.Zonnebril.TypeGlas +
                                  " glazen met een prijs van " +
                                  geheimAgent.Zonnebril.Prijs + " Euro");


            agent.Zonnebril.Prijs = 200;


            foreach (GeheimAgent geheimAgent in mi6)
                Console.WriteLine("Geheim Agent " + geheimAgent.Naam +
                                  " aangemaakt. Uitrusting wapen: "
                                  + geheimAgent.Wapen.Merk + ' ' +
                                  geheimAgent.Wapen.TypeKogel +
                                  " met een loop van " + geheimAgent.Wapen.LengteLoop +
                                  "cm en een zonnebril merk " +
                                  geheimAgent.Zonnebril.Merk +
                                  " met " + geheimAgent.Zonnebril.TypeGlas +
                                  " glazen met een prijs van " +
                                  geheimAgent.Zonnebril.Prijs + " Euro");
        }
    }
}
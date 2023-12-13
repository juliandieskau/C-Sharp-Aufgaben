using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm, welches drei Fakten über zwei Tier ausgeben soll wenn man den jeweiligen 
    /// Namen des Tieres eingibt.
    /// </summary>
    public class Aufgabe4 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 4: 3 Fakten über Tiere");
            Console.WriteLine("#################################\n");

            string tier = "";
            Console.WriteLine("Gebe ein Tier ein: (Tipp: Elefanten und Schildkröten sind toll.)");
            try
            {
                string? input = Console.ReadLine();
                if (input != null)
                {
                    tier = input;
                    tier.ToLower();
                    tier.Trim();
                    Console.WriteLine("");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            switch (tier)
            {
                case "elefant":
                case "elefanten":
                    Console.WriteLine("Ein Elefant im Porzellanladen ist nicht die beste Idee");
                    Console.WriteLine("Ein Elefant wiegt bis zu 5t.");
                    Console.WriteLine("Elefanten haben sogar eigene Friedhöfe.");
                    break;
                case "schildkröte":
                case "schildkröten":
                    Console.WriteLine("Schildkröten können an Strohhalmen in der Nase sterben.");
                    Console.WriteLine("Schildkröten können sehr interessante Geräusche machen.");
                    Console.WriteLine("Schildkröten sind schneller als man denkt.");
                    break;
                default:
                    Console.WriteLine("Über dieses Tier ist nichts bekannt.");
                    break;
            }
        }
    }
}

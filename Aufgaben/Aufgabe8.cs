using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Dieses Programm soll ein einfaches Glücksspiel simulieren. 
    /// 
    /// Wenn der Bediener auf Enter drückt, sollen 2 Zufallszahlen zwischen 1-6 angezeigt werden(eine ist
    /// die Bediener-Zahl und die andere ist die System-Zahl). 
    /// 
    /// Wenn die Bediener-Zahl größer als die System-Zahl ist, dann soll 'Sie haben gewonnen' erscheinen.
    /// Wenn die Bediener-Zahl kleiner als die System-Zahl ist, dann soll 'Sie haben verloren' erscheinen.
    /// 
    /// Beim Enter drücken wird das Spiel erneut gestartet.
    /// </summary>
    public class Aufgabe8 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 8: Würfle gegen das System!");
            Console.WriteLine("#################################\n");

            Console.WriteLine("Drücke [enter] um zu starten...");
            Random rnd = new Random();

            while (Console.ReadLine() == "")
            {
                int bedienerZahl = rnd.Next(1, 7);
                int systemZahl = rnd.Next(1, 7);
                Console.WriteLine("Bediener-Zahl {0} - {1} System-Zahl", bedienerZahl, systemZahl);
                string ausgabe = bedienerZahl > systemZahl ? "Sie haben gewonnen!" : "Sie haben verloren!";
                string muster = " $$$ ";
                Console.WriteLine(muster + ausgabe + muster);
                Console.WriteLine("\nDrücke [enter] um neuzustarten...");
            }
        }
    }
}

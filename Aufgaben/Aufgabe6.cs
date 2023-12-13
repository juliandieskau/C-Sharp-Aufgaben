using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm welches Zahlen von 0 bis 100 ausgibt. 
    /// Ergänze das Programm so, dass die Zahlen von 50 bis 100 negativen ausgegeben werden.
    /// </summary>
    public class Aufgabe6 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 6: Gebe Zahlen von 1 bis 49 und -50 bis -100 aus.");
            Console.WriteLine("#################################\n");

            const int MAX = 50;
            const int MIN = -100;
            int i = 0;
            while (i < MAX)
            {
                Console.WriteLine(i++);
            }
            i = -i;
            while (i >= MIN)
            {
                Console.WriteLine(i--);
            }
        }
    }
}

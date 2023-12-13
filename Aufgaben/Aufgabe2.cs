using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm welches zwei Zahlen miteinander addiert und dann ausgibt.
    /// Ergänze dann das Programm damit zwei vom Benutzter eingegebene Zahlen addiert werden.
    /// (Der Benutzer soll dazu aufgefordert werden)
    /// </summary>
    public class Aufgabe2 : IAufgabe
    {

        public void run()
        {
            Console.WriteLine("Aufgabe 2: Addiere 2 Zahlen");
            Console.WriteLine("#################################\n");

            Console.WriteLine("Gib eine Zahl ein:");
            string? str1 = Console.ReadLine();
            Console.WriteLine("Gib eine Zahl ein:");
            string? str2 = Console.ReadLine();

            int zahl1 = 0;
            int zahl2 = 0;
            try
            {
                zahl1 = Convert.ToInt32(str1);
                zahl2 = Convert.ToInt32(str2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + (zahl1 + zahl2));
        }
    }
}

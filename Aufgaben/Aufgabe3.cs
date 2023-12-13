using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm, welches den Benutzer auffordert, zwei Zahlen einzugeben, diese sollen 
    /// miteinander addiert, subtrahiert, multipliziert und dividiert und die Ergebnisse ausgibt.
    /// </summary>
    public class Aufgabe3 : IAufgabe
    {

        public void run()
        {
            Console.WriteLine("Aufgabe 3: Zwei Zahlen auf die alle Standard-Rechen-Operationen ausgeführt werden");
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

            Console.WriteLine("Ergebnisse:");
            Console.WriteLine(addiert(zahl1, zahl2));
            Console.WriteLine(subtrahiert(zahl1, zahl2));
            Console.WriteLine(multipliziert(zahl1, zahl2));
            Console.WriteLine(dividiert(zahl1, zahl2));
            Console.WriteLine(rest(zahl1, zahl2));
        }

        public static string addiert(int x, int y)
        {
            int sum = x + y;
            return x + " + " + y + " = " + sum;
        }

        public static string subtrahiert(int x, int y)
        {
            int diff = x - y;
            return x + " - " + y + " = " + diff;
        }

        public static string multipliziert(int x, int y)
        {
            int prod = x * y;
            return x + " * " + y + " = " + prod;
        }

        public static string dividiert(int x, int y)
        {
            if (y == 0)
            {
                return "Division by 0 is undefined.";
            }
            int quot = x / y;
            return x + " / " + y + " = " + quot;
        }

        public static string rest(int x, int y)
        {
            if (y == 0)
            {
                return "Division by 0 is undefined.";
            }
            int rest = x % y;
            return x + " % " + y + " = " + rest;
        }
    }
}

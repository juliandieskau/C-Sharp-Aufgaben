using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm, das den Benutzer auffordert, zwei Zahlen und einen Operator einzugeben. 
    /// Nach der Eingabe sollen die zwei Zahlen mit dem gewählten Operator gerechnet werden.
    /// </summary>
    public class Aufgabe5 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 5: Gebe Zwei Zahlen und Operator ein und berechne diese.");
            Console.WriteLine("#################################\n");

            int a = 0;
            int b = 0;
            string op = "";
            try
            {
                Console.WriteLine("Gib eine Zahl ein:");
                string? x = Console.ReadLine();
                Console.WriteLine("Gib eine Zahl ein:");
                string? y = Console.ReadLine();
                Console.WriteLine("Gib einen Operator ein:");
                string? o = Console.ReadLine();

                if (x == null || y == null || op == null)
                {
                    throw new ArgumentNullException("null exception");
                }
                else
                {
                    a = Convert.ToInt32(x);
                    b = Convert.ToInt32(y);
                    op = o;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine(Aufgabe3.addiert(a, b));
                    break;
                case "-":
                    Console.WriteLine(Aufgabe3.subtrahiert(a, b));
                    break;
                case "*":
                    Console.WriteLine(Aufgabe3.multipliziert(a, b));
                    break;
                case "/":
                    Console.WriteLine(Aufgabe3.dividiert(a , b));
                    break;
                case "%":
                    Console.WriteLine(Aufgabe3.rest(a, b));
                    break;
                default:
                    Console.WriteLine("Oops - something went wrong.");
                    break;
            }
        }
    }
}

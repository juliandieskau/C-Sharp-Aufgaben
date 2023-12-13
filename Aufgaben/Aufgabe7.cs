using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm, welches 3 Zufallszahlen von 1 bis 10 erzeugen soll und diese dann ausgibt. 
    /// Danach soll der Durchschnitt dieser drei Zahlen berechnet werden und dieser auch ausgegeben werden.

    /// </summary>
    public class Aufgabe7 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 7: Generiere Zufallszahlen zwischen 1 und 10");
            Console.WriteLine("#################################\n");

            // Wähle wie viele Zufallszahlen generiert werden sollen
            Console.Write("Wie viele Zufallszahlen: ");
            long length = 0;
            try
            {
                string? l = Console.ReadLine();
                length = Convert.ToInt64(l);

                if (length > Array.MaxLength)
                {
                    throw new OutOfMemoryException("Zu viele Zahlen!");
                }
                if (length <= 0)
                {
                    throw new OverflowException("Mehr als 0 Zahlen erfordert!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Wähle default = 3");
                length = 3;
            }
            Console.WriteLine("");

            // Generiere Zufallszahlen jedes mal, wenn Enter gedrückt wurde
            double total = 0.0;
            long loops = 0;

            do
            {
                // Generiere die gegebene Anzahl an Zufallszahlen und gebe diese aus
                var rand = new Random();
                int[] randomNumbers = new int[length];
                long sum = 0;

                Console.WriteLine("{0} Zufallszahlen zwischen 1 und 10:", length);
                for (int i = 0; i < length; i++)
                {
                    randomNumbers[i] = rand.Next(1, 11);
                    if (length < 1000)
                    {
                        Console.Write(randomNumbers[i]);
                    }
                    

                    if (!(i == length - 1))
                    {
                        if (length < 1000)
                        {
                            Console.Write(", ");
                        }
                    }
                    sum += randomNumbers[i];
                }

                loops++;
                double median = (double)sum / (double)length;
                total += median;
                if (sum % length != 0)
                {
                    Console.WriteLine("\nDurchschnitt: {0:N4}", median);
                }
                else
                {
                    Console.WriteLine("\nDurchschnitt: {0:N0}", median);
                }
            }
            while (Console.ReadLine() == "");

            double totalMean = total / (double) (loops);
            Console.WriteLine("\nDurchschnitt: {0:N4}", totalMean);
        }
    }
}

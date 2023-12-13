using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm, welches ein Array mit 20 Stellen mit Zufallszahlen füllt. 
    /// Die Zahlen sollen dann nach Größe sortiert werden und ausgegeben werden.
    /// </summary>
    public class Aufgabe9 : IAufgabe
    {
        // Zeit in ms, die zu warten ist beim Sortieren
        private const int WAIT_TIME = 10;

        public void run()
        {
            Console.WriteLine("Aufgabe 9: Zufallszahlen sortieren");
            Console.WriteLine("#################################\n");

            Random rnd = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = rnd.Next(0, Int32.MaxValue);
                numbers[i] = warp(x) / (i + 1);
            }

            // Array unsortiert einmal anzeigen
            print(numbers);

            // Enter drücken um sortieren zu starten
            Console.WriteLine("Drücke [enter] um Sortieren zu starten...");
            if (Console.ReadLine() != null)
            {
                ClearCurrentConsoleLine();
                Console.WriteLine("");

                // BubbleSort und Schritte jeweils ausgeben
                // src: https://de.wikipedia.org/wiki/Bubblesort#Algorithmus
                int size = numbers.Length;
                bool swapped = false;
                do
                {
                    swapped = false;
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            // Vertausche Elemente
                            int temp = numbers[i];
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = temp;
                            swapped = true;
                        
                            // Gebe neues Array aus nach Veränderung
                            print(numbers);

                            // Warte bis nächsten Frame anzeigen
                            Thread.Sleep(WAIT_TIME);
                        }
                    }
                    size--;
                }
                while (swapped);
            }
        }

        // Zufallszahlen bearbeiten um schöneren Verlauf zu erhalten
        private int warp(int x)
        {
            double dX = (double)x;
            return Convert.ToInt32(Math.Sqrt(dX));
        }

        // Ausgabe des Arrays
        private void print(int[] num)
        {
            // Konsolen Fenster zurücksetzen für jeden neuen Frame
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
                if (i != num.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("\n");
        }

        // Konsolenfenster refreshen ohne flickern zu verursachen
        // src: https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}

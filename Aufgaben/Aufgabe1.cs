using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    /// <summary>
    /// Erstelle ein Programm welches „Hello World“ in der Console ausgibt.
    /// </summary>
    public class Aufgabe1 : IAufgabe
    {
        public void run()
        {
            Console.WriteLine("Aufgabe 1: Hello World");
            Console.WriteLine("#################################\n");

            Console.WriteLine("Hello World");
        }
    }
}

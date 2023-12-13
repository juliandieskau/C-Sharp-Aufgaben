// program
using System;
using System.Runtime.CompilerServices;

namespace Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen initialisieren
            int intAufgabe = 0;
            IAufgabe? aufgabe = null;

            // Aufgabe auswählen
            while (intAufgabe == 0)
            {
                // Aufgabe ermitteln
                try
                {
                    Console.WriteLine("Gib eine Aufgabe an. Schließe das Programm mit\"0\"");
                    Console.WriteLine(printMenu());
                    Console.Write("\nAufgabe: ");
                    string? strAufgabe = Console.ReadLine();
                    intAufgabe = Convert.ToInt32(strAufgabe);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Aufgabe muss eine Zahl sein.");
                    // switch soll in default springen
                    intAufgabe = -1;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Zu große Zahl.");
                }

                // Aufgabe zuweisen
                switch(intAufgabe)
                {
                    case 0:
                        // Beende Programm -> Schleife über intAufgabe beendet wenn intAufgabe = 0
                        aufgabe = null;
                        intAufgabe = -1;
                        Console.WriteLine("Terminating process...");
                        break;
                    case 1:
                        aufgabe = new Aufgabe1(); 
                        break;
                    case 2:
                        aufgabe = new Aufgabe2();
                        break;
                    case 3:
                        aufgabe = new Aufgabe3();
                        break;
                    case 4:
                        aufgabe = new Aufgabe4();
                        break;
                    case 5:
                        aufgabe = new Aufgabe5();
                        break;
                    case 6:
                        aufgabe = new Aufgabe6();
                        break;
                    case 7:
                        aufgabe = new Aufgabe7();
                        break;
                    case 8:
                        aufgabe = new Aufgabe8();
                        break;
                    case 9:
                        aufgabe = new Aufgabe9();
                        break;
                    case 10:
                        aufgabe = new Aufgabe10();
                        break;
                    default:
                        // Aufgabe zurücksetzen und neu abfragen
                        Console.WriteLine("Diese Aufgabe ist nicht vorhanden.");
                        intAufgabe = 0;
                        break;
                }
            
                // Aufgabe ausführen, wenn gültige ausgewählt, nach Ausführung in nächste Auswahlschleife gehen
                if (aufgabe != null && intAufgabe != 0)
                {
                    // Aufgabe ausführen
                    Console.Clear();
                    aufgabe.run();

                    // Beenden der Aufgabe behandeln
                    Console.WriteLine("\n#################################");
                    Console.WriteLine("Drücke [enter] um eine neue Aufgabe auszuwählen oder Gebe [\"exit\"|\"e\"] ein um das Programm zu beenden.");

                    // Auf Bestätigung warten, um Fenster zurückzusetzen
                    string? close = Console.ReadLine();
                    if ( close == "exit" || close == "e" )
                    {
                        Console.WriteLine("Terminating process...");
                    }
                    else if (close != null)
                    {
                        // Aufgabe und Konsole zurücksetzen
                        intAufgabe = 0;
                        aufgabe = null;
                        Console.Clear();
                    }
                }
            }
        }
        
        private static string printMenu()
        {
            string menu = "Aufgabe 1: Hello World\n";
            menu += "Aufgabe 2: Zwei Zahlen addieren\n";
            menu += "Aufgabe 3: Grundrechenarten auf zwei Zahlen";
            menu += "Aufgabe 4: Drei Fakten über zwei Tiere\n";
            menu += "Aufgabe 5: Operator für zwei Zahlen wählen\n";
            menu += "Aufgabe 6: Zahlen von 0 bis 50 bis -100\n";
            menu += "Aufgabe 7: Zufallszahlen mit deren Durchschnitt\n";
            menu += "Aufgabe 8: Glücksspiel gegen den Computer\n";
            menu += "Aufgabe 9: Zufallszahlen sortieren - BubbleSort animiert\n";
            menu += "Aufgabe 10: 10 Erinnerungen speichern";
            return menu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Aufgaben
{
    public class Aufgabe10 : IAufgabe
    {
        private const int MAX = 10; // maximale Anzahl an Erinnerungen
        private const string PATH = @"C:\Users\HH-SoSo-2\Desktop\MyFolder\Basics\Aufgaben\Aufgaben\";
        private const string FILE = "Erinnerungen.json";
        private string[]? erinnerungen;

        enum STATE
        {
            MENU,
            SHOW,
            ADD,
            DELETE,
            EXIT
        }

        /// <summary>
        /// Erstelle ein Programm, in dem 10 Erinnerungen gespeichert werden können. Verwende dabei ein Array.
        /// </summary>
        public void run()
        {
            Console.WriteLine("Aufgabe 10: Erinnerungen verwalten");
            Console.WriteLine("#################################\n");

            erinnerungen = new string[MAX];
            Array.Fill<string>(erinnerungen, "");
            STATE state = STATE.MENU;
            bool exit = false;

            while (!exit)
            {
                switch (state)
                {
                    case STATE.MENU:
                        print(printMenu());
                        state = stateMenu();
                        break;
                    case STATE.SHOW:
                        print(printShow());
                        state = stateShow();
                        break;
                    case STATE.ADD:
                        print(printAdd());
                        state = stateAdd();
                        break;
                    case STATE.DELETE:
                        print(printDelete());
                        state = stateDelete();
                        break;
                    case STATE.EXIT:
                        exit = true;
                        break;
                }
            }
        }

        private void print(string output)
        {
            Console.Clear();
            Console.WriteLine("Aufgabe 10: Erinnerungen verwalten");
            Console.WriteLine("#################################\n");
            Console.WriteLine(output);
        }

        private STATE stateMenu()
        {
            string? input = "";
            try
            {
                input = Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            switch (input)
            {
                case "1":
                    return STATE.SHOW;
                case "2":
                    return STATE.ADD;
                case "3":
                    return STATE.DELETE;
                case "4":
                case "exit":
                    return STATE.EXIT;
                default:
                    Console.WriteLine("Keine gültige Eingabe.");
                    if (Console.ReadLine() != null)
                    {
                        return STATE.MENU;
                    }
                    return STATE.MENU;
            }
        }

        private string printMenu()
        {
            string s0 = "Auswahlmenü:\n";
            string s1 = "[1] Erinnerungen anzeigen\n";
            string s2 = "[2] Erinnerungen hinzufügen\n";
            string s3 = "[3] Erinnerungen löschen\n";
            string s4 = "[4] Aufgabe verlassen\n";
            string s5 = readFromFile() + "\n";
            return s0 + s1 + s2 + s3 + s4 + s5 +"\n";
        }

        private STATE stateShow()
        {
            while (true)
            {
                string? input = "";
                try
                {
                    input = Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (input != null)
                {
                    return STATE.MENU;
                }
            }
        }

        private string printShow()
        {
            string s = "Erinnerungen anzeigen:\n";
            for (int i = 0; i < erinnerungen.Length; i++)
            {
                if (erinnerungen[i] != "")
                {
                    s += "Erinnerung " + Convert.ToString(i + 1) + ": ";
                    s += erinnerungen[i];
                    s += "\n";
                }
            }
            return s;
        }

        private STATE stateAdd()
        {
            while (true)
            {
                string? input = "";
                try
                {
                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (input)
                {
                    case "":
                        return STATE.MENU;
                    case null:
                        break;
                    default:
                        for (int i = 0; i < erinnerungen.Length; i++)
                        {
                            if (erinnerungen[i] == "")
                            {
                                erinnerungen[i] = input;
                                Console.WriteLine(saveToFile());
                                Console.ReadLine();
                                return STATE.ADD;
                            }
                        }
                        Console.WriteLine("Die 10 Erinnerungen sind schon voll!");
                        if (Console.ReadLine() != null)
                        {
                            return STATE.MENU;
                        }
                        return STATE.MENU;
                }
            }
        }

        private string printAdd()
        {
            string s = "Erinnerungen hinzufügen:\n";
            s += "Drücke [enter] um zum Menü zurückzukehren.\n";
            s += "Bitte Text eingeben und mit [enter] bestätigen: ";
            return s;
        }

        private STATE stateDelete()
        {
            while (true)
            {
                string? input = "";
                try
                {
                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (input)
                {
                    case "":
                        return STATE.MENU;
                    case null:
                        break;
                    default:
                        int value = Convert.ToInt32(input) - 1;
                        erinnerungen[value] = "";
                        Console.WriteLine("Erinnerung {0} gelöscht!", input);
                        if (Console.ReadLine != null)
                        {
                            return STATE.MENU;
                        }
                        return STATE.MENU;
                }
            }
        }

        private string printDelete()
        {
            string s = "Erinnerungen entfernen:\n";
            s += "Drücke [enter] um zum Menü zurückzukehren.\n";
            s += "Bitte Nummer [1-10] der Erinnerung eingeben, die gelöscht werden soll: ";
            return s;
        }

        // Erinnerungen in JSON-Datei speichern
        private string saveToFile()
        {
            var erinnerungenFile = new ErinnerungenFile
            {
                Erinnerung1 = erinnerungen[0],
                Erinnerung2 = erinnerungen[1],
                Erinnerung3 = erinnerungen[2],
                Erinnerung4 = erinnerungen[3],
                Erinnerung5 = erinnerungen[4],
                Erinnerung6 = erinnerungen[5],
                Erinnerung7 = erinnerungen[6],
                Erinnerung8 = erinnerungen[7],
                Erinnerung9 = erinnerungen[8],
                Erinnerung10 = erinnerungen[9],
            };

            string jsonString = JsonSerializer.Serialize(erinnerungenFile);
            try
            {
                File.WriteAllText(PATH + FILE, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erinnerung konnte nicht lokal gespeichert werden.");
            }

            return "Erinnerungen gespeichert!";
        }

        private string readFromFile()
        {
            try
            {
                string jsonString = File.ReadAllText(PATH + FILE);
                ErinnerungenFile saved = JsonSerializer.Deserialize<ErinnerungenFile>(jsonString)!;
                erinnerungen[0] = saved.Erinnerung1;
                erinnerungen[1] = saved.Erinnerung2;
                erinnerungen[2] = saved.Erinnerung3;
                erinnerungen[3] = saved.Erinnerung4;
                erinnerungen[4] = saved.Erinnerung5;
                erinnerungen[5] = saved.Erinnerung6;
                erinnerungen[6] = saved.Erinnerung7;
                erinnerungen[7] = saved.Erinnerung8;
                erinnerungen[8] = saved.Erinnerung9;
                erinnerungen[9] = saved.Erinnerung10;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Erinnerungen konnten nicht geladen werden!";
            }
            return "Erinnerungen erfolgreich wiederhergestellt!";
        }

        public class ErinnerungenFile {
            public string? Erinnerung1 { get; set; }
            public string? Erinnerung2 { get; set; }
            public string? Erinnerung3 { get; set; }
            public string? Erinnerung4 { get; set; }
            public string? Erinnerung5 { get; set; }
            public string? Erinnerung6 { get; set; }
            public string? Erinnerung7 { get; set; }
            public string? Erinnerung8 { get; set; }
            public string? Erinnerung9 { get; set; }
            public string? Erinnerung10 { get; set; }
        }
    }
}

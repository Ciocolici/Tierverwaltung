using Tierverwaltung.Tiertypen;

namespace Tierverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aufgabe Tierverwaltung (Konsoleapp)
             * 
             * + Verschiedene Tiertypen sollen angelegt werden. (Elefant, Giraffe...)
             * ++ Zähler für jeweiligen Bestand (und aller Tiere)
             * 
             * + die Klassen
             * ++ sollen über (mindestens einen) Konstruktor verfügen
             * ++ über Eigenschaften verfügen: also gekapselte Daten. Spielen Sie mit den Möglichkeiten.
             * +++ Konstante MinimalgewichtElefant...
             */

            // ASCII Title
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\r\n _____  _  _____ ____  _     _____ ____  _      ____  _     _____  _     _      _____\r\n/__ __\\/ \\/  __//  __\\/ \\ |\\/  __//  __\\/ \\  /|/  _ \\/ \\   /__ __\\/ \\ /\\/ \\  /|/  __/\r\n  / \\  | ||  \\  |  \\/|| | //|  \\  |  \\/|| |  ||| / \\|| |     / \\  | | ||| |\\ ||| |  _\r\n  | |  | ||  /_ |    /| \\// |  /_ |    /| |/\\||| |-||| |_/\\  | |  | \\_/|| | \\||| |_//\r\n  \\_/  \\_/\\____\\\\_/\\_\\\\__/  \\____\\\\_/\\_\\\\_/  \\|\\_/ \\|\\____/  \\_/  \\____/\\_/  \\|\\____\\\r\n                                                                                     \r\n");
            Console.WriteLine("\n\nEs kommen neue Tiere, bereiten Sie sich vor!\n\n");

            // Objects initialisation
            Elefant elefant1 = new Elefant("Koi",401);
            Elefant elefant2 = new Elefant("Boolie", 50.9);
            Elefant elefant3 = new Elefant("Choy-Choy", 200.5);

            Giraffe giraffe1 = new Giraffe("Longneck", 45.5);
            Giraffe giraffe2 = new Giraffe("Bigeyez", 96.3);
            Giraffe giraffe3 = new Giraffe("Above", 50);
            Giraffe giraffe4 = new Giraffe("Tiredy", 130.2);
            Giraffe giraffe5 = new Giraffe("Fluffy", 68);

            Gorilla gorrila1 = new Gorilla("Zombi", 22);
            Gorilla gorrila2 = new Gorilla("Boo-Boo", 140.4);
            Gorilla gorrila3 = new Gorilla("Geeez", 90);
            Gorilla gorrila4 = new Gorilla("Muymuy", 41);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\nThat's all Folks!");
        }
    }
}
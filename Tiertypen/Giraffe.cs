

namespace Tierverwaltung.Tiertypen
{
    internal class Giraffe : Tier
    {
        // One of the three inherited classes from Tier
        // Inherits the 3 member variables: name, gewicht and the static variable member for the total number of animals
        // Has two new member variables, a constant for the minimal gewicht for the animals and a static for the number of animals from this class

        private const double MinimalGewichtGiraffe = 120;
        private static int TierZaehler = 0;

        // When a new object is initialised (new animal created), the constructor adds +1 to the total number of animals, the number of animals from this class, and at the end it displays the name and gewicht of the object/animal, and the current number of animals from this class and the current number of total animals
        // It also checks for the gewicht of the animal, if it has less than MinimalGewichtElefant, it displays a warning
        public Giraffe(string name, double gewicht) : base(name, gewicht)
        {
            tierZaehler = TierZaehler + 1;
            TotalTierZaehler = TotalTierZaehler + 1;
            this.Name = name;
            this.Gewicht = gewicht;

            Thread.Sleep(1000);
            if (gewicht < MinimalGewichtGiraffe)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{name} hat {gewicht} Kg, weniger als {MinimalGewichtGiraffe} Kg. Das Tier scheint krank zu sein.");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Mit der Giraffe {name} / {gewicht} kg haben wir {tierZaehler} Giraffen und insgesamt {TotalTierZaehler} Tiere.\n\n");
        }

        // Get&Set for the static member varible for the number of animals inside this class
        public static int tierZaehler { get => TierZaehler; set => TierZaehler = value; }
    }
}

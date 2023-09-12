
namespace Tierverwaltung
{
    abstract class Tier
    {
        // Abstract class with member variables name and gewicht for the three animals
        // And a static member variable for the number of total animals

        internal string Name;
        internal double Gewicht;
        internal static int TotalTierZaehler = 0;

        // Constructor for the two member variablen that get inherited in the other 3 classes
        protected Tier(string name, double gewicht)
        {
            Name = name;
            Gewicht = gewicht;
        }
    }
}

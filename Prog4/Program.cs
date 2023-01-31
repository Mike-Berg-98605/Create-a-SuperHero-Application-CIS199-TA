// Program 4
// CIS 199-50
// Due: 12/1/2021


// File: Program.cs
// This file creates a simple test application class that creates
// an array of Superhero objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The Superhero class has been tested
    public static void Main(string[] args)
    {
        Superhero superHero1 = new Superhero("Aquaman", "Atlantis", "Telepathic control of aquatic life",
            1941, "Utilizing The Sacred Trident");  // 1st test superhero
        Superhero superHero2 = new Superhero("Batman", "Gotham City", "Genius-level intellect",
            1939, "Master of Martial Arts"); // 2nd test superhero
        Superhero superHero3 = new Superhero("Iron Man", "Long Island", "Powered Armor Suit",
            1963, "Supersonic Flight"); // 3rd test superhero
        Superhero superHero4 = new Superhero("Green Lantern", "Coast City", "Flight",
            1940, "Semi Invulnerability");    // 4th test superhero
        Superhero superHero5 = new Superhero("Spider-Man", "Queens", "Superhuman Strength",
            1962, "Spidey Senses"); // 5th test superhero

        Superhero[] superHeros = { superHero1, superHero2, superHero3, superHero4, superHero5 }; // Test array of superheroes

        WriteLine("Original list of super heros");
        WriteLine("----------------------");
        PrintBooks(superHeros);

        // Make changes
        superHero1.OnPlanetEarth();
        superHero2.FirstSuperpower = "Super Strength";
        superHero3.OnPlanetEarth();
        superHero4.SecondSuperpower = "Hard-Light Generation";
        superHero5.OnPlanetEarth();
        superHero5.BirthYear = -1234; // Attempt invalid year

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(superHeros);

        // superhero is off planet earth
        superHero1.OffPlanetEarth();
        superHero3.OffPlanetEarth();
        superHero5.OffPlanetEarth();

        WriteLine("After super hero leaves planet Earth");
        WriteLine("-------------------------");
        PrintBooks(superHeros);
    }

    // Precondition:  None
    // Postcondition: The superheroes have been printed to the console
    public static void PrintBooks(Superhero[] superHero)
    {
        foreach (Superhero sh in superHero)
        {
            WriteLine(sh);
            WriteLine();
        }
    }
}

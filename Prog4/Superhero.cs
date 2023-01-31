
// This file creates a simple Superhero class capable of tracking
// the Superhero's name, city of birth, a first superpower, year of birth, a second superpower,
// and on planet earth status. Classes, constructors, getters, setters, properties, backing fields, functions that return a bool,
// and an override of the ToString method are used.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Superhero
{
    public const int BIRTH_YEAR = 1999; // Default birth year

    private string _name;      // The superhero's name
    private string _birthCity;     // The superhero's city of birth
    private string _firstSuperPower;  // The superhero's first super power
    private int _birthYear; // The superhero's year of birth
    private string secondSuperPower; // The superhero's second super power
    private bool _onPlanetEarth;   // The superhero's on planet Earth status

    // Precondition:  the birth year >= 0
    // Postcondition: The superhero has been initialized with the specified
    //                values for name, birth city, first superpower, birth year, and
    //                second superpower. The superhero is not on planet Earth.
    public Superhero(String superheroName, String birthCity, String firstSuperPower,
        int birthYear, String secondSuperPower)
    {
        SuperheroName = superheroName;
        BirthCity = birthCity;
        FirstSuperpower = firstSuperPower;
        BirthYear = birthYear;
        SecondSuperpower = secondSuperPower;

        OffPlanetEarth(); // Make sure superhero is not on planet Earth
    }

    public string SuperheroName
    {
        // Precondition:  None
        // Postcondition: The name has been returned
        get
        {
            return _name;
        }

        // Precondition:  None
        // Postcondition: The name has been set to the specified value
        set
        {
            _name = value;
        }
    }

    public char Initial
    {
        get
        {
            return SuperheroName[0];
        }
    }

    public string BirthCity
    {
        // Precondition:  None
        // Postcondition: The city has been returned
        get
        {
            return _birthCity;
        }

        // Precondition:  None
        // Postcondition: The city has been set to the specified value
        set
        {
            _birthCity = value;
        }
    }

    public string FirstSuperpower
    {
        // Precondition:  None
        // Postcondition: The first superpower has been returned
        get
        {
            return _firstSuperPower;
        }

        // Precondition:  None
        // Postcondition: The superhero has been set to the specified value
        set
        {
            _firstSuperPower = value;
        }
    }

    public int BirthYear
    {
        // Precondition:  None
        // Postcondition: The birth year has been returned
        get
        {
            return _birthYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The birth year has been set to the specified value
        set
        {
            if (value >= 0)
                _birthYear = value;
            else
                _birthYear = BIRTH_YEAR;
        }
    }

    public string SecondSuperpower
    {
        // Precondition:  None
        // Postcondition: The second superpower has been returned
        get
        {
            return secondSuperPower;
        }

        // Precondition:  None
        // Postcondition: The second superpower has been set to the specified value
        set
        {
            secondSuperPower = value;
        }
    }

    // Precondition:  None
    // Postcondition: The superhero is on planet Earth
    public void OnPlanetEarth()
    {
        _onPlanetEarth = true;
    }

    // Precondition:  None
    // Postcondition: The superhero is off planet Earth
    public void OffPlanetEarth()
    {
        _onPlanetEarth = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the superhero is on planet earth,
    //                otherwise false is returned
    public bool IsOnPlanetEarth()
    {
        return _onPlanetEarth;
    }

    // Precondition:  None
    // Postcondition: A string is returned representing the superhero's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shortcut

        return $"Name: {SuperheroName}{NL}City: {BirthCity}{NL}First Super Power: {FirstSuperpower}{NL}" +
            $"Born in: {BirthYear}{NL}Second Super Power: {SecondSuperpower}{NL}" +
            $"Planet Earth: {IsOnPlanetEarth()}{NL}" +
            $"Initial: {Initial}";
    }
}

﻿/*
    Create a struct Location that holds fields of type double latitude and longitude of a given location.
    Create an enumeration Planet that holds the following constants: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.
    • Add an enum field of type Planet. Encapsulate all fields. 
    • Add a constructor that holds 3 parameters: latitude, longitude and planet.
    • Override ToString() to print the current location in the format <latitude>, <longitude> - <location>
*/

using System;
using Galactic.GPS;

class GalacticGPS
{
    static void Main(string[] args)
    {
        Location home = new Location(18.037986, 28.870097, Planet.Earth);
        Console.WriteLine(home);
    }
}


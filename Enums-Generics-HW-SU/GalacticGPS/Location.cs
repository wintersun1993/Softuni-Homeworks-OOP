using System;

namespace Galactic.GPS
{
    enum Planet
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }

    struct Location
    {
        public double Latitude;
        public double Longtitude;
        public Planet Planet;

        public Location(double latitude, double longtitude, Planet planet) :this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return this.Latitude + " , " + this.Longtitude + " - " + this.Planet + ".";
        }
    }
}

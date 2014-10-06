using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Frog : Animal,ISound
    {
        public Frog(string name, int age, string gender)
            :base(name,age,gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Quak,Quak,Quak");
        }
    }
}

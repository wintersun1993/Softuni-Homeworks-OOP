﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Cat : Animal,ISound
    {
        public Cat(string name, int age, string gender)
            :base(name,age,gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow,Meow,Meow");
        }
    }
}

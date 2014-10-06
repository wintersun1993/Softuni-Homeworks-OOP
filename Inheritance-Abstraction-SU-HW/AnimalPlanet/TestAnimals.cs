using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class TestAnimals
    {
        static void Main(string[] args)
        {
            double sum = 0 ;
            int count = 0;
            Dog roxy = new Dog("Roxy", 2, "male");
            Cat someCat = new Cat("Dayana", 3, "female");
            Kitten buddy = new Kitten("Buddy",1);
            Tomcat Tom = new Tomcat("Tom", 3);
            Frog froggy = new Frog("Froggy", 10, "male");

            Animal[] animals = { roxy, someCat, froggy };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name+" - "+animal.Age);
                sum += animal.Age;
                count++;
            }
            Console.WriteLine("average:"+sum/count);
        }
    }
}

/*
    Define a class StringDisperser. 
    •The constructor should take several strings as arguments. 
    •Implement the ICloneable interface. The Clone() method should make a deep copy of all object fields
     into a new object of type StringDisperser.
    •Implement the IEnumerable interface to allow foreach on objects of type StringDisperser.
     The items returned should be the characters of each string
*/

using System;

namespace StringDesperser
{
    class TestDisperser
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}

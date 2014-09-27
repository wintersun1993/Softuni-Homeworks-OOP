/**
    Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
	Keep the elements of the list in an array with a certain capacity, which is given as an optional
    parameter in the class constructor.
    Declare the default capacity of 16 as constant.
•	Implement methods for:
o	adding an element 
o	accessing element by index
o	removing element by index
o	inserting element at given position
o	clearing the list
o	finding element index by given value
o	checking if the list contains a value
o	printing the entire list (override ToString()). 
•	Check all input parameters to avoid accessing elements at invalid positions.
•	Implement auto-grow functionality: when the internal array is full, create a new array of double size.
•	Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
    You may need to add generic constraints for the type T to implement IComparable<T>.
*/

using System;
using Generics;

class TestGenerics
{
    static void Main(string[] args)
    {
        GenericList<int> arrayc = new GenericList<int>(4);

        arrayc.add(2);
        arrayc.add(3);
        Console.WriteLine(arrayc);

        Console.WriteLine(arrayc.contains(3));
        
        arrayc.insert(14,4);
        Console.WriteLine(arrayc);
        
        Console.WriteLine("The min value is {0}",arrayc.Min());
        Console.WriteLine("The max value is {0}",arrayc.Max());

        Console.WriteLine(arrayc.FindIndex(14));
        
        arrayc.clear();
        Console.WriteLine(arrayc);
    }
}

/*
    Write a program that reads an integer number and calculates and prints its square root.
    If the number is invalid or negative, print "Invalid number". 
    In all cases finally print "Good bye". Use try-catch-finally.
 */

using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new IndexOutOfRangeException();
            }
            
            Console.WriteLine("Square root of "+number+" is: "+Math.Sqrt(number));
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Your input is wrong.Please enter a number.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Wrong information.");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}


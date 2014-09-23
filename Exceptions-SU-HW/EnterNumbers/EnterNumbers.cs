/* 
    Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
    If the user enters an invalid number, let the user to enter again.
*/

using System;

class EnterNumbers
{
    static void Main(string[] args)
    {
        int start = 1;
        int end = 100;

        for (int i = 1; i <= 10; i++)
        {
            start = ReadNumbers(start, end);
        }

    }

    static int ReadNumbers(int start, int end)
    {
        int number = 0;

        try
        {
            Console.WriteLine("Enter a Number between " + start + " and " + end);
            number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new IndexOutOfRangeException();
            }

            return number;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Wrong format of the number.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("The number must be between start and end values and BIGGER than your previous input.");
        }

        return number;
    }
}




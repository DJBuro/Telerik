//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
class Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 10 integers (1 < n < 100)");
        try
        {
            int[] arrayOfNumbers = new int[10];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = ReadNumber(1, 100);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number! Number must be in range 1 < n < 100");
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number! Number can contain only digits ");
        }
    }
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= start && number >= 100)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
}
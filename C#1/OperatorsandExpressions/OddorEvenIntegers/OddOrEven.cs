//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Check if integer is odd or even\nx=");
        int number = int.Parse(Console.ReadLine());
        while (true)
        {
            if (number % 2 == 0)
            Console.WriteLine("X is even");
            else
            Console.WriteLine("X is odd");
            break;
        }
    }
}


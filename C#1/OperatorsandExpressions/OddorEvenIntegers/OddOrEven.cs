//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        while (true)
        {
            if (number % 2 == 0)
            Console.WriteLine("even {0}", number);
            else
            Console.WriteLine("odd {0}", number);
            break;
        }
    }
}


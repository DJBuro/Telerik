﻿//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;
class Sqrt
{
    static double sqrt;
    static void Main()
    {
        try
        {
            Console.Write("Enter integer: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            sqrt = Math.Sqrt(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
            Console.WriteLine(sqrt);
        }
    }
}
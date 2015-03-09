//Problem 7. Sum of 5 Numbers
//
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter numbers: ");
        string[] number = Console.ReadLine().Split();
        double a = Convert.ToDouble(number[0]);
        double b = Convert.ToDouble(number[1]);
        double c = Convert.ToDouble(number[2]);
        double d = Convert.ToDouble(number[3]);
        double e = Convert.ToDouble(number[4]);
        double sumOfAll = a + b + c + d + e;
        Console.WriteLine(sumOfAll);
    }
}


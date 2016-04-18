//Problem 7. Sum of 5 Numbers
//
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Collections.Generic;
class SumFiveNumbers
{
    static void Main()
    {
        var numbers = new List<double>();
        double result = 0;
        for (int i = 0; i < 5; i++)
        {
            numbers.Add(double.Parse(Console.ReadLine()));
        }

        foreach (var number in numbers)
        {
            result += number;
        }

        Console.WriteLine(result);
    }
}


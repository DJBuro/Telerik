//Problem 1. Sum of 3 Numbers
//
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Collections.Generic;

class SomOfNumbers
{
    static void Main()
    {
        var numbers = new List<double>();
        double result = 0;

        for (int i = 0; i < 3; i++)
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

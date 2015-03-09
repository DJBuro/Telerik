//Problem 1. Sum of 3 Numbers
//
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class SomOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that sum 3 numbers!");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
        Console.WriteLine("Thank You");
    }
}

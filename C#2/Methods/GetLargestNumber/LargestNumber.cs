//Problem 2. Get largest number
//
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
class LargestNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int maxValue = int.MinValue;

        maxValue = GetMax(maxValue, a);
        maxValue = GetMax(maxValue, b);
        maxValue = GetMax(maxValue, c);
        Print(maxValue);
    }

    static int GetMax(int maxValue, int n)
    {
        if (maxValue >= n)
        {
            return maxValue;
        }
        else
        {
            maxValue = n;
            return maxValue;
        }
    }
    static void Print(int maxValue)
    {
        Console.WriteLine("Max={0}", maxValue);
    }
}

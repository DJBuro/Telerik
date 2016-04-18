//Problem 11.* Numbers in Interval Dividable by Given Number
//
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that
//the reminder of the division by 5 is 0.

using System;
class NumInIntervalDividedBy5
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = start + 1; i < end; i++)
        {
            if (i % 5 == 0)
            {
                result += 1;
            }
        }

        Console.WriteLine(result);
    }
}


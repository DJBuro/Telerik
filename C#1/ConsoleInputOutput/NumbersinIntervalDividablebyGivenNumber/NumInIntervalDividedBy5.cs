//Problem 11.* Numbers in Interval Dividable by Given Number
//
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that
//the reminder of the division by 5 is 0.

using System;
class NumInIntervalDividedBy5
{
    static void Main()
    {
        Console.Write("Please enter start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter end: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            bool check = i % 5 == 0;
            if (check)
                Console.Write("{0}, ", i);
        }
    }
}


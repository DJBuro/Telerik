//Problem 9. Matrix of Numbers
//
//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix like in the examples below. Use two nested loops.

using System;
class Matrix
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        int collums = n;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            for (int j = i; j <= collums; j++)
            {
                Console.Write("{0} ", j);
            }
        collums++;
        }
    }
}

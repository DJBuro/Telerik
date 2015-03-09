//Problem 7. Calculate N! / (K! * (N-K)!)
//
//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;
class Calculate7
{
    static void Main()
    { 
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        BigInteger facN = 1; // n
        BigInteger facK = 1; // k
        BigInteger diff = 1; // (n-k)!

        for (long i = 1; i <= n; i++)
        {
            facN *= i;
            if (i <= k)
            {
                facK *= i;
            }
            if (i <= n - k)
            {
                diff *= i;
            }
        }

        Console.WriteLine(facN / (facK * diff));
    }
}


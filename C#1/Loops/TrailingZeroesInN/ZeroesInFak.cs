using System;
using System.Numerics;
class ZeroesInFak
{
    static void Main()
    {
        Console.Write("n=");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger n = 5;
        BigInteger output = 0;
        while (number >= n)
        {
            output += number / n;
            n *= 5;
        }
        Console.WriteLine(output);
    }
}


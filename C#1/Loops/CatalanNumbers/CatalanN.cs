using System;
using System.Numerics;
class CatalanN
{
    static void Main()
    { 
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger fac2N = 1; // (2n)!
        BigInteger facPlus1 = 1; // (n+1)!
        BigInteger facN = 1; // n!

        for (int i = 1; i <= 2 * n; i++)
        {
            fac2N *= i;
            if (i <= n)
            {
                facN *= i;
            }
            if (i <= n + 1)
            {
                facPlus1 *= i;
            }
        }

        Console.WriteLine(fac2N / (facPlus1 * facN));
    }
}

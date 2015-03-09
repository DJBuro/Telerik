using System;
using System.Numerics;
class Factorial
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            BigInteger factorial = NFactorial(i);
            Console.WriteLine("{0}! = {1}", i, factorial);
        }
    }
    static BigInteger reminder = 1;
    static BigInteger NFactorial(int n)
    {
        BigInteger factorial = reminder * n;
        reminder = factorial;
        return factorial;
    }
}

//Problem 17.* Calculate GCD
//
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;
class GCD
{
    static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        while (a != b)
        {
            if (b == 0)
            {
                Console.WriteLine("GCD (a, b)=" + a); break;
            }
            int r = a % b;
            int q = a / b;
            a = b;
            b = r;
        }
    }
}


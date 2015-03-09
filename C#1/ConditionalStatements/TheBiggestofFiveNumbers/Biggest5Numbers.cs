//Problem 6. The Biggest of Five Numbers
//
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
class Biggest5Numbers
{
    static void Main()
    {
        Console.Write("Please insert first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please insert second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please insert third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please insert fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please insert fifth number: ");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(d);
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e);
        }

    }
}

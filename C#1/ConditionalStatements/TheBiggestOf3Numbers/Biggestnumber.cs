//Problem 5. The Biggest of 3 Numbers
//
//Write a program that finds the biggest of three numbers.

using System;
class Biggestnumber
{
    static void Main()
    {
        Console.Write("Please insert first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please insert second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please insert third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}

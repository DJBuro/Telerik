//Problem 7. Sort 3 Numbers with Nested Ifs
//
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;
class MultiplicationBySign
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
            if (b >= c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else
            {
                if (c >= a)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
        }
        else // b > a
        {
            if (c >= a)
            {
                if (c >= b)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
        }
    }
}

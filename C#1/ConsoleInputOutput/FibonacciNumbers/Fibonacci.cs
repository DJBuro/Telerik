//Problem 10. Fibonacci Numbers
//
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
class Fibonacci
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        Console.Write("0");
        
        if (number != 1)
        {
            Console.Write(", 1");
            for (int i = 1; i <= number - 2; i++)
            {
                Console.Write(", ");
                int sum = a + b;
                a = b;
                b = sum;
                Console.Write("{0}", sum);
            }
        }
    }
}

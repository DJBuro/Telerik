//Problem 6. Quadratic Equation
//
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
class QuadEquation
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation! Please enter a, b, c.");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("This is not quadratic equation");
            Console.WriteLine("Please insert number != 0");
            a = double.Parse(Console.ReadLine());
        }

        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Sqrt((b * b) - (4 * a * c));
        double resultOne = (discriminant - b) / (2 * a);
        double resultTwo = (- discriminant - b) / (2 * a);

        if (discriminant > 0)
        {
            Console.WriteLine("x1={0}", resultOne);
            Console.WriteLine("x2={0}", resultTwo);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x={0}", resultOne);
        }
        else 
        {
            Console.WriteLine("Quadratic equation don't have real solution");
        }
    }
}


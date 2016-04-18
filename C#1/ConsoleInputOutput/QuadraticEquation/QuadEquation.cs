//Problem 6. Quadratic Equation
//
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
class QuadEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Sqrt((b * b) - (4 * a * c));
        double resultOne = (discriminant - b) / (2 * a);
        double resultTwo = (- discriminant - b) / (2 * a);

        if (discriminant > 0)
        {
            Console.WriteLine(Math.Min(resultOne, resultTwo).ToString("F2"));
            Console.WriteLine(Math.Max(resultOne, resultTwo).ToString("F2"));
        }
        else if (discriminant == 0)
        {
            Console.WriteLine(resultOne.ToString("F2"));
        }
        else 
        {
            Console.WriteLine("no real roots");
        }
    }
}


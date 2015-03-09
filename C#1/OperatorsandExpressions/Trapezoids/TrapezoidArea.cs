//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please insert tho bases (a, b) and height (h)");
        Console.WriteLine("a=");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("h=");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) / 2 * h;
        Console.WriteLine("Area of trapezoid = {0}", area);
    }
}

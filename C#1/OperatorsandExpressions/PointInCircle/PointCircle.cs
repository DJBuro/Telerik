//Problem 7. Point in a Circle
//
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class PointCircle
{
    static void Main()
    {
        Console.WriteLine("We have circle K({0, 0}, 2).\nPlease insert coordinates (x, y) to check if your point is inside");
        Console.WriteLine("x=");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("y=");
        double y = double.Parse(Console.ReadLine());

        bool result = ((x * x) + (y * y) <= 4);
        Console.WriteLine(result);
    }
}
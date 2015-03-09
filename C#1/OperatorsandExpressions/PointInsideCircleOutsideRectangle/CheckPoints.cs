//Problem 10. Point Inside a Circle & Outside of a Rectangle
//
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
class CheckPoints
{
    static void Main()
    {
        Console.WriteLine("Insert coordinates (x, y) of point:");
        Console.WriteLine("x=");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("y=");
        double y = double.Parse(Console.ReadLine());

        bool circle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool rectangle = x >= -1 || x <= 5 && y >= -1 || y <= 2;
        Console.WriteLine("Point is in them: {0}", circle && rectangle ? "Yes" : "No");
    }
}

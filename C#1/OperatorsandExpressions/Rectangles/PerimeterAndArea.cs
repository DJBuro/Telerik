//Problem 4. Rectangles
//
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

class PerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double witht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (witht + height);
        double area = witht * height;

        string outputFormat = "{0:0.00} {1:0.00}";
        Console.WriteLine(outputFormat, area, perimeter);
    }
}


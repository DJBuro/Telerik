//Problem 3. Circle Perimeter and Area
//
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = Math.PI * 2 * radius;
        double circleArea = Math.PI * radius * radius;

        string perimeter = string.Format("{0:F2}", circlePerimeter);
        string area = string.Format("{0:F2}", circleArea);

        Console.WriteLine(perimeter + " " + area);
    }
}


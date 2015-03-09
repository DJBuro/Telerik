//Problem 3. Circle Perimeter and Area
//
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Please enter circle radius.");
        Console.Write("r=");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = Math.PI * 2 * radius;
        Console.WriteLine("Perimeter={0:f2}", circlePerimeter);

        double circleArea = Math.PI * radius * radius;
        Console.WriteLine("Area={0:f2}", circleArea);
    }
}


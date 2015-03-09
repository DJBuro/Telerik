//Problem 4. Rectangles
//
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
class PerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Calculate rectangles perimeters and area \nInsert widht: ");
        double widht = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * widht) + (2 * height);
        double area = widht * height;

        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}


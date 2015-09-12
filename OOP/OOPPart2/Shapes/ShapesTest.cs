namespace Shapes
{
    using System;

    public class ShapesTest
    {
        static void Main()
        {
            Shape[] test = new Shape[] 
            {
                new Triangle(2, 3.33m),
                new Square(4),
                new Triangle(3.33m, 4),
                new Rectangle(3, 3.5m),
                new Rectangle(2, 2)
            };

            foreach (var item in test)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}

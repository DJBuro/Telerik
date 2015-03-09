using System;
class TriangleSur
{
    static void Main()
    {
        Console.WriteLine("Triangle surfase:");
        Console.WriteLine("1. You have side and an altitude to it.");
        Console.WriteLine("2. You have three sides.");
        Console.WriteLine("3. You have two sides and an angle between them.");
        Console.Write("Make your choice (1-3): ");
        string choose = Console.ReadLine();
        Console.WriteLine();
        while (true)
        {
            if (choose == "1")
            {
                Console.Write("Please enter side: ");
                decimal side = decimal.Parse(Console.ReadLine());
                side = Check(side);
                Console.Write("Please enter Atitude: ");
                decimal atitude = decimal.Parse(Console.ReadLine());
                atitude = Check(atitude);

                decimal result = SideAndAtitude(side, atitude);
                Console.WriteLine("Surfase = {0:F1}cm^2", result);
                break;
            }
            else if (choose == "2")
            {
                Console.Write("Please enter side A: ");
                decimal sideA = decimal.Parse(Console.ReadLine());
                sideA = Check(sideA);
                Console.Write("Please enter side B: ");
                decimal sideB = decimal.Parse(Console.ReadLine());
                sideB = Check(sideB);
                Console.Write("Please enter side C: ");
                decimal sideC = decimal.Parse(Console.ReadLine());
                sideC = Check(sideC);

                decimal result = ThreeSides(sideA, sideB, sideC);
                Console.WriteLine("Surfase = {0:F1}cm^2", result);
                break;
            }
            else if (choose == "3")
            {
                Console.Write("Please enter side A: ");
                decimal sideA = decimal.Parse(Console.ReadLine());
                sideA = Check(sideA);
                Console.Write("Please enter side B: ");
                decimal sideB = decimal.Parse(Console.ReadLine());
                sideB = Check(sideB);
                Console.Write("Please enter angle between them: ");
                decimal angle = decimal.Parse(Console.ReadLine());
                angle = Check(angle);
                while (angle >= 180)
                {
                    Console.Write("Invalid input!\n\rPlease enter 0 < angle < 180:");
                    angle = decimal.Parse(Console.ReadLine());
                }

                decimal result = TwoSidesAndAngle(sideA, sideB, angle);
                Console.WriteLine("Surfase = {0:F1}cm^2", result);
                break;
            }
            else
            {
                Console.WriteLine("Whrong selection!");
                Console.WriteLine("Please choose again 1, 2 or 3.");
                choose = Console.ReadLine();
                break;
            }
        }
    }
    static decimal TwoSidesAndAngle(decimal a, decimal b, decimal angle)
    {
        angle = (decimal)Math.PI * angle / 180;
        decimal sin = (decimal)Math.Sin((double)(angle));
        return (sin * a * b / 2);
    }
    static decimal ThreeSides(decimal a, decimal b, decimal c)
    {
        decimal halfPerimeter = (a + b + c) / 2;
        return (decimal)Math.Sqrt((double)(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c)));
    }
    static decimal SideAndAtitude(decimal side, decimal atitude)
    {
        return (side * atitude / 2);
    }
    static decimal Check(decimal number)
    {
        while (number <= 0)
        {
            Console.Write("Invalid input!\n\rPlease enter positive number:");
            number = decimal.Parse(Console.ReadLine());
        }
        return number;
    }
}
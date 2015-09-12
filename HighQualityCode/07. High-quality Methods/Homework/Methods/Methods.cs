namespace Methods
{
    using System;

    internal class Methods
    {
        internal static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "float");
            PrintAsNumber(0.75, "percent");
            PrintAsNumber(2.30, "padLeft");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + CheckIfHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + CheckIfVertical(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");
            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        internal static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Side of triangle cannot be zero or less!");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Incorect side of triangle!");
            }

            double perimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentException("Number is not a Digit");
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length <= 1)
            {
                throw new ArgumentException("Array of elements is null, empty or with single element!");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        internal static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "float":
                {
                    Console.WriteLine("{0:f2}", number);
                    break;
                }

                case "percent":
                {
                    Console.WriteLine("{0:p0}", number);
                    break;
                }

                case "padLeft":
                {
                    Console.WriteLine("{0,8}", number);
                    break;
                }

                default:
                {
                    throw new ArgumentException("Incorect format!");
                }
            }
        }

        internal static double CalcDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) +
                                        (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        internal static bool CheckIfHorizontal(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            return firstPointY == secondPointY;
        }

        internal static bool CheckIfVertical(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            return firstPointX == secondPointX;
        }
    }
}

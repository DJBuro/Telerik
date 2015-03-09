using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
class Tasks
{
    
    static void Main()
    {
        Console.WriteLine("Choose task:");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.Write("Please make your selection by enter 1, 2 or 3:");
        string choose = Console.ReadLine();
        Console.WriteLine();
        while (true)
        {
            if (choose == "1")
            {
                Console.Write("Please enter positive number:");
                decimal number = decimal.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.Write("Invalid input!\n\rPlease enter positive number:");
                    number = decimal.Parse(Console.ReadLine());
                }
                string resultReverse = Reverse(number);
                Console.WriteLine("Your numbere reversed: {0}", resultReverse);
                break;

            }
            else if (choose == "2")
            {
                Console.WriteLine("Please enter sequence of integers:");
                Console.Write("Please enter positive N(number of elements):");
                int n = int.Parse(Console.ReadLine());
                while (n <= 0)
                {
                    Console.Write("Invalid input!\n\rPlease enter positive N:");
                    n = int.Parse(Console.ReadLine());
                }
                decimal[] numbers = new decimal[n];
                decimal resultAverage = Average(numbers);
                Console.WriteLine("Average={0}", resultAverage);
                break;
            }
            else if (choose == "3")
            {
                Console.WriteLine("This program find x in linear equation a * x + b = 0");
                Console.Write("Please enter  a=");
                decimal a = decimal.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.Write("Invalid input!\n\rA must be different then zero:");
                    a = decimal.Parse(Console.ReadLine());
                }
                Console.Write("Please enter  b=");
                decimal b = int.Parse(Console.ReadLine());
                decimal resultEquation = LinearEquation(a, b);
                Console.WriteLine("x={0}", resultEquation);
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
    static decimal LinearEquation(decimal a, decimal b)
    {
        decimal result = -1 * (b / a);
        return result;
    }
    static decimal Average(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = decimal.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        decimal result = sum / numbers.Length;
        return result;
    }
    private static string Reverse(decimal number)
    {
        string reminder = number.ToString();
        char[] arrayOfChars = reminder.ToCharArray();
        Array.Reverse(arrayOfChars);
        string result = string.Join("", arrayOfChars);
        return result;
    }
}
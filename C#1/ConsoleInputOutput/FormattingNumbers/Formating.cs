//Problem 5. Formatting Numbers
//
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
class Formating
{
    static void Main()
    {
        Console.Write("Please enter first number (0-500):");
        int firstNumber = int.Parse(Console.ReadLine());
        while (firstNumber < 0 || firstNumber > 500)
        {
            Console.WriteLine("{0} is not a valid", firstNumber);
            Console.WriteLine("Please enter number between 0-500");
            firstNumber = int.Parse(Console.ReadLine());
        }
        string binaryfirstNumber = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
        Console.Write("Please enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("{0,-10:X}|{1}|{2,-10:F2}|{3,10:F3}", firstNumber, binaryfirstNumber, secondNumber, thirdNumber);
    }
}


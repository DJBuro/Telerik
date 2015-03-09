//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
class FormatNum
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D5}", (int)number);

        Console.WriteLine("{0,15:X4}", (int)number);

        Console.WriteLine("{0,15:P2}", number);

        Console.WriteLine("{0,15:E4}", number);
    }
}
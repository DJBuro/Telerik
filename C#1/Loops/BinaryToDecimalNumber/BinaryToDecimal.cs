//Problem 13. Binary to Decimal Number
//
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter binary number: ");
        string input = Console.ReadLine();
        long number = 0;
        int pow = 1;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int num = input[i] - 48; 
            number += num * pow;
            pow *= 2;
        }
        Console.WriteLine(number);
    }
}

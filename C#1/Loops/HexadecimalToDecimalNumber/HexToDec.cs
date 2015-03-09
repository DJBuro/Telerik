//Problem 15. Hexadecimal to Decimal Number
//
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Please enter hex number: ");
        string input = Console.ReadLine();
        long number = 0;
        long power = 1;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int num;
            switch (input[i])
            {
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
                default: num = input[i] - 48; break;
            }
            number += num * power;
            power *= 16;
        }
        Console.WriteLine(number);
    }
}


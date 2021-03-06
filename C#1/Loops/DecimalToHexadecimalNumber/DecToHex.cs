﻿//Problem 16. Decimal to Hexadecimal Number
//
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Please enter decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());
        string output = "";

        while (decNumber > 0)
        {
            long memory = decNumber % 16;
            decNumber /= 16;
            if (memory < 10)
            {
                output = memory.ToString() + output;
            }
            switch (memory)
            {
                case 10: output = "A" + output; break;
                case 11: output = "B" + output; break;
                case 12: output = "C" + output; break;
                case 13: output = "D" + output; break;
                case 14: output = "E" + output; break;
                case 15: output = "F" + output; break;
            }
        }
        Console.WriteLine(output);
    }
}


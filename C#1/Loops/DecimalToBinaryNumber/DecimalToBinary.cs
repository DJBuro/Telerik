//Problem 14. Decimal to Binary Number
//
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter decimal number: ");
        int decNumber = int.Parse(Console.ReadLine());
        string output = "";

        while (decNumber >= 1)
        {
            int number = decNumber % 2;
            decNumber /= 2;
            string memory = Convert.ToString(number);
            output = memory + output;
        }
        Console.WriteLine(output);
    }
}

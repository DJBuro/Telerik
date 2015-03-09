//Problem 11. Bitwise: Extract Bit #3
//
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;
class BitwiseExtract
{
    static void Main()
    {
        Console.WriteLine("Number: ");
        int number = int.Parse(Console.ReadLine());
        int compare = number & 8;
        
        Console.WriteLine(compare > 0 ? "1" : "0");
    }
}

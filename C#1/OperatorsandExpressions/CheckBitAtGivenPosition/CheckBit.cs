//Problem 13. Check a Bit at Given Position
//
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
//in given integer number n, has value of 1.

using System;
class CheckBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("n: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("p: ");
        int bite = int.Parse(Console.ReadLine());
        int bit = 31 - bite;
        string binary = Convert.ToString(number, 2).PadLeft(32, '0');
        int compare = binary[bit];
        bool result = compare == 49;
        Console.WriteLine(result);
    }
}


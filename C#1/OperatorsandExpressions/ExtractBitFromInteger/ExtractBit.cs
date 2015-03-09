//Problem 12. Extract Bit from Integer
//
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("n: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("p: ");
        int bite = int.Parse(Console.ReadLine());
        int bit = 31 - bite;
        string binary = Convert.ToString(number, 2).PadLeft(32, '0');

        Console.WriteLine(binary[bit]);
    }
}

//Problem 14. Modify a Bit at Given Position
//
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());    
        Console.Write("Enter index P: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        if (v == 1)
        {
            int setOne = 1 << p;
            int foundBitOne = n | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitOne);
        }
        else
        {
            int setZero = ~(1 << p);
            int foundBitZero = n & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitZero);
        }

    }
}

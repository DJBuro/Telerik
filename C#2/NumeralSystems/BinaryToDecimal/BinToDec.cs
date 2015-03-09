using System;
using System.Collections.Generic;
using System.Linq;
class BinToDec
{
    static void Main()
    {
        Console.Write("Enter Binary: ");
        string binNumber = Console.ReadLine();
        char[] binArray = binNumber.ToCharArray();
        int counter = 1;
        int decNumber = 0;

        for (int i = binArray.Length - 1; i >= 0; i--)
        {
            decNumber += ((binArray[i] - 48) * counter);
            counter *= 2;
        }

        Console.WriteLine("Decimal = {0}", decNumber);
    }
}
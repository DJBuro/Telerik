using System;
using System.Collections.Generic;
using System.Linq;
class DecToHex
{
    static void Main()
    {
        Console.Write("Enter N: ");
        long decNumber = long.Parse(Console.ReadLine());
        long reminder;
        List<char> hexNumber = new List<char>();

        while (decNumber != 0)
        {
            reminder = decNumber % 16;
            switch (reminder)
            {
                case 0: hexNumber.Add('0'); break;
                case 1: hexNumber.Add('1'); break;
                case 2: hexNumber.Add('2'); break;
                case 3: hexNumber.Add('3'); break;
                case 4: hexNumber.Add('4'); break;
                case 5: hexNumber.Add('5'); break;
                case 6: hexNumber.Add('6'); break;
                case 7: hexNumber.Add('7'); break;
                case 8: hexNumber.Add('8'); break;
                case 9: hexNumber.Add('9'); break;
                case 10: hexNumber.Add('A'); break;
                case 11: hexNumber.Add('B'); break;
                case 12: hexNumber.Add('C'); break;
                case 13: hexNumber.Add('D'); break;
                case 14: hexNumber.Add('E'); break;
                case 15: hexNumber.Add('F'); break;
            }
            decNumber /= 16;
        }
        Console.Write("Hex = 0x");
        for (int i = 0; i < hexNumber.Count; i++)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();
    }
}
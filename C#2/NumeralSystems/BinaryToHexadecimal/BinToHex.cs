using System;
using System.Collections.Generic;
using System.Linq;
class BinToHex
{
    static void Main()
    {
        Console.Write("Enter Binary: ");
        string binNumber = Console.ReadLine();
        char[] binArray = binNumber.ToCharArray();
        List<char> binList = new List<char>();
        List<char> reminder = new List<char>();
        string part = null;

        for (int i = 0; i < binArray.Length; i++)
        {
            binList.Add(binArray[i]);
        }
        while (binList.Count % 4 != 0)
        {
            binList.Insert(0, '0');
        }

        for (int j = 0; j < binList.Count; j++)
        {
            reminder.Add(binList[j]);
            if (reminder.Count == 4)
            {
                part = string.Join<char>("", reminder);
                switch (part)
                {
                    case "0000": Console.Write("0"); break;
                    case "0001": Console.Write("1"); break;
                    case "0010": Console.Write("2"); break;
                    case "0011": Console.Write("3"); break;
                    case "0100": Console.Write("4"); break;
                    case "0101": Console.Write("5"); break;
                    case "0110": Console.Write("6"); break;
                    case "0111": Console.Write("7"); break;
                    case "1000": Console.Write("8"); break;
                    case "1001": Console.Write("9"); break;
                    case "1010": Console.Write("A"); break;
                    case "1011": Console.Write("B"); break;
                    case "1100": Console.Write("C"); break;
                    case "1101": Console.Write("D"); break;
                    case "1110": Console.Write("E"); break;
                    case "1111": Console.Write("F"); break;

                }
                reminder.Clear();
            }
        }
        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
class HexToDec
{
    static void Main()
    {
        Console.Write("Enter Hex: ");
        string hexNumber = Console.ReadLine();
        char[] hexArray = hexNumber.ToCharArray();
        long reminder = 0;
        long decNumber = 0;
        long counter = 1;

        for (int i = hexArray.Length - 1; i >= 0; i--)
        {
            switch (hexArray[i])
            {
                case '0': reminder = 0; break;
                case '1': reminder = 1; break;
                case '2': reminder = 2; break;
                case '3': reminder = 3; break;
                case '4': reminder = 4; break;
                case '5': reminder = 5; break;
                case '6': reminder = 6; break;
                case '7': reminder = 7; break;
                case '8': reminder = 8; break;
                case '9': reminder = 9; break;
                case 'A': reminder = 10; break;
                case 'B': reminder = 11; break;
                case 'C': reminder = 12; break;
                case 'D': reminder = 13; break;
                case 'E': reminder = 14; break;
                case 'F': reminder = 15; break;
            }
            decNumber += (reminder * counter);
            counter *= 16;
        }

        Console.WriteLine("Dec = {0}", decNumber);
    }
}
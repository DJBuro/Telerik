using System;
using System.Collections.Generic;
class HextoBin
{
    static void Main()
    {
        Console.Write("Enter Hex: ");
        string hexNumber = Console.ReadLine();
        char[] hexArray = hexNumber.ToCharArray();
        string reminder = null;

        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (hexArray[i])
            {
                case '0': reminder = "0000"; break;
                case '1': reminder = "0001"; break;
                case '2': reminder = "0010"; break;
                case '3': reminder = "0011"; break;
                case '4': reminder = "0100"; break;
                case '5': reminder = "0101"; break;
                case '6': reminder = "0110"; break;
                case '7': reminder = "0111"; break;
                case '8': reminder = "1000"; break;
                case '9': reminder = "1001"; break;
                case 'A': reminder = "1010"; break;
                case 'B': reminder = "1011"; break;
                case 'C': reminder = "1100"; break;
                case 'D': reminder = "1101"; break;
                case 'E': reminder = "1110"; break;
                case 'F': reminder = "1111"; break;
            }
            Console.Write(string.Join("", reminder));
        }
        Console.WriteLine();
    }
}
//Problem 7. One system to any other
//
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
class NumTransformer
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string number = Console.ReadLine();
        Console.Write("Enter s: ");
        int s = int.Parse(Console.ReadLine());
        while (s < 2 || s > 16)
        {
            Console.WriteLine("Wrong input! s must be number between 2 and 16");
            Console.WriteLine("Enter s: ");
            s = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter d: ");
        int d = int.Parse(Console.ReadLine());
        while (d < 2 || d > 16)
        {
            Console.WriteLine("Wrong input! s must be number between 2 and 16");
            Console.WriteLine("Enter s: ");
            d = int.Parse(Console.ReadLine());
        }

        int decNumber;
        if (s < 10)
        {
            decNumber = LesserToDecimal(number, s);
        }
        else
        {
            decNumber = BiggerToDecimal(number, s);
        }

        if (d < 10)
        {
            DecimalToLesser(decNumber, d);
        }
        else
        {
            DecimalToBigger(decNumber, d);
        }
    }
    static void DecimalToBigger (int decNumber, int d)
    {
        int reminder;
        List<char> number = new List<char>();

        while (decNumber != 0)
        {
            reminder = decNumber % d;
            switch (reminder)
            {
                case 0: number.Add('0'); break;
                case 1: number.Add('1'); break;
                case 2: number.Add('2'); break;
                case 3: number.Add('3'); break;
                case 4: number.Add('4'); break;
                case 5: number.Add('5'); break;
                case 6: number.Add('6'); break;
                case 7: number.Add('7'); break;
                case 8: number.Add('8'); break;
                case 9: number.Add('9'); break;
                case 10: number.Add('A'); break;
                case 11: number.Add('B'); break;
                case 12: number.Add('C'); break;
                case 13: number.Add('D'); break;
                case 14: number.Add('E'); break;
                case 15: number.Add('F'); break;
            }
            decNumber /= d;
        }

        number.Reverse();

        Console.Write("Number in {0} numeric system = ", d);
        for (int i = 0; i < number.Count; i++)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }
    static void DecimalToLesser (int decNumber, int d)
    {
        List<int> binList = new List<int>();
        int reminder;

        while (decNumber != 0)
        {
            reminder = decNumber % d;
            binList.Add(reminder);
            decNumber = decNumber / d;
        }

        binList.Reverse();

        Console.Write("Number in {0} numeric system = ", d);
        for (int i = 0; i < binList.Count; i++)
        {
            Console.Write("{0}", binList[i]);
        }
        Console.WriteLine();
    }
    static int BiggerToDecimal(string number, int s)
    {
        char[] hexArray = number.ToCharArray();
        int reminder = 0;
        int decNumber = 0;
        int counter = 1;

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
            counter *= s;
        }
        return decNumber;
    }
    static int LesserToDecimal(string number, int s)
    {
        char[] binArray = number.ToCharArray();
        int counter = 1;
        int decNumber = 0;

        for (int i = binArray.Length - 1; i >= 0; i--)
        {
            decNumber += ((binArray[i] - 48) * counter);
            counter *= s;
        }
        return decNumber;
    }
}
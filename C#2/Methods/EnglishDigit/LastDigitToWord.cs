//Problem 3. English digit
//
//Write a method that returns the last digit of given integer as an English word.

using System;
class LastDigitToWord
{
    static string result;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        result = LastDigit(n);
        Print();
    }
    
    static string LastDigit(int n)
    {
        int reminder = n % 10;
        switch (reminder)
        {
            case 0: return result = "Zero";
            case 1: return result = "One";
            case 2: return result = "Two";
            case 3: return result = "Three";
            case 4: return result = "Four";
            case 5: return result = "Five";
            case 6: return result = "Six";
            case 7: return result = "Seven";
            case 8: return result = "Eight";
            case 9: return result = "Nine";
            default: return result = null;
        }
    }
    static void Print()
    {
        Console.WriteLine(result);
    }
}
//Problem 7. Reverse number
//
//Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;
class RevNumber
{
    static void Main()
    {
        Console.Write("Please enter decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());
        string reminder = number.ToString();

        string result = Reverse(reminder);
        
        Console.WriteLine(result);
    }

    private static string Reverse(string reminder)
    {
        char[] arrayOfChars = reminder.ToCharArray();
        Array.Reverse(arrayOfChars);
        int[] arrayOfInts = arrayOfChars.Select(i => i - '0').ToArray();
        string result = string.Join("", arrayOfInts);
        return result;
    }
}
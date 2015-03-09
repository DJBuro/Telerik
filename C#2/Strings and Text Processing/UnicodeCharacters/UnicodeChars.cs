//Problem 10. Unicode characters
//
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Text;
class UnicodeChars
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            ushort result = (ushort)input[i];
            Console.Write("\\u{0:x4}", result);
        }
        Console.WriteLine();
    }
}
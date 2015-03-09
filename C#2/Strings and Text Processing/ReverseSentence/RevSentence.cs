//Reverse sentence
//Write a program that reverses the words in given sentence.

using System;
using System.Text;
class RevSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] reminder = input.Split(' ');
        StringBuilder result = new StringBuilder();

        for (int i = reminder.Length - 1; i >= 0; i--)
        {
            result.Append(reminder[i]);
            result.Append(' ');
        }

        Console.WriteLine(input);
        Console.WriteLine(result.ToString());
    }
}
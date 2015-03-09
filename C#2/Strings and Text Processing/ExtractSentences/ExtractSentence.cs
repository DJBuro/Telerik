//Problem 8. Extract sentences
//
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

using System;
using System.Text;
class ExtractSentence
{
    static void Main()
    {
        string input = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.
                         So we are drinking all the day. We will move out of it in 5 days.";
        string[] separator = new string[] { "." };
        string[] reminder = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        string word = "in";

        for (int i = 0; i < reminder.Length; i++)
        {
            int index = 0;
            while (reminder[i].IndexOf(word, index + 1) >= 0)
            {
                index = reminder[i].IndexOf(word, index + 1);
                bool inFront = char.IsWhiteSpace(reminder[i], index - 1);
                bool afterEnd = char.IsWhiteSpace(reminder[i], index + word.Length);
                if (inFront && afterEnd)
                {
                    Console.WriteLine(string.Concat(reminder[i].TrimStart() + separator[0]));
                }
            }
        }
    }
}
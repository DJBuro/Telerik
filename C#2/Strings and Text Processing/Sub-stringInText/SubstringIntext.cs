//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is "in"
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

using System;
using System.Text;
class SubstringIntext
{
    static void Main()
    {
        string input = @"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
                         So we are drinking all the day. We will move out of it in 5 days.";
        string needed = "in";
        int count = 0;
        int index = 0;
        while (input.IndexOf(needed, index) > 0)
        {
            count++;
            index = input.IndexOf(needed, index) + 1;
        }
        Console.WriteLine("There is {0} times \"{1}\" in text", count, needed);
    }
}
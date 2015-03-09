//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text;
class ForbiddenWord
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = new string[] { "Microsoft", "PHP", "CLR" };
        StringBuilder result = new StringBuilder(input);

        for (int i = 0; i < forbiddenWords.Length; i++)
	    {
            string replacer = new string('*', forbiddenWords[i].Length);
            result.Replace(forbiddenWords[i], replacer);
	    }

        Console.WriteLine(result.ToString());
    }
}
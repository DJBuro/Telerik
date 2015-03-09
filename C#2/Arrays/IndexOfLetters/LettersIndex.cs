//Problem 12. Index of letters
//
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
class LettersIndex
{
    static void Main()
    {
        int[] letters = new int[26];
        int start = 0;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[start] = i;
            start++;
        }

        Console.Write("Enter word:");
        string word = Console.ReadLine();

        foreach (char t in word)
        {
            Console.WriteLine("{0} -> Index: {1}", t, Array.IndexOf(letters, char.ToUpper(t)));
        }
    }
}

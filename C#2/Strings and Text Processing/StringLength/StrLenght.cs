//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
//the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;
class StrLenght
{
    static void Main()
    {
        Console.WriteLine("Enter string with max 20 symbols:");
        string input = Console.ReadLine();
        while (input.Length > 20) //Check if string in less than 20 chars
        {
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Enter string with max 20 symbols:");
            input = Console.ReadLine();
        }

        StringBuilder result = new StringBuilder();
        result.Append(input); // Put in Builder our string 
        result.Length = 20;

        for (int i = 0; i < 20; i++)
        {
            if (result[i] == 0)
            {
                result.Insert(i, '*');
            }
        }

        Console.WriteLine(result.ToString());
    }
}

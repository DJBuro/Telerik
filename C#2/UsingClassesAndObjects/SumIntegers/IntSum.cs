//Problem 6. Sum integers
//
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Text;
class IntSum
{
    static void Main()
    {
        Console.Write("Please enter numbers separeted by space: ");
        string input = Console.ReadLine();
        string[] separator = new string[] {" "};
        string[] arrayInput = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        
        foreach (var element in arrayInput)
        {
            sum += Convert.ToInt32(element);
        }
        
        Console.WriteLine("Sum = {0}", sum);
    }
}
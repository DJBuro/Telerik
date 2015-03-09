//Problem 4. Number Comparer
//
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
class Comparer
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((firstNumber > secondNumber ? firstNumber : secondNumber) +  " is greater!");
    }
}


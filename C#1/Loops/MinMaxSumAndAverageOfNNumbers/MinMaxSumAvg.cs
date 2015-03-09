//Problem 3. Min, Max, Sum and Average of N Numbers
//
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
class MinMaxSumAvg
{
    static void Main()
    {
        Console.Write("first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        int minNumber = firstNumber;
        int maxNumber = firstNumber;
        int sum = firstNumber;
        double avg = firstNumber;

        for (int i = 1; i <= firstNumber; i++)
        {
            Console.Write("next number: ");
            int anotherNumber = int.Parse(Console.ReadLine());
            minNumber = Math.Min(minNumber, anotherNumber);
            maxNumber = Math.Max(maxNumber, anotherNumber);
            sum += anotherNumber;
            avg = sum / firstNumber;
        }

        Console.WriteLine("min={0}", minNumber);
        Console.WriteLine("max={0}", maxNumber);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}


//Problem 6. Maximal K sum
//
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
class MaxKSum
{
    static void Main()
    {
        Console.Write("Please enter N (elements): ");
        int numberOfElements = int.Parse(Console.ReadLine());
        Console.Write("Please enter how much (biggest) elements u want to sum: ");
        int sumElements = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[numberOfElements];
        
        Random rng = new Random(); // Fill array with random numbers
        for (int i = 0; i <= numberOfElements - 1; i++)
        {
            arrayOfNumbers[i] = rng.Next(1, 9);
            Console.Write(arrayOfNumbers[i] + " ");
        }

        Console.WriteLine("\n--------------------------------------------------");
        Array.Sort(arrayOfNumbers);
        Array.Reverse(arrayOfNumbers);

        int[] output = new int[sumElements];
        for (int i = 0; i <= sumElements - 1; i++)
        {
            output[i] = arrayOfNumbers[i];
            Console.WriteLine(output[i] + " ");
        }
    }
}


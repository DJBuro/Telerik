//Problem 8. Maximal sum
//
//Write a program that finds the sequence of maximal sum in given array.

using System;
class MaxSum
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];
        
        Random rng = new Random(); // Fill array with random numbers
        for (int i = 0; i < arrLenght; i++)
        {
            array[i] = rng.Next(-9, 9);
            Console.Write(array[i] + " ");
        }
        
        int startIndex = 0;
        int endIndex = 0;
        int maxSum = 0;
        int currSum = 0;
        int currIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (currSum > 0)
            {
                currSum += array[i];
            }
            else
            {
                currSum = array[i];
                currIndex = i;
            }

            if (currSum > maxSum)
            {
                maxSum = currSum;
                startIndex = currIndex;
                endIndex = i;
            }
        }
        Console.WriteLine();
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}

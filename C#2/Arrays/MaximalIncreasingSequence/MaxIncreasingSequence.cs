//Problem 5. Maximal increasing sequence
//
//Write a program that finds the maximal increasing sequence in an array.

using System;
class MaxIncreasingSequence
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 2, 3, 1, 2, 3, 4, 1, 3, 4, 5, 2, 2, }; // if u want change numbers it works :) 

        int maxSequence = 1;
        int valueOfElement = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int currentSequence = 1;
            while (numbers[index] == (numbers[index + 1] - 1))
            {
                currentSequence++;
                index += 1;
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    valueOfElement = numbers[index];
                }
            }
        }
        for (int i = valueOfElement - maxSequence + 1; i <= maxSequence; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}


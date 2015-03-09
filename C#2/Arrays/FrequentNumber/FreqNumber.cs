//Problem 9. Frequent number
//
//Write a program that finds the most frequent number in an array.

using System;
class FreqNumber
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];
        int maxFreq = 0;
        int number = 0;

        Random rng = new Random(); // Fill array with random numbers
        for (int i = 0; i < arrLenght; i++)
        {
            array[i] = rng.Next(1, 4);
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < array.Length; i++)
        {
            int currentFreq = 0;
            for (int a = 0; a < array.Length; a++)
            {
                if (array[i] == array[a])
                {
                    currentFreq++;
                }
                if (currentFreq > maxFreq)
                {
                    maxFreq = currentFreq;
                    number = array[i];
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("{0}({1} times)", number, maxFreq);
    }
}


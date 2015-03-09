//Problem 7. Selection sort
//
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
class Sort
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];
        int switcher;

        Random rng = new Random(); // Fill array with random numbers
        for (int i = 0; i < arrLenght; i++)
        {
            array[i] = rng.Next(1, 99);
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < arrLenght; i++)
        {
            for (int a = i + 1; a < arrLenght; a++)
            {
                if (array[i] > array[a])
                {
                    switcher = array[i];
                    array[i] = array[a];
                    array[a] = switcher;
                }
            }
        }

        Console.WriteLine();
        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

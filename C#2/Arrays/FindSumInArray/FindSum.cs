//Problem 10. Find sum in array
//
//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
class FindSum
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];
        Console.Write("Please enter S: ");
        int sum = int.Parse(Console.ReadLine());
        int startIndex = 0;
        int endIndex = 0;
        bool result = false;

        Random rng = new Random(); // Fill array with random numbers
        for (int i = 0; i < arrLenght; i++)
        {
            array[i] = rng.Next(1, 5);
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = array[i];
            if (result == false)
            {
                for (int a = i + 1; a < array.Length; a++)
                {
                    if (currentSum + array[a] > sum)
                    {
                        break;
                    }
                    else if (currentSum + array[a] == sum)
                    {
                        result = true;
                        endIndex = a;
                        startIndex = i;
                        break;
                    }
                    else if (currentSum + array[a] < sum)
                    {
                        currentSum += array[a];
                    }
                }
            }
        }
        Console.WriteLine();
        if (result == false)
        {
            Console.WriteLine("In this array don't have sequences with this sum!");
        }
        else
        {
            for (int x = startIndex; x <= endIndex; x++)
            {
                Console.Write("{0}, ", array[x]);
            }
        }
    }
}

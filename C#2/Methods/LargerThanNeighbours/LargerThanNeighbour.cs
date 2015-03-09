//Problem 5. Larger than neighbours
//
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
class LargerThanNeighbour
{
    static void Main()
    {
        int[] array = FillArray();
        Console.WriteLine("Please enter index (0-{0}): ", array.Length - 1);
        int index = int.Parse(Console.ReadLine());
        
        while (index >= array.Length || index < 0)
        {
            Console.WriteLine("Invalid index!");
            Console.WriteLine("Please enter index(0-{0}): ");
            index = int.Parse(Console.ReadLine());
        }

        CheckNeighbours(array, index);

        if (result)
        {
            Console.WriteLine("Elements in index {0} is larger than its neigbours!", index);
        }
        else
        {
            Console.WriteLine("Elements in index {0} is NOT larger than its neigbours!", index);
        }

    }
    static bool result;
    static void CheckNeighbours(int[] array, int index)
    {
        bool resultLeft = false;
        bool resultRight = false;
        if (index > 0)
        {
            if (array[index] > array[index - 1])
            {
                resultRight = true;
                if (index == array.Length - 1)
                {
                    result = true;
                    return;
                }
            }
        }
        if (index < array.Length - 1)
        {
            if (array[index] > array[index + 1])
            {
                resultLeft = true;
                if (index == 0)
                {
                    result = true;
                    return;
                }
            }
        }
        result = (resultLeft && resultRight);
    }
    static int[] FillArray()
    {
        Console.Write("Array Lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}

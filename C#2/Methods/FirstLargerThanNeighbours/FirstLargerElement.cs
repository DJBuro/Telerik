//Problem 6. First larger than neighbours
//
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
class FirstLargerElement
{
    static void Main()
    {
        int[] array = FillArray();

        for (int index = 0; index < array.Length; index++)
        {
            CheckNeighbours(array, index);
            if (result)
            {
                Console.WriteLine("Elements in index {0} is larger than its neighbours!", index);
                break;
            }
        }
        if (result == false)
        {
            Console.WriteLine("There is NOT element, which is larger than neighbours!");
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
                resultLeft = true;
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
                resultRight = true;
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
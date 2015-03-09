using System;
using System.Collections.Generic;
class SortArr
{
    static void Main()
    {
        int[] array = FillArray();
        Console.WriteLine("Please enter index: ");
        int index = int.Parse(Console.ReadLine());

        int maxInPortion = GetMax(array, index);
        Console.WriteLine(maxInPortion);

        int[] sortDescending = SortArrDescending(array);

        Print(array);

        Array.Reverse(array);

        Print(array);
    }
    static void Print(int[] array)
    {
        Console.WriteLine("-------------------------------------------------");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine("");
    }
    
    static int GetMax(int[] array, int index)
    {
        int maxInPotion = int.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (maxInPotion < array[i])
            {
                maxInPotion = array[i];
                helper = i;
            }
        }
        return maxInPotion;
    }
    static int helper;
    static int[] SortArrDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int max = GetMax(array, i);
            int switcher = array[i];
            array[i] = max;
            array[helper] = switcher;
        }
        return array;
    }
    static int[] SortArrAscending(int[] array) // ascending
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int max = GetMax(array, i);
            int switcher = array[i];
            array[i] = max;
            array[helper] = switcher;
        }
        return array;
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
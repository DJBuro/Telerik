using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.Write("Please enter N(elements):");
        int n = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("element[{0}]=", i);
            array.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < array.Count - 1; i++)
        {
            if (array[i] > array[i + 1] || array[i] < array[0])
            {
                array.Remove(array[i]);
            }
        }
        for (int i = 0; i < array.Count; i++)
        {
            if (i < array.Count - 1)
            {
                Console.Write(array[i] + " ");
            }
            else
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
using System;
class BinSearch
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];
        Console.Write("Please enter a number for which we will search index:");
        int number = int.Parse(Console.ReadLine());
        int min = 0;
        int max = array.Length - 1;

        Console.WriteLine("Plaese fill array with numbers:");
        for (int i = 0; i < arrLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        while (array[(min + max) / 2] != number)
        {
            if (array[(min + max) / 2] > number)
            {
                max = (min + max) / 2;
            }
            else if (array[(min + max) / 2] < number)
            {
                min = (min + max) / 2;
            }
        }

        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("Index: " + (min + max) / 2);
    }
}

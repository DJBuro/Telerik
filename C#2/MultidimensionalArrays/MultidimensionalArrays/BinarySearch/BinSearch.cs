using System;
class BinSearch
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int maxValue = int.MinValue;

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
	    {
            numbers[i] = int.Parse(Console.ReadLine());
	    }

        Array.Sort(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < k)
            {
                maxValue = numbers[i];
            }
        }

        Array.BinarySearch(numbers, maxValue);

        if (numbers[0] > k)
        {
            Console.WriteLine("There isn't number less or equal to {0}", k);
        }
        else
        {
            Console.WriteLine("The biggest number less or equal to {0} is: {1}", k, maxValue);
        }
    }
}
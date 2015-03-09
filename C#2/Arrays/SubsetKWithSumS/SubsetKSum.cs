//Problem 17.* Subset K with sum S
//
//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
class SubsetKSum
{
    static void Main()
    {
        // Check my problems 19, 20, 21 and it will be very easy to understand this!
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        Console.Write("S=");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert N elements in array");
        int[] numbers = new int[n]; // main array
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}= ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        bool[] combinationsArray = new bool[numbers.Length]; // bool array in which i check combinations with elements in Main arrray
        bool result = false; // to check if i have S
        int[] index = new int[k]; // array for combinations of k elements
        for (int i = 0; i < k - 1; i++)
        {
            index[i] = 1;
        }
        bool finish = false; 
        // I make all possible combinations of k elements in 1..N
        while (!finish)
        {
            for (int i = k - 1; i >= 0; i--)
            {
                index[i]++;
                if (index[i] > n)
                {
                    index[i] = 1;
                }
                else break;
            }
            // Check if every elements is bigger and not equal to left ones.
            bool checker = true;
            for (int a = 0; a < k - 1; a++)
            {
                for (int b = a + 1; b < k; b++)
                {
                    if (index[a] >= index[b])
                    {
                        checker = false;
                    }
                }
            }
            // When I get possible combination, i use it like index in bool array.
            if (checker)
            {
                for (int i = 0; i < k; i++)
                {
                    combinationsArray[index[i] - 1] = true;
                }
                int sum = 0;
                for (int i = 0; i < n; i++) 
                {
                    if (combinationsArray[i]) 
                    {
                        sum += numbers[i];
                    }
                }
                if (sum == s) // check every single sum
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (combinationsArray[i])
                        {
                            Console.Write("{0}, ", numbers[i]);
                            result = true;
                        }
                    }
                    Console.WriteLine();
                }
                combinationsArray = new bool[numbers.Length]; 
            }
            for (int i = 0; i < k; i++)
            {
                if (index[i] != n)
                {
                    finish = false; break;
                }
                else
                {
                    finish = true;
                }
            }
        }
        if (!result)
        { 
        Console.WriteLine("In array doesn't have this sum");
        }
    }
}

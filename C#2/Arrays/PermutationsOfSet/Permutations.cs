//Problem 19.* Permutations of set
//
//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;
class SubsetSum
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n - 1; i++)
        {
            numbers[i] = 1;
        }
        bool finish = false;

        while (!finish)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                numbers[i]++;
                if (numbers[i] > n)
                {
                    numbers[i] = 1;
                }
                else break;
            }
            bool checker = true;
            for (int a = 0; a < n - 1; a++)
            {
                for (int b = a + 1; b < n; b++)
                {
                    if (numbers[a] == numbers[b])
                    {
                        checker = false;
                    }
                }
            }
            if (checker)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}, ", numbers[i]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] != n)
                {
                    finish = false; break;
                }
                else
                {
                    finish = true;
                }
            }
        }
    }
}

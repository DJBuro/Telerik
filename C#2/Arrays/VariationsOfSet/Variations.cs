//Problem 20.* Variations of set
//
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;
class Variations
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < k - 1; i++)
        {
            numbers[i] = 1;
        }
        bool finish = false;

        while (!finish)
        {
            for (int i = k - 1; i >= 0; i--)
            {
                numbers[i]++;
                if (numbers[i] > n)
                {
                    numbers[i] = 1;
                }
                else break;
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
            Console.WriteLine();
            
            for (int i = 0; i < k; i++)
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
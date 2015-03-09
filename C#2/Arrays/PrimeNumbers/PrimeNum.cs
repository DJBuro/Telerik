//Problem 15. Prime numbers
//
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
class PrimeNum
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        for (int i = 2; i <= 10000000; i++) // Test it with less number if u want less results :) 
        {
            numbers.Add(i);
        }
        int p;
        for (int a = 0; a <= numbers.Count - 1; a++)
        {
            if (numbers[a] == 0) continue;
            p = numbers[a];
            for (int b = a + p; b <= numbers.Count - 1; b = b + p)
            {
                numbers[b] = 0;
            }
        }
        
        numbers.RemoveAll(item => item == 0);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

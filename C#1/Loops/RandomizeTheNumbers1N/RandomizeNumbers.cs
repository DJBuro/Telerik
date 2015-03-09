using System;
using System.Collections.Generic;
class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("N=");
        int input = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(input);
        for (int i = 1; i <= input; i++)
        {
            numbers.Add(i);
        }
        while (numbers.Count > 0)
        {
            Random rnd = new Random();            
            int index = rnd.Next(numbers.Count);
            Console.Write("{0} ", numbers[index]);
            numbers.RemoveAt(index);
        }
        
    }
}

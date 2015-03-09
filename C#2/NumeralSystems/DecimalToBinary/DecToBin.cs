using System;
using System.Collections.Generic;
using System.Linq;
class DecToBin
{
    static void Main()
    {
        Console.Write("Enter N:");
        long decNumber = long.Parse(Console.ReadLine());
        List<long> binList = new List<long>();
        long reminder;

        while (decNumber != 0)
        {
            reminder = decNumber % 2;
            binList.Add(reminder);
            decNumber = decNumber / 2;
        }

        binList.Reverse();

        Console.Write("Bin = ");
        for (int i = 0; i < binList.Count; i++)
        {
            Console.Write("{0}", binList[i]);
        }
    }
}
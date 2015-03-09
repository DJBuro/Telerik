//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
class Divide
{
    static void Main()
    {
        Console.WriteLine("Check if your number can be divided by 7 and 5 (without reminder)\nx= :");
        int number = int.Parse(Console.ReadLine());
        bool devideBySeven = false;
        bool devideByFive = false;
        while (true)
        {
            if (number % 7 == 0)
                devideBySeven = true;
            break;
        }
        while (true)
        {
            if (number % 5 == 0)
                devideByFive = true;
            break;
        }
        bool result = (devideBySeven && devideByFive);
        Console.WriteLine(result);
    }
}


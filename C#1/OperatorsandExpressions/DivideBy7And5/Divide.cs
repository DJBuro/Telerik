//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
class Divide
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = false;

        if (number % 7 == 0)
        {
            if (number % 5 == 0)
            {
                result = true;
            }
        }

        Console.WriteLine(result.ToString().ToLower() + " " + number);
    }
}


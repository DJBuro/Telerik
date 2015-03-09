//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
class DateDiff
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        TimeSpan elapsed = secondDate.Subtract(firstDate);
        double difference = elapsed.TotalDays;
        if (difference < 0)
        {
            difference *= -1;
        }
        Console.WriteLine("Difference is {0} days.", (int)difference);
    }
}
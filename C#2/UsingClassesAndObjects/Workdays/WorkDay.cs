using System;
using System.Collections.Generic;
class WorkDay
{
    static void Main()
    {
        Console.Write("Enter date: ");
        DateTime endDay = DateTime.Parse(Console.ReadLine());
        
        string result = CheckDay(endDay);
        Console.WriteLine(result);
    }
    static List<DateTime> holidays;
    static string CheckDay(DateTime endDay)
    {
        List<DateTime> holidays = new List<DateTime>()
        { new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
          new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
          new DateTime(2015, 9, 21), new DateTime(2015, 9, 22), new DateTime(2015, 12, 24),
          new DateTime(2015, 12, 25), new DateTime(2015, 12, 31) 
        };

        int workDays = 0;
        int holidayDays = 0;
        int weekends = 0;
        DateTime curent = DateTime.Today;
        while (curent <= endDay)
        {
            if (holidays.Contains(curent))
            {
                holidayDays++;
            }
            else if ((int)curent.DayOfWeek == 0 || (int)curent.DayOfWeek == 6)
            {
                weekends++;
            }
            else
            {
                workDays++;
            }
            curent = curent.AddDays(1);
        }
        return String.Format(@"In this period you have: {0} - workdays
                                                        {1} - weekends 
                                                        {2} - holidays", workDays, weekends, holidayDays);
    }
}
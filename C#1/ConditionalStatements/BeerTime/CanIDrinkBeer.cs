using System;
using System.Globalization;
using System.Threading;
class CanIDrinkBeer
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        TimeSpan timeNow;
        Console.Write("Enter time: ");
        string imputTime = Console.ReadLine();
        TimeSpan time = TimeSpan.TryParseExact(imputTime, "hh:mm tt", enUS);

        TimeSpan timeMin = TimeSpan.Parse("3:00 AM");
        TimeSpan timeMax = TimeSpan.Parse("1:00 PM");

        if (time >= timeMin && time <= timeMax)
        {
            Console.WriteLine("BEER TIME");
        }
        else
        {
            Console.WriteLine("NOOOOOOOOOOOOOOO");
        }
    }
}


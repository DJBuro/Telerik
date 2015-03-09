//Problem 19. Dates from text in Canada
//
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
class DatesCanada
{
    static void Main()
    {
        string input = "Maria's birthday 02.06.1989, Lidiq's birthday 09.09.1988, Pesho's birthday 05.08.1990, Martin's birthday 09.06.1992";
        Regex datesR = new Regex(@"(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.(19|20)\d\d", RegexOptions.IgnoreCase);
        MatchCollection dates = datesR.Matches(input);
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");

        foreach (Match item in dates)
        {
            string reminder = item.ToString();
            DateTime date = DateTime.ParseExact(reminder, "dd.MM.yyyy", provider);
            Console.WriteLine(date);
        }
    }
}
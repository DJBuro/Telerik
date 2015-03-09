﻿//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;
class CheckLeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} - {1} leap year.", year, DateTime.IsLeapYear(year) ? "It's" : "It is not");
    }
}

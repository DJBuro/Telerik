//Problem 1. Say Hello
//
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
class Hello
{
    static void Main()
    {
        string name = null;
        name = AskForName(name);
        PrintName(name);
    }
    static string AskForName(string name)
    {
        Console.WriteLine("Please enter your name.");
        return name = Console.ReadLine();
    }
    static void PrintName(string name)
    {
        Console.WriteLine("Hello {0}!", name);
    }
}
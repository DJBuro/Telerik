//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints 
//the entire ASCII table of characters on the console (characters from 0 to 255).

using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int i = 33; i <= 126; i++)
        {
            Console.Write("{0}", (char)i);
        }
    }
}

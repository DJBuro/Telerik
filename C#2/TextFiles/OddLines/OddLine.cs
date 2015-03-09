//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
class OddLine
{
    static void Main()
    {
        string filename = @"..\..\Files\PeshoGosho.txt";
        StreamReader reader = new StreamReader(filename);
        int lineNumber = 0;
        string line = reader.ReadLine();

        while (line != null)
        {
            if (lineNumber % 2 == 0)
            {
                Console.WriteLine(line);
            }
            lineNumber++;
            line = reader.ReadLine();
        }
    }
}
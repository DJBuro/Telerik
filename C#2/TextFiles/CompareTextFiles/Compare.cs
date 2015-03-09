//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;
class Compare
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader(@"..\..\Files\FirstFile.txt");
        StreamReader secondFile = new StreamReader(@"..\..\Files\SecondFile.txt");

        using (firstFile)
        {
            using (secondFile)
            {
                string first;
                string second;
                while ((first = firstFile.ReadLine()) != null)
                {
                    second = secondFile.ReadLine();
                    CompareStrings(first, second);
                }
            }
        }

        Console.WriteLine("In these files have {0} same lines and {1} different lines.", sameLines, differentLines);
    }
    static int sameLines = 0;
    static int differentLines = 0;
    static void CompareStrings(string firstFileLine, string secondFileLine)
    {
        if (firstFileLine == secondFileLine)
        {
            sameLines++;
        }
        else
        {
            differentLines++;
        }
    }
}
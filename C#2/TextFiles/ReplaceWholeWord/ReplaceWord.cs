//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class ReplaceWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\Input.txt");
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Replace(line);
            }
        }
    }
    static void Replace(string line)
    {
        StreamWriter writer = new StreamWriter(@"..\..\Files\Output.txt", true);
        string result = Regex.Replace(line, @"\sin\b", " **");
        using (writer)
        {
            writer.WriteLine(result);
        }
    }
}
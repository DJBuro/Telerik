using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class CountWord
{
    static void Main()
    {
        try
        {
            string[] wordsToCount = WordsToCount();
            StreamReader test = new StreamReader(@"..\..\Files\test.txt");
            string text;
            using (test)
            {
                text = test.ReadToEnd();
            }

            for (int i = 0; i < wordsToCount.Length; i++)
            {
                Regex reg = new Regex(@"\s" + wordsToCount[i] + @"\b");
                MatchCollection counter = reg.Matches(text);
                StringBuilder sb = new StringBuilder(wordsToCount[i]);
                sb.Insert(0, counter.Count.ToString("D2") + " times - ");
                wordsToCount[i] = sb.ToString();
            }

            List<string> result = new List<string>(wordsToCount);
            result.Sort();
            result.Reverse();

            StreamWriter writer = new StreamWriter(@"..\..\Files\result.txt", false);
            using (writer)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(result[i]);
                }
            }
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path is too long!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is invalid format!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong path!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory doesn't exist");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can't find this file!");
        }
        catch (IOException)
        {
            Console.WriteLine("In/Out error while open file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have permision to open this file!");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("For-loop go out of string");
        }
        catch (Exception)
        {
            Console.WriteLine("Even I dont know what bug right now :)");
        }
    }
    static string[] WordsToCount()
    {
        StreamReader words = new StreamReader(@"..\..\Files\words.txt");
        string[] wordsToCount;
        using (words)
        {
            string reminder = words.ReadToEnd();
            wordsToCount = Regex.Split(reminder, @"\s+", RegexOptions.IgnoreCase);
        }
        return wordsToCount;
    }
}
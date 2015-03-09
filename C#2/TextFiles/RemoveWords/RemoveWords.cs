//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;
class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader words = new StreamReader(@"..\..\Files\Words.txt");
            string[] wordsToRemove;
            using (words)
            {
                wordsToRemove = words.ReadToEnd().Split(' ');
            }
            StreamReader text = new StreamReader(@"..\..\Files\Input.txt");
            string allText;
            using (text)
            {
                allText = text.ReadToEnd();
            }

            for (int i = 0; i < wordsToRemove.Length; i++)
            {
                allText = Regex.Replace(allText, @"\s" + wordsToRemove[i] + @"\b", "");
            }

            StreamWriter newtext = new StreamWriter(@"..\..\Files\Output.txt", true);
            using (newtext)
            {
                newtext.WriteLine(allText);
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
}
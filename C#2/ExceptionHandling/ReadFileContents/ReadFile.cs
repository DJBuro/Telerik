//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;
class ReadFile
{
    static void Main()
    {
        try
        {
            string path = @"D:\Telerik\Homeworks\C# part 2\Homeworks\ExceptionHandling\ReadFileContents\Files\input.txt";
            File.ReadAllText(path);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Too long path!");
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
        catch (SecurityException)
        {
            Console.WriteLine("You don't have permision to open this file!");
        }
        catch (Exception)
        {
            Console.WriteLine("Even I dont what bug right now :)");
        }
    }
}
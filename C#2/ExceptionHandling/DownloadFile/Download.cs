//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
class Download
{
    static void Main()
    {
        try
        {
            string pathUri = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = "NinjaImage.png";
            WebClient web = new WebClient();
            web.DownloadFile(pathUri, fileName);
            Console.WriteLine("Download complete!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Download failed!");
            Console.WriteLine("Path is null!");
        }
        catch (WebException)
        {
            Console.WriteLine("Download failed!");
            Console.WriteLine("One of next four happen");
            Console.WriteLine("The URI formed by combining BaseAddress and address is invalid!");
            Console.WriteLine("Filename is null or Empty!");
            Console.WriteLine("The file does not exist!");
            Console.WriteLine("An error occurred while downloading data!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Download failed!");
            Console.WriteLine("The method has been called simultaneously on multiple threads!");
        }
        finally
        {
            Console.WriteLine("GoodBye!");
        }
    }
}
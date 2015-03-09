using System;
using System.IO;
class ConcatTextFiles
{
    static void Main()
    {
        try
        {
            StreamReader firstFile = new StreamReader(@"..\..\Files\ICan.txt");
            StreamReader secondFile = new StreamReader(@"..\..\Files\Streams.txt");
            WriteFile(firstFile);
            WriteFile(secondFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can't find file!");
        }
    }
    static void WriteFile (StreamReader reader)
    {
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\Files\Concatenate.txt", true);
            using (writer)
            {
                writer.Write(reader.ReadToEnd());
            }
        }
    }
}

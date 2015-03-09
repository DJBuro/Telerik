using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class ReplaceSubstrins
{
    static void Main()
    {
        // Lets make >100 MB fail :) if u want to test it fast change for-loop to be max 20 :) 
        List<string> list = new List<string> { "The text is as follows: We are living in an yellow submarine. We don't have anything else. ", 
                                               "inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
                                             };
        StreamWriter writerFile = new StreamWriter(@"..\..\Files\OriginalText.txt", true, Encoding.GetEncoding("UTF-8"));
        using (writerFile)
        {
            for (int i = 0; i < 2000000; i++)
			{
			    writerFile.WriteLine(list[i % 2]);
			}
        }

        StreamReader reader = new StreamReader(@"..\..\Files\OriginalText.txt", Encoding.GetEncoding("UTF-8"));
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
        StreamWriter writer = new StreamWriter(@"..\..\Files\ChangedText.txt", true, Encoding.GetEncoding("UTF-8"));
        StringBuilder sb = new StringBuilder(line);
        sb.Replace("in", "??");
        using (writer)
        {
            writer.WriteLine(sb);
        }
    }
}

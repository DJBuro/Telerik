using System;
using System.Text;

class ReverseStr
{
    static void Main()
    {
        string input = "sample";
        char[] array = input.ToCharArray();
        Array.Reverse(array);

        foreach (var item in array)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

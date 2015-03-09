using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
class Polindrome
{
    static void Main()
    {
        string input = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
        Regex reg = new Regex(@"(\w+|[,-?]\p{P})"); // Find all words and put them in collection 
        MatchCollection words = reg.Matches(input);
        List<string> polindromes = new List<string>();

        foreach (var element in words) // Check word by word if it is polidrome and put polidromes in other list 
        {
            string item = element.ToString();
            if (item.Length > 1)
            {
                bool isPolindrome = false;
                for (int i = 0, j = item.Length - 1; i < item.Length / 2; i++, j--)
                {
                    if (item[i] == item[j])
                    {
                        isPolindrome = true;
                    }
                    else
                    {
                        isPolindrome = false;
                        break;
                    }
                }
                if (isPolindrome) 
                {
                    polindromes.Add(item);
                }
            }
        }

        for (int i = 0; i < polindromes.Count; i++)
        {
            Console.WriteLine(polindromes[i]);
        }
    }
}
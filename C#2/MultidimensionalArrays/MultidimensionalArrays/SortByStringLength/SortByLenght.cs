//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
class SortByLenght
{
    static void Main()
    {
        string[] arr = {
                             "bira",
                             "birichka",
                             "birence",
                             "bi",
                             "birichkachka",
                             "b",
                             "JENATAAAAAAAAA"
                         };

        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }
    }
}

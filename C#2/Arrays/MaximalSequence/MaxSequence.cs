//Problem 4. Maximal sequence
//
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
class FrequenceInMatrix
{
    static void Main()
    {
        Console.Write("N= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M= ");
        int cols = int.Parse(Console.ReadLine());

        // use this input to check easy :) if u want :) 
        string[,] arr = {
                            {"ha",	"fifi",	"ho",	"hi"},
                            {"fo",	"ha",	"hi",	"xx"},
                            {"xxx",	"ho",	"ha",	"xe"},
                        };
        //string[,] arr = new string[rows, cols];
        //for (int i = 0; i < rows; i++) // Fill matrix
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write("Array[{0},{1}] = ", i, j);
        //        arr[i, j] = Console.ReadLine();
        //    }
        //}
        List<string> list = new List<string>();
        int maxFreq = int.MinValue;
        int currentFreq = 1;
        string repeat = null;

        for (int i = 0; i < arr.GetLength(0); i++) // Cheaking rows
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                list.Add(arr[i, j]);
                if (j == arr.GetLength(1) - 1)
                {
                    for (int a = 0; a < list.Count - 1; a++)
                    {
                        if (list[a] == list[a + 1])
                        {
                            for (int b = a + 1; b < list.Count; b++)
                            {
                                currentFreq++;
                                if (currentFreq > maxFreq)
                                {
                                    maxFreq = currentFreq;
                                    repeat = list[a];
                                }
                            }
                        }
                    }
                    list.Clear();
                }
            }
        }
        for (int i = 0; i < arr.GetLength(1); i++) // Cheaking cols
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                list.Add(arr[j, i]);
                if (j == arr.GetLength(1) - 1)
                {
                    for (int a = 0; a < list.Count - 1; a++)
                    {
                        if (list[a] == list[a + 1])
                        {
                            for (int b = a + 1; b < list.Count; b++)
                            {
                                currentFreq++;
                                if (currentFreq > maxFreq)
                                {
                                    maxFreq = currentFreq;
                                    repeat = list[a];
                                }
                            }
                        }
                    }
                    list.Clear();
                }
            }
        }

        for (int i = 0, j = 0; i < arr.GetLength(0) && j < arr.GetLength(1); i++, j++) // Check main diagonal
        {
            list.Add(arr[i, j]);
            if (j == arr.GetLength(1) - 1)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    if (list[a] == list[a + 1])
                    {
                        for (int b = a + 1; b < list.Count; b++)
                        {
                            currentFreq++;
                            if (currentFreq > maxFreq)
                            {
                                maxFreq = currentFreq;
                                repeat = list[a];
                            }
                        }
                    }
                }
                list.Clear();
            }
        }

        for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0) && j >= 0; i++, j--) // check another diagonal 
        {
            list.Add(arr[i, j]);
            if (j == arr.GetLength(1) - 1)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    if (list[a] == list[a + 1])
                    {
                        for (int b = a + 1; b < list.Count; b++)
                        {
                            currentFreq++;
                            if (currentFreq > maxFreq)
                            {
                                maxFreq = currentFreq;
                                repeat = list[a];
                            }
                        }
                    }
                }
                list.Clear();
            }
        }

        Console.WriteLine();
        Console.WriteLine(string.Concat(Enumerable.Repeat(repeat, maxFreq)));
    }
}

// This is mistake which i made, because i don't read problem well! But it is 1.5 hours, so i will leave it in homework. 

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

        /* use this input to check easy :) if u want :) 
         * string[,] arr = {
                            {"ha",	"fifi",	"ho",	"hi"},
                            {"fo",	"hr",	"hi",	"xx"},
                            {"xxx",	"ho",	"h",	"xe"},
                        };*/
        string[,] arr = new string[rows, cols];
        for (int i = 0; i < rows; i++) // Fill matrix
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Array[{0},{1}] = ", i, j);
                arr[i, j] = Console.ReadLine();
            }
        }
        List<string> list = new List<string>();
        int maxFreq = int.MinValue;
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
                        int currentFreq = 1;
                        for (int b = a + 1; b < list.Count; b++)
                        {
                            if (list[a] == list[b])
                            {
                                currentFreq++;
                            }
                            if (currentFreq > maxFreq)
                            {
                                maxFreq = currentFreq;
                                repeat = list[a];
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
                if (j == arr.GetLength(0) - 1)
                {
                    for (int a = 0; a < list.Count - 1; a++)
                    {
                        int currentFreq = 1;
                        for (int b = a + 1; b < list.Count; b++)
                        {
                            if (list[a] == list[b])
                            {
                                currentFreq++;
                            }
                            if (currentFreq > maxFreq)
                            {
                                maxFreq = currentFreq;
                                repeat = list[a];
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
            if (j == arr.GetLength(0) - 1)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    int currentFreq = 1;
                    for (int b = a + 1; b < list.Count; b++)
                    {
                        if (list[a] == list[b])
                        {
                            currentFreq++;
                        }
                        if (currentFreq > maxFreq)
                        {
                            maxFreq = currentFreq;
                            repeat = list[a];
                        }
                    }
                }
                list.Clear();
            }
        }

        for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0) && j >= 0; i++, j--) // check another diagonal 
        {
            list.Add(arr[i, j]);
            if (j == arr.GetLength(0) - 1)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    int currentFreq = 1;
                    for (int b = a + 1; b < list.Count; b++)
                    {
                        if (list[a] == list[b])
                        {
                            currentFreq++;
                        }
                        if (currentFreq > maxFreq)
                        {
                            maxFreq = currentFreq;
                            repeat = list[a];
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

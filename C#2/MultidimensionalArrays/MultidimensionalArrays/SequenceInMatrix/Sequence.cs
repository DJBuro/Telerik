using System;
using System.Collections.Generic;
using System.Linq;
class FrequenceInMatrix
{
    static int maxSec = int.MinValue;
    static string rep = null;
        
    static void Main()
    {
        Console.Write("N= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M= ");
        int cols = int.Parse(Console.ReadLine());

        /*use this input to check easy :) if u want :) 
        string[,] arr = {
                            {"ha",	"a",	"h",	"ha"},
                            {"h",	"a",	"ha",	"xx"},
                            {"ha",	"ha",	"hi",	"xe"},
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

        List<string> listElements = new List<string>(); // in this list i will add every row, col or diagonal and then i will check it!

        for (int i = 0; i < arr.GetLength(0); i++) 
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                listElements.Add(arr[i, j]); // Add items from 1 row 
                if (listElements.Count == arr.GetLength(1))
                {
                    CheckList(listElements); // Check only this row 
                    listElements.Clear(); // Clear to be ready for new row
                }
            }
        }

        for (int i = 0; i < arr.GetLength(1); i++) // Cheaking cols
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                listElements.Add(arr[j, i]);
                if (listElements.Count == arr.GetLength(0))
                {
                    CheckList(listElements);
                    listElements.Clear();
                }
            }
        }

        for (int i = 0, j = 0; i < arr.GetLength(0) && j < arr.GetLength(1); i++, j++) // Check main diagonal
        {
            listElements.Add(arr[i, j]);
            if (listElements.Count == arr.GetLength(1) || listElements.Count == arr.GetLength(0))
            {
                CheckList(listElements);
                listElements.Clear();
            }
        }

        for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0) && j >= 0; i++, j--) // check another diagonal 
        {
            listElements.Add(arr[i, j]);
            if (listElements.Count == arr.GetLength(1) || listElements.Count == arr.GetLength(0))
            {
                CheckList(listElements);
                listElements.Clear();
            }
        }

        for (int i = 1; i <= maxSec; i++)
        {
            Console.Write("{0}, ", rep);
        }
    }


    static void CheckList(List<string> listElements)
    {
        for (int i = 0; i < listElements.Count - 1; i++) 
        {
            if (listElements[i] == listElements[i + 1])
            {
                int currentsec = 1;
                for (int j = i + 1; j < listElements.Count; j++)
                {
                    if (listElements[i] == listElements[j])
                    {
                        currentsec++;
                        if (currentsec > maxSec)
                        {
                            maxSec = currentsec;
                            rep = listElements[i];
                        }
                    }
                }
            }
        }
    }
}
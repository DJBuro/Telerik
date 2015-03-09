//Problem 5. Maximal area sum
//
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:
//
//input  	output
//4 
//2 3 3 4 
//0 2 3 4   17
//3 7 1 2 
//4 3 3 2	

using System;
using System.IO;
using System.Text.RegularExpressions;
class MaxAreaSum
{
    static int[,] array;
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\Matrix.txt");
        using (reader)
        {
            int n = int.Parse(reader.ReadLine());
            array = new int[n, n];
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                array = FillArray(array, line);
            }
        }

        int maxSum = MaxSum(array);
        Console.WriteLine("Max sum is: {0}", maxSum);
    }
    static int MaxSum(int[,] matrix)
    {
        int platform = 2;
        int sum = 0;
        int bestSum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - platform + 1; i++) // Find best sum for given platform
        {
            for (int j = 0; j < matrix.GetLength(1) - platform + 1; j++)
            {
                
                for (int platformRow = i; platformRow < i + platform; platformRow++)
                {
                    for (int platformCol = j; platformCol < j + platform; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
                sum = 0;
            }
        }
        return bestSum;
    }

    static int counter = 0;
    static int[,] FillArray(int[,] array, string line)
    {
        string[] reminder;
        reminder = Regex.Split(line, " "); 
        for (int i = 0; i < reminder.Length; i++)
        {
            array[counter, i] = Convert.ToInt32(reminder[i]);
        }
        counter++;
        return array;
    }
}
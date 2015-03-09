using System;
class MatrixC
{
    static void Main()
    {
        Console.Write("Please enter N (square matrix N, N):");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            int row = i;
            int col = 0;
            while (row <= n - 1)
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
            }
        }
        for (int i = 1; i < n; i++)
        {
            int row = 0;
            int col = i;
            while (col <= n - 1)
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
            }
        }

        Console.WriteLine("The matrix is as follows:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}
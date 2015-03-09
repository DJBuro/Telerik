using System;
class MatrixB
{
    static void Main()
    {
        Console.Write("Please enter N (square matrix N, N):");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        for (int row = 0; row < n; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    matrix[col, row] = number;
                    number++;
                }
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

using System;
class MaxSum
{
    static void Main()
    {
        Console.Write("N= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M= ");
        int cols = int.Parse(Console.ReadLine());

        /* i left this if u want easy check on my homework. Best sum is 58 and {8,7,6}{5,6,7}{9,6,4} is best platform!
           int[,] matrix = {
                            {1,2,3,4,5,6,7},
                            {2,3,4,5,6,7,8},
                            {8,7,6,5,4,3,3},
                            {5,6,7,3,2,1,9},
                            {9,6,4,2,5,8,1}
                        }; */
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++) // Fill matrix
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Array[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        int platform = 3;
        while (rows < platform|| cols < platform) // Check if matrix is bigger from square, we are looking for.
        {
            Console.WriteLine("Invalid matrix! Please re-enter N and M");
            Console.Write("N= ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("M= ");
            cols = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int bestSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;
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
                    startRow = i;
                    startCol = j;
                }
                sum = 0;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Best sum is {0} in matrix:", bestSum);
        for (int i = startRow; i < startRow + platform; i++)
        {
            for (int j = startCol; j < startCol + platform; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
namespace Homework
{
    using System;

    public class Print
    {
        public void PrintStatistics(double[] numbers)
        {
            double max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            this.PrintResult(max);
            double min = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            this.PrintResult(min);
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }

            this.PrintResult(average / numbers.Length);
        }

        public void PrintResult(double number)
        {
            Console.WriteLine(number);
        }
    }
}
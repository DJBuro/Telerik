//Problem 9. Sum of n Numbers
//
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter how much numbers u want to sum: ");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;
        
        for (int i = 1; i <= number; i++)
        {
            Console.Write("n=");
            double n1 = double.Parse(Console.ReadLine());
            sum += n1;
        }
        Console.WriteLine("Sum of your numbers is {0}", sum);
    }
}

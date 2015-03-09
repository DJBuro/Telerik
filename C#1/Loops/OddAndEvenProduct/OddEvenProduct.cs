//Problem 10. Odd and Even Product
//
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter your numbers: ");
        string imput = Console.ReadLine();
        string[] array = imput.Split(' ');
        int oddNumber = 1;
        int evenNumber = 1;

        for (int i = 0; i < array.Length; i++)
        {
            int number = int.Parse(array[i]);
            if (i % 2 == 0 || i == 0)
            {
                oddNumber *= number;
            }
            else
            {
                evenNumber *= number;
            }
        }
        if (oddNumber == evenNumber)
        {
            Console.WriteLine("YES");
            Console.WriteLine("{0}", oddNumber);
        }
        else
        {
            Console.WriteLine("NO");
            Console.WriteLine("odd product = {0}", oddNumber);
            Console.WriteLine("even product = {0}", evenNumber);
        }
    }
}


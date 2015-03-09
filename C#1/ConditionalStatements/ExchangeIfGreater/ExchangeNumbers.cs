//Problem 1. Exchange If Greater
//
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is 
//greater than the second one. As a result print the values a and b, separated by a space.

using System;
class ExchangeNumbers
{
    static void Main()
    {
        Console.Write("Plaese enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Plaese enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (secondNumber < firstNumber)
        {
            Console.WriteLine("{0} {1}", secondNumber, firstNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}

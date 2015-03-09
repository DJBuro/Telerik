//Problem 8. Prime Number Check
//
//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;
class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Number (1-100):");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number < 1 || number > 100)
        {
            Console.WriteLine("{0} is not a valid", number);
            Console.WriteLine("Please enter 0-100");
            number = Convert.ToInt32(Console.ReadLine());
        }

        double sqrtNumber = Math.Sqrt(number);
        int i;
        for (i = 1; i < sqrtNumber; i++);
        {
            bool result = (number % i != 0);
            Console.WriteLine("{0} is prime number: {1}", number, result);
        }
    }
}

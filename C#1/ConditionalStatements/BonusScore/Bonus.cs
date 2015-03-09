//Problem 2. Bonus Score
//
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;
class Bonus
{
    static void Main()
    {
        Console.Write("Please enter number (1-9): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
            case 2:
            case 3:
                number *= 10;
                Console.WriteLine(number); break;
            case 4:
            case 5:
            case 6:
                number *= 100;
                Console.WriteLine(number); break;
            case 7:
            case 8:
            case 9:
                number *= 1000;
                Console.WriteLine(number); break;
            default:
                Console.WriteLine("Invalid number!"); break;
        }
    }
}


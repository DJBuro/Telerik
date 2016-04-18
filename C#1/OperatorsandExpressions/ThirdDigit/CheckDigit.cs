//Problem 5. Third Digit is 7?
//
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class CheckDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divider = number / 100;
        bool result = (divider % 10 == 7);
        Console.WriteLine(result.ToString().ToLower());
    }
}

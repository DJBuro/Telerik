using System;
class Numbers1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}


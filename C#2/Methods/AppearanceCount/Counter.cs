//Problem 4. Appearance count
//
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
class Counter
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = FillArray();

        int counter = Count(arrayOfNumbers, number);

        Print(counter, number);

    }
    static void Print(int counter, int number)
    {
        Console.WriteLine();
        Console.WriteLine("In array you enter {0} - {1} times", number, counter);
    }
    static int Count(int[] arrayOfNumbers, int number)
    {
        int counter = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
    static int[] FillArray()
    {
        Console.Write("Array Lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}

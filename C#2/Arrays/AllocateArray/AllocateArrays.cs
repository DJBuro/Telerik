﻿//Problem 1. Allocate array
//
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;
class AllocateArrays
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = index * 5;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}


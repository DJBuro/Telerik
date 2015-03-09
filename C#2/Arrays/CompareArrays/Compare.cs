//Problem 2. Compare arrays
//
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class Compare
{
    static void Main()
    {
        Console.WriteLine("Please enter lenght of Arrays: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] firstArray = new int[lenght];
        int[] secondArray = new int[lenght];

        Console.WriteLine("Please enter integers in first Array:");
        for (int a = 0; a < lenght; a++)
        {
            Console.Write("{0}=", (a + 1));
            firstArray[a] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter integers in second Array:");
        for (int b = 0; b < lenght; b++)
        {
            Console.Write("{0}=", (b + 1));
            secondArray[b] = int.Parse(Console.ReadLine());
        }

        int check = 0; // To check when it compare all elements
        for (int i = 0; i < lenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("Arrays are different in index {0}!", i);
                break;
            }
            else
            {
                check++;
                if (check == lenght)
                {
                    Console.WriteLine("Arrays are same!");
                }
            }
        }
    }
}


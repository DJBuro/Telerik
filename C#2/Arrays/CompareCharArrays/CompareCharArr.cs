//Problem 3. Compare char arrays
//
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArr
{
    static void Main()
    {
        Console.WriteLine("Please enter lenght of Arrays: ");
        int lenght = int.Parse(Console.ReadLine());
        char[] firstArray = new char[lenght];
        char[] secondArray = new char[lenght];

        Console.WriteLine("Please enter chars in first Array:");
        for (int a = 0; a < lenght; a++)
        {
            Console.Write("{0}=", (a + 1));
            firstArray[a] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter chars in second Array:");
        for (int b = 0; b < lenght; b++)
        {
            Console.Write("{0}=", (b + 1));
            secondArray[b] = char.Parse(Console.ReadLine());
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



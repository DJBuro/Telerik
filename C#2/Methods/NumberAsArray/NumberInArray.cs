using System;
using System.Linq;
using System.Collections.Generic;

class NumberInArray
{
    static void Main()
    {
        Console.Write("Please enter first number:");
        string firstNumber = Console.ReadLine();
        Console.Write("Please enter second number:");
        string secondNumber = Console.ReadLine();

        int[] firstArray = Reverse(firstNumber);
        int[] secondArray = Reverse(secondNumber);

        int[] sum = SumArrays(firstArray, secondArray);

        string result = string.Join("", sum.Select(i => i.ToString()).ToArray());

        Console.WriteLine(result);
        
    }
    private static int[] SumArrays(int[] firstArray, int[] secondArray)
    {
        int sumLenght;
        if (firstArray.Length >= secondArray.Length)
        {
            sumLenght = firstArray.Length + 1;
        }
        else
        {
            sumLenght = secondArray.Length + 1;
        }
        int[] sum = new int[sumLenght];
        int a;
        int b;
        int divider = 0;
        for (int i = 0; i < sum.Length; i++)
        {
            if (i <= firstArray.Length - 1)
            {
                a = firstArray[i];
            }
            else
            {
                a = 0;
            }
            if (i <= secondArray.Length - 1)
            {
                b = secondArray[i];
            }
            else
            {
                b = 0;
            }
            sum[i] = ((a + b) % 10) + divider;
            divider = (a + b) / 10;
        }
        Array.Reverse(sum);
        return sum;
    }

    private static int[] Reverse(string reminder)
    {
        char[] arrayOfChars = reminder.ToCharArray();
        Array.Reverse(arrayOfChars);
        int[] arrayOfInts = arrayOfChars.Select(i => i - '0').ToArray();
        return arrayOfInts;
    }
}

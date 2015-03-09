//Problem 14. Quick sort
//
//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
class QuickSortAlgorithm
{
    static void Main()
    {
        int[] numbers = { 1, 5, 7, 20, 8, 2, 11, 9, 5, 16 };

        Console.WriteLine("{0}", string.Join(" ", numbers));

        Quick(numbers, 0, numbers.Length - 1);

        Console.WriteLine("{0}", string.Join(" ", numbers));
    }
    static void Quick(int[] elements, int left, int right)
    {
        
        int leftIndex = left;
        int rightIndex = right;
        int pivot = elements[(left + right) / 2];

        while (leftIndex <= rightIndex)
        {
            while (elements[leftIndex] - pivot < 0) leftIndex++;
            while (elements[rightIndex] - pivot > 0) rightIndex--;
            if (leftIndex <= rightIndex)
            {
                int switcher = elements[leftIndex];
                elements[leftIndex] = elements[rightIndex];
                elements[rightIndex] = switcher;
                leftIndex++;
                rightIndex--;
            }
        }
        if (left < rightIndex) Quick(elements, left, rightIndex);
        if (leftIndex < right) Quick(elements, leftIndex, right);
    }
}
using System;
class MergeSortAlgorithm
{
    static void Main()
    {
        int[] numbers = { 1, 5, 7, 20, 8, 2, 11, 9, 5, 16 };
        int[] temp = new int[numbers.Length];

        Console.WriteLine("{0}", string.Join(" ", numbers));

        Merge(numbers, temp, 0, numbers.Length -1);

        Console.WriteLine("{0}", string.Join(" ", numbers));
    }
    static void Merge (int[] array, int[] tmp, int start, int end)
    {
        if (start >= end) return;

        int middle = start + (end - start) / 2;

        Merge(array, tmp, start, middle);
        Merge(array, tmp, middle + 1, end);

        Compare(array, tmp, start, middle, end);
    }
    static void Compare(int[] array, int[] tmp, int start, int middle, int end)
    {
        int leftTemp = start;
        int leftArray = start;
        int middleArray = middle + 1;

        while (leftArray <= middle && middleArray <= end)
        {
            if (array[leftArray] > array[middleArray])
            {
                tmp[leftTemp++] = array[middleArray++];
            }
            else
            {
                tmp[leftTemp++] = array[leftArray++];
            }
        }

        while (leftArray <= middle)
            tmp[leftTemp++] = array[leftArray++];

        while (middleArray <= end)
            tmp[leftTemp++] = array[middleArray++];

        for (int i = start; i <= end; i++)
            array[i] = tmp[i];
    }
}
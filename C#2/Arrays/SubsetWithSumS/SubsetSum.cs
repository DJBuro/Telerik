using System;
class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Please enter N:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Please enter N elements: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        int maxSum = 0;
        int offset = 0;

        for (int i = 0; i < numbers.Length; i++)
		{
		    if (numbers[i] < 0)
            {
                offset += numbers[i];
            }
            else if (numbers[i] > 0)
            {
                maxSum += numbers[i];
            }
		}
        if (sum > maxSum)
        {
            Console.WriteLine("NO");
        }
        else
        {
            bool[] possibleSums = new bool[maxSum + 1 + offset * -1 ];
            possibleSums[offset * -1] = true;

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    for (int i = 0; i < possibleSums.Length; i++)
                    {
                        if (possibleSums[i])
                        {
                            possibleSums[i + number] = true;
                        }
                    }
                }
                else
                {
                    for (int i = possibleSums.Length - 1; i >= 0; i--)
                    {
                        if (possibleSums[i])
                        {
                            possibleSums[i + number] = true;
                        }
                    }
                }
            }
            
            if (possibleSums[sum + offset * - 1] == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

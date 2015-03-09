using System;
class IntCalculations
{
    static void Main()
    {
        Console.Write("Please ente how much numbers u want in set:");
        int n = int.Parse(Console.ReadLine());
        
        int[] numbers = FillArray();

        int minimum = Minimum(numbers);
        Console.WriteLine("Min = {0}", minimum);
        int maximum = Maximum(numbers);
        Console.WriteLine("Max = {0}", maximum);
        int sum = Sum(numbers);
        Console.WriteLine("Sum = {0}", sum);
        int average = Average(numbers, sum);
        Console.WriteLine("Average = {0}", average);
        long produkt = Produkt(numbers);
        Console.WriteLine("product = {0}", produkt);

    }
    static int Minimum(int[] numbers)
    {
        int minimum = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
			{
			    if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
			}
        return minimum;
    }
    static int Maximum(int[] numbers)
    {
        int maximum = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
			{
			    if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
			}
        return maximum;
    }
    static int Sum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int Average(int[] numbers, int sum)
    {
        int result = sum / numbers.Length;
        return result;
    }
    static long Produkt(int[] numbers)
    {
        long produkt = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            produkt = produkt * numbers[i];
        }
        return produkt;
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
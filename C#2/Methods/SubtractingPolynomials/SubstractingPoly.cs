//Problem 12. Subtracting polynomials
//
//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
class SubstractingPoly
{
    static void Main()
    {
        int[] firstPoly = EnterPolynomial();
        int[] secondPoly = EnterPolynomial();

        PrintPolynomial(firstPoly);
        PrintPolynomial(secondPoly);
        
        int[] multiPoly = MultiplicationArrays(firstPoly, secondPoly);
        PrintPolynomial(multiPoly);

        secondPoly = ChangeSigns(secondPoly);
        int[] substractPoly = SumArrays(firstPoly, secondPoly);
        PrintPolynomial(substractPoly);
    }
    static int[] ChangeSigns(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * -1;
        }
        return array;
    }
    static int[] MultiplicationArrays(int[] firstPoly, int[] secondPoly)
    {
        int[] result = new int[firstPoly.Length + secondPoly.Length - 1];
        for (int i = 0; i < firstPoly.Length; i++)
        {
            for (int j = 0; j < secondPoly.Length; j++)
            {
                result[i + j] += firstPoly[i] * secondPoly[j];
            }
        }
        return result;
    }
    public static int[] SumArrays(int[] firstArray, int[] secondArray)
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
    static int[] EnterPolynomial()
    {
        Console.Write("Enter your polynomial degree: ");
        int degree = int.Parse(Console.ReadLine());

        int[] polynomial = new int[degree + 1];

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + ": ");
            polynomial[i] = int.Parse(Console.ReadLine());
        }
        return polynomial;
    }
    static void PrintPolynomial(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (i == polynomial.Length - 1 && polynomial[i] != 0)
            {
                Console.Write("     {0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
            }
            else if (i == 0)
            {
                if (polynomial[i] < 0) Console.Write("{0}{1} ", "- ", -polynomial[i]);
                else if (polynomial[i] > 0) Console.Write("{0}{1} ", "+ ", polynomial[i]);
            }
            else
            {
                if (polynomial[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
                else if (polynomial[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
            }
        }
        Console.WriteLine();
    }
}
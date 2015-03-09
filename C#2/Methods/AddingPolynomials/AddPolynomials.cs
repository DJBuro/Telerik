//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;
class AddPolynomials
{
    static void Main()
    {
        int[] firstPoly = EnterPolynomial(out firstPoly);
        int[] secondPoly = EnterPolynomial(out secondPoly);
        
        int[] sum = SumArrays(firstPoly, secondPoly);

        PrintPolynomial(firstPoly);
        PrintPolynomial(secondPoly);
        PrintPolynomial(sum);
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
    static int[] EnterPolynomial(out int[] polynomial)
    {
        Console.Write("Enter your polynomial degree: ");
        int degree = int.Parse(Console.ReadLine());

        polynomial = new int[degree + 1];

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

using System;
class CompareFloats
{
    static void Main()
    {
        //Console.WriteLine("First  Number a= ");
        double a = double.Parse(Console.ReadLine());
        //Console.WriteLine("Second Number b= ");
        double b = double.Parse(Console.ReadLine());

        bool areEqual = Math.Abs(a - b) < 0.000001;
        Console.WriteLine(areEqual.ToString().ToLower());
        
    }
}

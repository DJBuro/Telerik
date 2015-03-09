//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8
//and assign a Unicode-friendly font in the console.

using System;
    class Quotes
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char copyright = '\u00A9';

            Console.WriteLine("   {0}\n\n  {0} {0}\n\n {0}   {0}\n\n{0} {0} {0} {0}", copyright);
        }
    }
        


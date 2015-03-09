//Problem 9. Play with Int, Double and String
//
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n\r1 --> int\n\r2 --> double\n\r3 --> string");
        int choise = int.Parse(Console.ReadLine());

        if (choise == 1)
        {
            Console.Write("Please enter a integer: ");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine(integer + 1);
        }
        else if (choise == 2)
        {
            Console.Write("Please enter a real number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        else if (choise == 3)
        {
            Console.Write("Please enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("{0}*", text);
        }
        else
        {
            Console.WriteLine("Wrong choise");
        }
    }
}


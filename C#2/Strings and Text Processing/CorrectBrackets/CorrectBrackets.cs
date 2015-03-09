using System;
class CorrectBrackets
{
    static void Main()
    {
        string input = "((a+b)/5-d)";
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                count++;
            }
            else if (input[i] == ')')
            {
                count--;
                if (count < 0)
                {
                    break;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine(input);
            Console.WriteLine("Brackets are ok!");
        }
        else
        {
            Console.WriteLine(input);
            Console.WriteLine("Brackets are wrong!");
        }
    }
}
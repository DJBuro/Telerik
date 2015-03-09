using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<int> list = new List<int>();
    static Tuple<int, int> tuple = new Tuple<int, int>(e, f);
    static int a;
    static int b;
    static int c;
    static int d;
    static int e;
    static int f;
    static void Main()
    {
        int[,] numbers = {
                            {1,3,2,2,2,4},
                            {3,3,3,2,4,4},
                            {4,3,1,2,3,3},
                            {4,3,1,3,3,1},
                            {4,3,3,3,1,1}
                         };
        int[,] reminder = new int[numbers.GetLength(0), numbers.GetLength(1)];

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 1; j < numbers.GetLength(1); j++)
            {
                a = i;
                b = j;
                reminder[i, j] = numbers[i, j];
                while (true)
                {
                    while (true)
                    {
                        c = CheckReminderLeft(numbers, reminder, a, b);
                        if (d == c + 1)
                        {
                            b = c;
                            d = int.MinValue;
                            break;
                        }
                        c = CheckReminderBot(numbers, reminder, a, b);
                        if (d == c - 1)
                        {
                            a = c;
                            d = int.MinValue;
                            break;
                        }
                        c = CheckReminderRight(numbers, reminder, a, b);
                        if (d == c - 1)
                        {
                            b = c;
                            d = int.MinValue;
                            break;
                        }
                        c = CheckReminderTop(numbers, reminder, a, b);
                        if (d == c + 1)
                        {
                            a = c;
                            d = int.MinValue;
                            break;
                        }
                        GetBack(numbers, a, b);
                        a = e;
                        b = f;
                    }
                }
            }
        }
    }
    static void GetBack(int[,] numbers, int a, int b)
    {
        if (b >= numbers.GetLength(1))
        {
            if (numbers[a, b + 1] == numbers[a, b])
            {
                f = b + 1;
                e = a;
                return;
            }
        }
        else if (numbers[a + 1, b] == numbers[a, b])
        {
            a += 1;
            return;
        }
        else if (numbers[a, b - 1] == numbers[a, b])
        {
            b -= 1;
            return;
        }
        else if (numbers[a - 1, b] == numbers[a, b])
        {
            a -= 1;
            return;
        }
        else
        {
            return;
        }
    }
    static int CheckReminderLeft(int[,] numbers, int[,] reminder, int a, int b)
    {
        if (b > 0)
        {
            if (numbers[a, b - 1] == numbers[a, b])
            {
                if (reminder[a, b - 1] != numbers[a, b - 1])
                {
                    reminder[a, b - 1] = numbers[a, b - 1];
                    list.Add(numbers[a, b]);
                    d = b;
                    c = b - 1;
                    return c;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                return c;
            }
        }
        else return c;
    }
    static int CheckReminderBot(int[,] numbers, int[,] reminder, int a, int b)
    {
        if (a < numbers.GetLength(0) - 1)
        {
            if (numbers[a + 1, b] == numbers[a, b])
            {
                if (reminder[a + 1, b] != numbers[a + 1, b])
                {
                    reminder[a + 1, b] = numbers[a + 1, b];
                    list.Add(numbers[a, b]);
                    d = a;
                    c = a + 1;
                    return c;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                return c;
            }
        }
        else return c;
    }
    static int CheckReminderRight(int[,] numbers, int[,] reminder, int a, int b)
    {
        if (b < numbers.GetLength(1) - 1)
        {
            if (numbers[a, b + 1] == numbers[a, b])
            {
                if (reminder[a, b + 1] != numbers[a, b + 1])
                {
                    reminder[a, b + 1] = numbers[a, b + 1];
                    list.Add(numbers[a, b]);
                    d = b;
                    c = b + 1;
                    return c;
                }
                else return c;
            }
            else return c;
        }
        else return c;
    }


    static int CheckReminderTop(int[,] numbers, int[,] reminder, int a, int b)
    {
        if (a > 0)
        {
            if (numbers[a - 1, b] == numbers[a, b])
            {
                if (reminder[a - 1, b] != numbers[a - 1, b])
                {
                    reminder[a - 1, b] = numbers[a - 1, b];
                    list.Add(numbers[a, b]);
                    d = a;
                    c = a - 1;
                    return c;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                return c;
            }
        }
        else return c;
    }
}
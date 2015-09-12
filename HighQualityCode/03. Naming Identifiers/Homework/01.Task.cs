namespace Homework
{
    using System;

    public class Test
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            Test.Printer var = new Test.Printer();
            var.Print(true);
        }

        public class Printer
        {
            public void Print(bool var)
            {
                string varToString = var.ToString();
                Console.WriteLine(varToString);
            }
        }
    }
}

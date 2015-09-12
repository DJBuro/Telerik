namespace Homework
{
    using System;

    public class Loop
    {
        public static void Main()
        {
            int[] array = new int[100];
            int expectedValue = 60;
            bool valueFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == expectedValue)
                {
                    valueFound = true;
                }
            }

            // More code here
            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

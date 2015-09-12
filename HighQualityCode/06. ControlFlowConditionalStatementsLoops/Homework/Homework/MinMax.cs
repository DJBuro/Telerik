namespace Homework
{
    using System;

    public class Task2
    {
        private const int MIN_X = 0;
        private const int MAX_X = 10;
        private const int MIN_Y = 0;
        private const int MAX_Y = 10;

        public static void Main()
        {
            int x = 6;
            bool xInRange = false;
            if (MIN_X < x && x < MAX_X)
            {
                xInRange = true;
            }

            int y = 8;
            bool yInRange = false;
            if (MIN_Y < y && y < MAX_Y)
            {
                yInRange = true;
            }

            bool visitedCell = false;
            if (xInRange && yInRange && !visitedCell)
            {
                VisitCell();
            }
        }
    }
}

namespace Homework
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size figure, double angleOfTheFigure)
        {
            double rotateWidth = (Math.Abs(Math.Cos(angleOfTheFigure)) * figure.width) +
                                 (Math.Abs(Math.Sin(angleOfTheFigure)) * figure.height);

            double rotateHeight = (Math.Abs(Math.Sin(angleOfTheFigure)) * figure.width) +
                                  (Math.Abs(Math.Cos(angleOfTheFigure)) * figure.height);

            return new Size(rotateWidth, rotateHeight);
        }
    }
}
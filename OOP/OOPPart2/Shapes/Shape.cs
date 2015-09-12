namespace Shapes
{
    using System;

    public abstract class Shape
    {
        public decimal width;
        public decimal height;


        public abstract decimal CalculateSurface();
    }
}
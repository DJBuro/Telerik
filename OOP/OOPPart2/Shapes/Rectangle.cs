using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height)
        {
            base.width = width;
            base.height = height;
        }

        public override decimal CalculateSurface()
        {
            return (base.width * base.height);
        }
    }
}

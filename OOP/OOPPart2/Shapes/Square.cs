﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(decimal side)
        {
            base.width = side;
            base.height = side;
        }

        public override decimal CalculateSurface()
        {
            return base.width * base.height;
        }
    }
}

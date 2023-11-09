using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{

    public class Rectangle : TwoDimensionalFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public override double GetInscribedCircleRadius()
        {
            return Math.Min(Width, Height) / 2.0;
        }

        public override double GetCircumscribedCircleRadius()
        {
            return Math.Sqrt(Width * Width + Height * Height) / 2.0;
        }
    }
    
}


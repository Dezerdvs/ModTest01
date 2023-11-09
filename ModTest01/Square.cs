using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Square : TwoDimensionalFigure
    {
        public double Side { get; set; }
        
        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override double GetInscribedCircleRadius()
        {
            return Side / 2;
        }

        public override double GetCircumscribedCircleRadius()
        {
            return Side * Math.Sqrt(2) / 2;
        }
    }
}

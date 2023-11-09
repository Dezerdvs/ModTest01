using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Rhombus : TwoDimensionalFigure
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public override double CalculateArea()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2));
        }

        public override double GetInscribedCircleRadius()
        {
            return Math.Min(Diagonal1, Diagonal2) / 2;
        }

        public override double GetCircumscribedCircleRadius()
        {
            return Math.Max(Diagonal1, Diagonal2) / 2;
        }
    }
}

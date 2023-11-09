using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Trapezoid : TwoDimensionalFigure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public override double CalculateArea()
        {
            return (Base1 + Base2) * Height / 2;
        }

        public override double CalculatePerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }

        public override double GetInscribedCircleRadius()
        {
            return 0; // Немає вписаної окружності для трапеції
        }

        public override double GetCircumscribedCircleRadius()
        {
            return 0; // Немає описаної окружності для трапеції
        }
    }
}

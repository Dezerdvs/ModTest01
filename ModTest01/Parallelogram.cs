using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Parallelogram : TwoDimensionalFigure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Base * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Base + Side);
        }

        public override double GetInscribedCircleRadius()
        {
            return 0; // Немає вписаної окружності для паралелограма
        }

        public override double GetCircumscribedCircleRadius()
        {
            return 0; // Немає описаної окружності для паралелограма
        }
    }
}

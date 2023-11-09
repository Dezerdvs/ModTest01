using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public abstract class ThreeDimensionalFigure : IFigure
    {
        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        public abstract double GetInscribedCircleRadius();
        public abstract double GetCircumscribedCircleRadius();
        public double CalculatePerimeter()
        {
            return 0; // Немає периметру для тривимірних фігур
        }
    }
}

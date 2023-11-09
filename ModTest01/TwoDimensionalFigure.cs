using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public abstract class TwoDimensionalFigure : IFigure
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract double GetInscribedCircleRadius();
        public abstract double GetCircumscribedCircleRadius();
        public double CalculateVolume()
        {
            return 0; // Немає об'єму для двовимірних фігур
        }
    }
}

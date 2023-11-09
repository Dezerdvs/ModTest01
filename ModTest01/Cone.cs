using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Cone : ThreeDimensionalFigure
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            double baseArea = Math.PI * Math.Pow(Radius, 2);
            double sideArea = Math.PI * Radius * Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
            return baseArea + sideArea;
        }

        public override double CalculateVolume()
        {
            return (1.0 / 3) * Math.PI * Math.Pow(Radius, 2) * Height;
        }

        public override double GetInscribedCircleRadius()
        {
            return 0; // Немає вписаної окружності для конуса
        }

        public override double GetCircumscribedCircleRadius()
        {
            return Radius;
        }
    }
}

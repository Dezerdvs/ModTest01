using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Cylinder : ThreeDimensionalFigure
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 2 * Math.PI  * (Radius + Height);
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        public override double GetInscribedCircleRadius()
        {
            return 0; // Немає вписаної окружності для циліндра
        }

        public override double GetCircumscribedCircleRadius()
        {
            return Radius + Height;
        }
    }
}


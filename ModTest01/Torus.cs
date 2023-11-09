using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public class Torus : ThreeDimensionalFigure
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }

        public override double CalculateArea()
        {
            return 4 * Math.PI * MajorRadius * MinorRadius;
        }

        public override double CalculateVolume()
        {
            return 2 * Math.PI * Math.Pow(MajorRadius, 2) * Math.PI * MinorRadius;
        }

        public override double GetInscribedCircleRadius()
        {
            return MajorRadius - MinorRadius;
        }

        public override double GetCircumscribedCircleRadius()
        {
            return MajorRadius + MinorRadius;
        }
    }
}

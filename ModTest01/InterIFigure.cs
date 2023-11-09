using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTest01
{
    public interface IFigure
    {
        double CalculateArea();
        double CalculateVolume();
        double CalculatePerimeter();
        double GetInscribedCircleRadius();
        double GetCircumscribedCircleRadius();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public abstract class Figure
    {
        public double X { get; }
        public double Y { get; }
        public Figure(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        public abstract T Accept<T>(IVisiteurDeFigure<T> visiteur);
    }
}

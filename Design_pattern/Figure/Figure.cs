using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public abstract class Figure
    {
        public double X { get; }
        public double Y { get; }
        public Point anchor { get; }
        public Figure(double _x, double _y,Point _anchor)
        {
            X = _x;
            Y = _y;
            anchor = _anchor;
        }
        public abstract T Accept<T>(IVisiteurDeFigure<T> visiteur);
        public abstract string Accept(IVisiteurDeFigure<string> visiteur);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Figures : Figure
    {
        public List<Figure> FiguresList { get; }
        public Figures(double _x,double _y,List<Figure> _figures)
            : base(_x, _y) 
        {
            FiguresList = _figures;
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
    }
}

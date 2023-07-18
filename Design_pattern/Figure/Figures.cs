using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Figures : Figure
    {
        public List<Figure> FiguresList { get; }
        public Figures(double _x,double _y,List<Figure> _figures)
            : base(_x, _y,new Point((int)_x/2,(int)_y/2)) 
        {
            FiguresList = _figures;
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
        public override string Accept(IVisiteurDeFigure<string> visiteur)
        {
            string res = "";
            foreach (Figure fig in FiguresList)
            {
                res += fig.Accept(visiteur);
            }
            return res;
        }
    }
}

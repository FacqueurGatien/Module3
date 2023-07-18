using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Rond : Figure
    {
        public double Rayon { get;}
        public Rond(double _x, double _y,double _rayon)
            : base(_x,_y, new Point((int)_rayon,(int)_rayon))
        {
            Rayon = _rayon;
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
        public override string Accept(IVisiteurDeFigure<string> visiteur)
        {
            return visiteur.Visite(this);
        }
    }
}


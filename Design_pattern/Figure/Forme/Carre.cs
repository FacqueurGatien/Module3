using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Carre : Rectangle
    {
        public double Cote { get; }
        public Carre(double _x, double _y, double _cote)
            : base(_x,_y,_cote, _cote)
        {
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
    }
}

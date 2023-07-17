using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Rectangle : Figure
    {
        public double Longueur { get; }
        public double Largeur { get; }
        public Rectangle(double _x, double _y, double _longueur, double _largeur)
            : base(_x, _y)
        {
            Longueur = _longueur;
            Largeur = _largeur;
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
    }
}

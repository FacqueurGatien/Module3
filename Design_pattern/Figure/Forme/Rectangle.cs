using System;
using System.Collections.Generic;
using System.Drawing;
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
            : base(_x, _y,new Point((int)_longueur / 2,(int)_largeur/ 2))
        {
            Longueur = _longueur;
            Largeur = _largeur;
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

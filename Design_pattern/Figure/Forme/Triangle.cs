using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public class Triangle : Figure
    {
        public double BaseGauche { get; }
        public double BaseDroite { get; }
        public double Hauteur { get; }
        public Triangle(double _x, double _y, double _baseGauche, double _baseDroite, double _hauteur)
            : base(_x, _y)
        {
            BaseGauche = _baseGauche;
            BaseDroite = _baseDroite;
            Hauteur = _hauteur;
        }
        public override T Accept<T>(IVisiteurDeFigure<T> visiteur)
        {
            return visiteur.Visite(this);
        }
    }
}

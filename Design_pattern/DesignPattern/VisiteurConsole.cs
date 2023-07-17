using FigureGeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class VisiteurConsole : IVisiteurDeFigure<string>
    {

        public string Visite(Carre carre)
        {
            return $"{carre.GetType().Name} de cote {carre.Longueur} et d'emplacement :\nx : {carre.X}\ny : {carre.Y}\n";
        }
        public string Visite(Rectangle rectangle)
        {
            return $"{rectangle.GetType().Name} de longueur {rectangle.Longueur}, de largeur {rectangle.Largeur} et d'emplacement :\nx : {rectangle.X}\ny : {rectangle.Y}\n";
        }
        public string Visite(Rond rond)
        {
            return $"{rond.GetType().Name} de rayon {rond.Rayon} et d'emplacement :\nx : {rond.X}\ny : {rond.Y}\n";
        }
        public string Visite(Triangle triangle)
        {
            return $"{GetType().Name} de base {triangle.BaseGauche + triangle.BaseDroite}, de hauteur {triangle.Hauteur} et d'emplacement :\nx : {triangle.X}\ny : {triangle.Y}\n";
        }
        public string Visite(Figures figures)
        {
            string res = "Ensemble de figure composer des figures suivante : \n\n";
            foreach (Figure fig in figures.FiguresList)
            {
                res += fig.Accept(this);
            }
            return res;
        }
    }
}

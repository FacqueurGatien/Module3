using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    public interface IVisiteurDeFigure<T>
    {
        public abstract T Visite(Rectangle rectangle);
        public abstract T Visite(Rond rond);
        public abstract T Visite(Triangle triangle);
        public abstract T Visite(Carre carre);
        public abstract T Visite(Figures figures);
    }
}

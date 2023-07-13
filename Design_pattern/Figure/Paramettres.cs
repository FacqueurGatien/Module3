using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Paramettres : Expression
    {
        private Coordonnee coordonnee;
        private Mesure mesures;
        public Paramettres(double[] _coord, double[] _mesures)
        {
            coordonnee = new Coordonnee(_coord[0], _coord[1]);
            mesures = new Mesure(_mesures);
        }
        public override string ToStringBis()
        {
            return coordonnee.ToStringBis() + " " + mesures.ToStringBis();
        }
    }
}

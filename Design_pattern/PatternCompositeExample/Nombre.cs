using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeExample
{
    public class Nombre : Expression
    {
        private readonly double valeur;
        public Nombre(double _valeur)
        {
            valeur = _valeur;
        }
        public override double Evalue()
        {
            return valeur;
        }
        public override string ToString()
        {
            return valeur.ToString();
        }

    }
}

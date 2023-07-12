using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeExample
{
    public class Nombre : Expression
    {
        private int valeur;
        public Nombre(int _valeur)
        {
            valeur = _valeur;
        }
        public override int Evalue()
        {
            return valeur;
        }
        public override string ToString()
        {
            return valeur.ToString();
        }

    }
}

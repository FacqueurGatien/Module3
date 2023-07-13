using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Mesure : Expression
    {
        internal double[] valeur;
        public Mesure(double[] _valeur)
        {
            valeur = _valeur;
        }
        public override string ToStringBis()
        {
            string result = "";
            foreach (double v in valeur)
            {
                result += $"Valeur 1 : {v}\n";
            }
            return result;
        }
    }
}

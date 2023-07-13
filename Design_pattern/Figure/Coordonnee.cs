using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Coordonnee
    {
        protected double x;
        protected double y;
        
        public Coordonnee(double _x,double _y)
        {
            x = _x;
            y = _y;
        }
        public string ToStringBis()
        {
            return $"Coord x : {x}\nCoord y : {y}\n";
        }
    }
}

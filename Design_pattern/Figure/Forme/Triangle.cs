using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Forme
{
    public class Triangle : Figure
    {
        public Triangle(Expression _params)
            : base(_params)
        {
        }

        public override string ToStringBis()
        {
            return $"{paramettres.ToStringBis()}";
        }
    }
}

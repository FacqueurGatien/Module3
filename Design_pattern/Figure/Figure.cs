using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class Figure:Expression
    {
        protected Expression paramettres;
        public Figure(Expression _paramettres)
        {
            paramettres = _paramettres;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeExample
{
    public abstract class Binaire:Expression
    {
        protected Expression op1;
        protected Expression op2;
        public Binaire(Expression _op1, Expression _op2)
        {
            this.op1 = _op1;
            this.op2 = _op2;
        }
    }
}

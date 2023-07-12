using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeExample
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression _op1, Expression _op2) 
            : base(_op1, _op2)
        {
        }
        public override int Evalue()
        {
            return op1.Evalue() - op2.Evalue();
        }
        public override string ToString()
        {
            return $"({op1}-{op2})";
        }
    }
}

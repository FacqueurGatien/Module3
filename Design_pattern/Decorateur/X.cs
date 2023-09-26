using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public class X : PlateformDecorateur
    {
        public X(IDecorateur _decorateur) : base(_decorateur)
        {
        }
    }
}

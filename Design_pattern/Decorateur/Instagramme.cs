using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public class Instagramme : PlateformDecorateur
    {
        public Instagramme(IDecorateur _decorateur) : base(_decorateur)
        {
        }
    }
}

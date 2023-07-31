using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposititeAtome
{
    public class ElementChimique
    {
        protected string nom;

        public ElementChimique(string _nom)
        {
            nom = _nom;
        }
        public virtual string TostringBis()
        {
            return nom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposititeAtome
{
    public class CorpsCompose : Molecule
    {
        public CorpsCompose(string _nom, List<ElementChimique> _elementsChimique)
            : base(_nom, _elementsChimique)
        {

        }
    }
}

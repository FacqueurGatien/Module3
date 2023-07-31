using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposititeAtome
{
    public abstract class Molecule : ElementChimique
    {
        private List<ElementChimique> compositions;
        public Molecule(string _nom, List<ElementChimique> _compositions)
            : base(_nom)
        {
            compositions = _compositions;
        }
        public override string TostringBis()
        {
            string result = "";
            compositions.ForEach(m => result += m.TostringBis() + ",");
            return $"{base.TostringBis()} [Composition]:\n{result.Trim(',')}";
        }
    }
}

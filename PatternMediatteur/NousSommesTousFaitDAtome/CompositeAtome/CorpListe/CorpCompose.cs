using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.CorpListe
{
    public class CorpCompose : CorpSimple
    {
        List<CorpSimple> corpSimples;
        public CorpCompose(List<CorpSimple> _corpSimples)
            :base("")
        {
            corpSimples = _corpSimples;
        }
        public int NombreAtome()
        {
            return corpSimples.Count;
        }
        public override string ToStringBis() 
        {
            string result = "";
            corpSimples.ForEach(cs => result += "    "+cs.ToStringBis());
            return $"Molecule {nom}\n    Compositions :\n{result}";
        }
    }
}

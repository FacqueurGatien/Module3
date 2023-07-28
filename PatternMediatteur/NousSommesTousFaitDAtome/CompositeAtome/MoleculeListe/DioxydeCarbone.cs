using CompositeAtome.CorpListe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.MoleculeListe
{
    public class DioxydeCarbone:Molecule
    {
        public DioxydeCarbone() 
            : base("Dioxyde De Carbone")
        {
            atomeListe.Add(new CorpCompose( new List<CorpSimple>() { new Oxygene(), new Oxygene() } ) );
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Carbone() }));
        }

    }
    
}

using CompositeAtome.CorpListe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.MoleculeListe
{
    public class Eau : Molecule
    {

        public Eau( ) 
            : base("Eau")
        {
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Oxygene() }));
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Hydrogene(),new Hydrogene() }));
        }

    }
}

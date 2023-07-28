using CompositeAtome.CorpListe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.MoleculeListe
{
    public class Dioxygene : Molecule
    {

        public Dioxygene() 
            : base("Dioxygene")
        {
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Oxygene(),new Oxygene() }));
        }

    }
}

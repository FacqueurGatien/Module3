using CompositeAtome.CorpListe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.MoleculeListe
{
    public class Metane : Molecule
    {

        public Metane() 
            : base("Metane")
        {
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Carbone() }));
            atomeListe.Add(new CorpCompose(new List<CorpSimple>() { new Hydrogene(), new Hydrogene(), new Hydrogene(), new Hydrogene() }));
        }

    }
}

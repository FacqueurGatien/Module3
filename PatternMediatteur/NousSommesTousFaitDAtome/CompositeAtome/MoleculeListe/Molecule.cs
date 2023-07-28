using CompositeAtome.CorpListe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAtome.MoleculeListe
{
    public class Molecule:CorpSimple       
    {
        protected string nom;
        protected List<CorpCompose> atomeListe;
        public Molecule(string _nom)
            :base(_nom)
        {
            nom = _nom;
            atomeListe = new List<CorpCompose>();   
        }
        public override string ToStringBis()
        {
            string result = "";
            atomeListe.ForEach(m => result += $"{m.NombreAtome()} {m.ToStringBis()} et ");
            result.Remove(result.Length - 1);
            result.Remove(result.Length - 1);
            result.Remove(result.Length - 1);
            return base.ToStringBis() + $"\nComposé de {result}";
        }
    }
}

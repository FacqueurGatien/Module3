using CompositeAtome.CorpListe;
using CompositeAtome.MoleculeListe;

namespace NousSommesTousFaitDAtome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DioxydeCarbone ddc = new();
            Console.WriteLine(ddc.ToStringBis());
        }
    }
}
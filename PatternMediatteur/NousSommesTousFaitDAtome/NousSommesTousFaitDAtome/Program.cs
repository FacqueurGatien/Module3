using ComposititeAtome;
using IteratorAtome;

namespace NousSommesTousFaitDAtome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Icolection<ElementChimique> collection = new ConcreteCollection<ElementChimique>(); 

            Atome oxygene = new("Oxygene");
            Atome carbone = new("Carbone");
            Atome hydrogene = new("Hydrogene");
            Atome azote = new("Azote");
            CorpsSimple dioxygene = new("Dioxygene", new List<ElementChimique>() { oxygene, oxygene });
            CorpsCompose eau = new("Eau", new List<ElementChimique>() { hydrogene, hydrogene, oxygene });
            CorpsCompose dioxydeCarbone = new("Dioxyde de carbone", new List<ElementChimique>() { carbone, dioxygene });
            CorpsCompose methane = new("Methane", new List<ElementChimique>() { carbone, hydrogene, hydrogene, hydrogene, hydrogene });

            collection.Add(oxygene);
            collection.Add(carbone);
            collection.Add(hydrogene);
            collection.Add(azote);
            collection.Add(dioxygene);
            collection.Add(eau);
            collection.Add(dioxydeCarbone);
            collection.Add(methane);

            Iiterator<ElementChimique, Atome> iteratorA = collection.GetIterator<ElementChimique,Atome>();
            Iiterator<ElementChimique, CorpsSimple> iteratorCS = collection.GetIterator<ElementChimique, CorpsSimple>();
            Iiterator<ElementChimique, CorpsCompose> iteratorCC = collection.GetIterator<ElementChimique, CorpsCompose>();

            Console.WriteLine("________________Iterator A_________________________________");
            while (iteratorA.HasNext())
            {
                Console.WriteLine(iteratorA.GetNext().TostringBis() + "\n");
            }
            Console.WriteLine("________________Iterator C.S_________________________________");
            while (iteratorCS.HasNext())
            {
                Console.WriteLine(iteratorCS.GetNext().TostringBis() + "\n");
            }
            Console.WriteLine("________________Iterator C.C_________________________________");
            while (iteratorCC.HasNext())
            {
                Console.WriteLine(iteratorCC.GetNext().TostringBis() + "\n");
            }
            Console.WriteLine("_________________________________________________");
        }
    }
}
using Decorateur;
using FigureGeo;
using PatternCompositeExample;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDecorateur pX = (IDecorateur)new Facebook(new Instagramme(new X(new ConcreteDecorateur())));
            Console.WriteLine(pX.Notify("J'aime pas les réseau sociaux"));
        }
    }
}
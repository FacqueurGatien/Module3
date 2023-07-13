using Figure;
using Figure.Forme;
using PatternCompositeExample;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(new Paramettres(new double[] {0,0},new double[] {15,25}));
            Console.WriteLine(t.ToStringBis());
        }
    }
}
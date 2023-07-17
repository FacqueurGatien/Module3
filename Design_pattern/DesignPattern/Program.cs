using FigureGeo;
using PatternCompositeExample;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(0,0,1,3,5);
            Rectangle re = new Rectangle(0, 5, 6, 2);
            Rond ro = new Rond(0, 11, 2);
            Carre c = new Carre(0, 15,3);

            Figures fs = new Figures(0,0,new List<Figure>() {t,re,ro,c});
            Console.WriteLine(fs.Accept(new VisiteurConsole()));
        }
    }
}
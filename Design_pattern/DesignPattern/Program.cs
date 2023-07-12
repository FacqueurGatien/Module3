using PatternCompositeExample;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition operation1 = new Addition(new Nombre(5),new Nombre(6));
            Nombre n = new Nombre(3);
            Console.WriteLine(n.Formate());
            Soustraction operation2 = new Soustraction(new Nombre(9),
                new Addition(new Nombre(8),
                    new Soustraction(new Nombre(5),
                        new Addition(new Nombre(6),new Nombre(7)))));

            Console.WriteLine(operation2.Formate());
            //1+2-4+3
            Addition ss = new Addition(new Soustraction(new Addition(new Nombre(1),new Nombre(2)),new Nombre(4)),new Nombre(3));
            Console.WriteLine(ss.Formate());
        }
    }
}
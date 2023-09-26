using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public class ConcreteDecorateur : IDecorateur
    {
        public ConcreteDecorateur()
        {

        }
        public string Notify(string _texte)
        {
            return "";
        }
    }
}

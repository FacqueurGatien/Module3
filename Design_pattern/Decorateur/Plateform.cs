using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public abstract class PlateformDecorateur : IDecorateur
    {
        private IDecorateur decorateur;
        public PlateformDecorateur(IDecorateur _decorateur)
        {
            decorateur = _decorateur;
        }
        public string Notify(string _message)
        {
            return $"Je suis {GetType().Name} et j'ai bien recu ce message:\n{_message}\n{decorateur.Notify(_message)}";
        }
    }
}

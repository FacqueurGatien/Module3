using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public interface IMediator
    {
        public void DemanderCV();
        public void EnvoyerCV(string nomPrenom,string cvJSON);
        public void RecevoirCV(string nomPrenom,string cvJSON);
    }
}

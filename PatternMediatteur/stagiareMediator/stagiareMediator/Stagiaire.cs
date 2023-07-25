using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class Stagiaire : Coleague
    {
        private string cvJSON;
        private string prenom;
        public Stagiaire(IMediator _mediator,string _nom, string _prenom,string _cvJSON)
            :base(_mediator,_nom)
        {
            prenom = _prenom;
            cvJSON = _cvJSON;
            ((MissionHandicap)mediator).InitializeStagiaire(this);
        }
        public void RequetteCV()
        {
            EnvoyerCV();
        }
        public void EnvoyerCV()
        {
            ((MissionHandicap)mediator).EnvoyerCV(nom+" "+prenom,cvJSON);
        }
        public override string InfoPublish()
        {
            if (nom=="Bounatirou" || nom=="Facqueur")
            {
                return $"Je m'apelle {nom.ToUpper()} {prenom}, je suis PILOTE !";
            }
            return $"Je m'apelle {nom.ToUpper()} {prenom}, je suis stagiaire au CRM de Mulhouse\n_____________________\n";
        }
        public override string CvPublish()
        {
            return $"Je m'apelle {nom.ToUpper()} {prenom}, et voici mon CV\n{cvJSON}\n_____________________\n\n";
        }
    }
}

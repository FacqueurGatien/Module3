using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class Societe:Coleague
    {
        private string fondateur;
        private int anneeCreation;
        private string directeur;
        private Dictionary<string,string> cvsStagiaireJSON;
        public Societe(IMediator _mediator,string _nom,string _fondateur, int _anneeCreation,string _directeur) 
            : base(_mediator,_nom)
        {
            fondateur = _fondateur;
            anneeCreation=_anneeCreation;
            directeur=_directeur;
            cvsStagiaireJSON = new Dictionary<string,string>();
            ((MissionHandicap)mediator).InitializeSociete(this);
        }
        public void DemanderCVs()
        {
            ((MissionHandicap)mediator).DemanderCV();
        }
        public void RecevoirCV(string nomPrenom,string cvJSON)
        {
            if (cvsStagiaireJSON.ContainsKey(nomPrenom))
            {
                cvsStagiaireJSON.Remove(nomPrenom);

            }
            cvsStagiaireJSON.Add(nomPrenom, cvJSON);
        }
        public override string InfoPublish()
        {
            return $"Je suis {nom}\n" +
                $"Plus grande ESN d'europe\n" +
                $"Je possede 360 000 collaborateur dans plus de 50 pays\n" +
                $"J'ai été fondé par {fondateur} en {anneeCreation}\n" +
                $"Mon directeur actuel est {directeur}\n_____________________\n";
        }
        public override string CvPublish()
        {
            string result="";
            foreach (KeyValuePair<string,string> cvStagiaire in cvsStagiaireJSON)
            {
                result += $"Voici le cv de Mr(s) {cvStagiaire.Key}\n\n{cvStagiaire.Value}\n_____________________\n\n";
            }
            return result;
        }
    }
}

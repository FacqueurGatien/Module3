using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class MissionHandicap : IMediator
    {
        private Societe societe;
        private List<Stagiaire> stagiaires;
        public MissionHandicap(string _nomReferent)
        {
            _nomReferent = _nomReferent;
            stagiaires = new List<Stagiaire>();
        }
        public void InitializeSociete(Societe _societe)
        {
            societe = _societe;
        }
        public void InitializeStagiaire(Stagiaire _stagiaire)
        {
            stagiaires.Add(_stagiaire);
        }
        public void DemanderCV()
        {
            stagiaires.ForEach(s => s.EnvoyerCV());
        }
        public void EnvoyerCV(string nomPrenom,string cvJSON)
        {
            RecevoirCV(nomPrenom,cvJSON);
        }
        public void RecevoirCV(string nomPrenom,string cvJSON)
        {
            societe.RecevoirCV(nomPrenom, cvJSON);
        }
    }
}

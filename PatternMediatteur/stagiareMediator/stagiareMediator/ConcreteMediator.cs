using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class ConcreteMediator : IMediator
    {
        /// <summary>
        /// Instance d'une <see cref="Societe"/> (ex: CapGemini)
        /// </summary>
        private Societe? societe;
        /// <summary>
        /// <see cref="List{T}"/> de <seealso cref="Stagiaire"/> (ex: stagiaire du CRM)
        /// </summary>
        private List<Stagiaire> stagiaires;
        /// <summary>
        /// Nom du referent de la <see cref="ConcreteMediator"/>
        /// </summary>
        private string nomReferent;
        /// <summary>
        /// Permet de garder en memoire le nombre de thread à déclancher
        /// </summary>
        //private CountdownEvent? countdownEvent;                       //Pour la version avec des thread

        /// <summary>
        /// Constructeur du Mediateur concret <see cref="ConcreteMediator"/> 
        /// </summary>
        /// <param name="_nomReferent">Nom du referent de la <see cref="ConcreteMediator"/></param>
        public ConcreteMediator(string _nomReferent) //Construction du mediator
        { 
            nomReferent = _nomReferent;
            stagiaires = new List<Stagiaire>();
        }
        /// <summary>
        /// Permet d'ajouter l'instance de <see cref="Societe"/> a la variable <seealso cref="societe"/>
        /// </summary>
        /// <param name="_societe">Instance de <see cref="Societe"/> à stocker</param>
        public void InitializeSociete(Societe _societe)
        { 
            societe = _societe; //Stockage de l'instance de CapGemini dans le mediator
        }
        /// <summary>
        /// Permet d'ajouter les instances de <see cref="Stagiaire"/> a la <seealso cref="List{T}"/> <seealso cref="stagiaires"/>
        /// </summary>
        /// <param name="_stagiaire">Instance de <see cref="Stagiaire"/> à stocker</param>
        public void InitializeStagiaire(Stagiaire _stagiaire)
        {
            stagiaires.Add(_stagiaire); //Stockage de l'instance d'un stagiaire dans la liste de stagiaire du mediator
            //countdownEvent = new CountdownEvent(stagiaires.Count);    //Pour la version avec des thread
        }
        /// <summary>
        /// Permet de demander aux <see cref="Stagiaire"/> de la <seealso cref="List{T}"/> <seealso cref="stagiaires"/> d'envoyer leur CV
        /// </summary>
        public void DemanderCV()
        {
            
            stagiaires.ForEach(s => //Pour chaque stagiaire enregistré
            {
                //Thread t = new Thread(s.RequetteCV);                  //Pour la version avec des thread
                //t.Start();                                            //Pour la version avec des thread
                s.RequeteCV(); //Appel de la methode RequetteCV d'un stagiaire
            });
            Thread.CurrentThread.Name = "Thread principal";
            //countdownEvent.Wait();                                    //Pour la version avec des thread
        }
        /// <summary>
        /// Permet a un <see cref="Stagiaire"/> de transmettre son CV au mediateur <seealso cref="ConcreteMediator"/>
        /// </summary>
        /// <param name="nomPrenom">Nom et prenom d'un <see cref="Stagiaire"/> permettant d'identifié l'emetteur du CV</param>
        /// <param name="cvJSON">CV d'un <see cref="Stagiaire"/></param>
        public void EnvoyerCV(string nomPrenom,string cvJSON)
        {
            RecevoirCV(nomPrenom,cvJSON); //Appel de la methode RecevoirCV avec les argument recu par la methode qui on etait envoyer depuis la methode EnvoyerCV du stagiaire
        }
        /// <summary>
        /// Permet de transmettre les CV des <see cref="Stagiaire"/> a la <seealso cref="Societe"/> en lien avec le mediateur <seealso cref="ConcreteMediator"/>
        /// </summary>
        /// <param name="nomPrenom">Nom et prenom d'un <see cref="Stagiaire"/> permettant d'identifié l'emetteur du CV</param>
        /// <param name="cvJSON">CV d'un <see cref="Stagiaire"/></param>
        public void RecevoirCV(string nomPrenom,string cvJSON)
        {
            societe.RecevoirCV(nomPrenom, cvJSON); //Appel de la methode RecevoirCV de CapGemini avec les argument recu par la methode qui on etait envoyer depuis la methode EnvoyerCV du mediator
            //countdownEvent.Signal();                  //Pour la version avec des thread
        }
    }
}

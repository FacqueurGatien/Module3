using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class Stagiaire : Colleague
    {
        /// <summary>
        /// CV d'un <see cref="Stagiaire"/>
        /// </summary>
        private string cvJSON;
        /// <summary>
        /// Prenom d'un <see cref="Stagiaire"/>
        /// </summary>
        private string prenom;

        /// <summary>
        /// Constructeur d'un <see cref="Stagiaire"/>
        /// </summary>
        /// <param name="_mediator">Instance du <see cref="IMediator"/></param>
        /// <param name="_nom">Nom de l'instance d'un <seealso cref="Stagiaire"/></param>
        /// <param name="_prenom">Prenom d'un <see cref="Stagiaire"/></param>
        /// <param name="_cvJSON">CV d'un <see cref="Stagiaire"/></param>
        public Stagiaire(IMediator _mediator,string _nom, string _prenom,string _cvJSON)
            :base(_mediator,_nom) //Construction d'un stagiaire
        {
            prenom = _prenom;
            cvJSON = _cvJSON;
            ((ConcreteMediator)mediator).InitializeStagiaire(this);
        }
        /// <summary>
        /// Permet de recevoir la demande du mediator d'envoyer son CV au mediator <see cref="ConcreteMediator"/>
        /// </summary>
        public void RequeteCV()
        {
            Thread.CurrentThread.Name = prenom;   //Pour la version avec des thread
            EnvoyerCV(); //Appel de la methode EnvoyerCV du stagiaire
        }
        /// <summary>
        /// Permet d'envoyer son CV au mediator <see cref="ConcreteMediator"/>
        /// </summary>
        public void EnvoyerCV()
        {
            ((ConcreteMediator)mediator).EnvoyerCV(nom+" "+prenom,cvJSON); //Appel de la methode EnvoyerCV du mediator avec les arguments necessaire
        }
        /// <summary>
        /// Permet de transmettre les informations du <seealso cref="Stagiaire"/>)
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public override string InfoPublish()
        {
            if (nom=="Bounatirou" || nom=="Facqueur")
            {
                return $"Je m'apelle {nom.ToUpper()} {prenom}, je suis PILOTE !";
            }
            return $"Je m'apelle {nom.ToUpper()} {prenom}, je suis stagiaire au CRM de Mulhouse\n_____________________\n";
        }
        /// <summary>
        /// Permet de transmettre le contenue du CV du <see cref="Stagiaire"/>
        /// </summary>
        /// <returns></returns>
        public override string CvPublish()
        {
            return $"Je m'apelle {nom.ToUpper()} {prenom}, et voici mon CV\n{cvJSON}\n_____________________\n\n";
        }
    }
}

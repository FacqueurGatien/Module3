using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public class Societe:Colleague
    {
        /// <summary>
        /// Identité du fondateur de la <see cref="Societe"/>
        /// </summary>
        private string fondateur;
        /// <summary>
        /// Année de création de la <see cref="Societe"/>
        /// </summary>
        private int anneeCreation;
        /// <summary>
        /// Identité du directeur actuel de la <see cref="Societe"/>
        /// </summary>
        private string directeur;
        /// <summary>
        /// <see cref="List{T}"/> de CV des <seealso cref="Stagiaire"/> en relation avec la <seealso cref="ConcreteMediator"/> qui on été transmis par ce dernier.
        /// </summary>
        private Dictionary<string,string> cvsStagiaireJSON;

        /// <summary>
        /// Constructeur d'une <see cref="Societe"/>
        /// </summary>
        /// <param name="_mediator">Instance du <see cref="IMediator"/></param>
        /// <param name="_nom">Nom de l'instance de la <seealso cref="Societe"/></param>
        /// <param name="_fondateur">Identité du fondateur de la <see cref="Societe"/></param>
        /// <param name="_anneeCreation">Année de création de la <see cref="Societe"/></param>
        /// <param name="_directeur">Identité du directeur actuel de la <see cref="Societe"/></param>
        public Societe(IMediator _mediator,string _nom,string _fondateur, int _anneeCreation,string _directeur) 
            : base(_mediator,_nom) //Construction de CapGemini
        {
            fondateur = _fondateur;
            anneeCreation=_anneeCreation;
            directeur=_directeur;
            cvsStagiaireJSON = new Dictionary<string,string>();
            ((ConcreteMediator)mediator).InitializeSociete(this);
        }
        /// <summary>
        /// Permet de demander au mediator <see cref="ConcreteMediator"/> de recuperer les CV des <seealso cref="Stagiaire"/> et de lui transmettre
        /// </summary>
        public void DemanderCVs()
        {
            ((ConcreteMediator)mediator).DemanderCV(); //Appel de la methode DemanderCV du mediator
        }
        /// <summary>
        /// Permet de recevoir du mediator <see cref="ConcreteMediator"/> les CV des <seealso cref="Stagiaire"/> 
        /// </summary>
        /// <param name="nomPrenom">Nom et prenom d'un <see cref="Stagiaire"/> permettant d'identifié l'emetteur du CV</param>
        /// <param name="cvJSON">CV d'un <see cref="Stagiaire"/></param>
        public void RecevoirCV(string nomPrenom,string cvJSON)
        {
            try
            {
                cvsStagiaireJSON.Add(nomPrenom, cvJSON); //Ajout des information au dictionnaire de CapGemini (nom prenom en key permettant d'identifier le cv et le CV en value)
            }
            catch (InvalidOperationException)
            {
                RecevoirCV(nomPrenom,cvJSON);                           //Pour la version avec des thread (conflit possible
            }
            catch (ArgumentException) //Si le stagiaire et son CV son deja enregistré
            {
                cvsStagiaireJSON.Remove(nomPrenom); //On enleve le stagiaire et son cv
                cvsStagiaireJSON.Add(nomPrenom, cvJSON); //On réajoute le stagiaire et son nouveau CV
                //Note on ajoute pas l'instance du stagiaire mais une cles permetant d'identifier a qui appartient le CV
            }
        }
        /// <summary>
        /// Permet de transmettre les informations de la <seealso cref="Societe"/>)
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public override string InfoPublish()
        {
            return $"Je suis {nom}\n" +
                $"Plus grande ESN d'europe\n" +
                $"Je possede 360 000 collaborateur dans plus de 50 pays\n" +
                $"J'ai été fondé par {fondateur} en {anneeCreation}\n" +
                $"Mon directeur actuel est {directeur}\n_____________________\n";
        }
        /// <summary>
        /// Permet de transmettre le contenue du CV des <see cref="Stagiaire"/>
        /// </summary>
        /// <returns></returns>
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public abstract class Colleague
    {
        /// <summary>
        /// Instance du <see cref="IMediator"/>
        /// </summary>
        protected IMediator mediator;
        /// <summary>
        /// Nom de l'instance du <see cref="Stagiaire"/> ou de la <seealso cref="Societe"/>
        /// </summary>
        protected string nom;

        /// <summary>
        /// Constructeur d'un <see cref="Colleague"/>
        /// </summary>
        /// <param name="_mediator">Instance du <see cref="IMediator"/></param>
        /// <param name="_nom">Nom de l'instance du <see cref="Stagiaire"/> ou de la <seealso cref="Societe"/></param>
        public Colleague(IMediator _mediator,string _nom)
        { //Passage par le constructeur parent
            mediator = _mediator;
            nom = _nom;
        }
        /// <summary>
        /// Permet de transmettre les informations d'un <see cref="Colleague"/> concret (<seealso cref="Stagiaire"/> ou <seealso cref="Societe"/>)
        /// </summary>
        /// <returns>Un <see cref="string"/></returns>
        public abstract string InfoPublish();
        /// <summary>
        /// Permet de transmettre le contenue du CV des <see cref="Stagiaire"/>
        /// </summary>
        /// <returns></returns>
        public abstract string CvPublish();
    }
}

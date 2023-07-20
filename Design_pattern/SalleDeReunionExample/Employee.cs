﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    /// <summary>
    /// Enfant de la superclasse <see cref="Collegue"/>
    /// </summary>
    public class Employee : Collegue
    {
        /// <summary>
        /// Une chaine de caractere qui permet d'identifier un <see cref="Employee"/> de facon Unique
        /// </summary>
        private string Matricule { get; }
        private string Prenom { get; }

        /// <summary>
        /// Constructeur d'un <see cref="Employee"/>
        /// </summary>
        /// <param name="_mediateur"></param>
        /// <param name="_matricule"></param>
        /// <param name="_nom"></param>
        /// <param name="_prenom"></param>
        public Employee(IMediateur _mediateur,string _matricule, string _nom, string _prenom)
            :base(_mediateur,_nom)
        {
            Matricule = _matricule;
            Prenom = _nom;
        }

        /// <summary>
        /// Permet de demander au <see cref="IMediateur"/> de réaliser la <seealso cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> en fonction de certain paramettres
        /// </summary>
        /// <param name="_periode">Periode de date souhaité</param>
        /// <param name="_equipements">Liste d'equipement exigée que la <see cref="SalleDeReunion"/> doit posseder</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        public void ReserverSalle(Periode _periode, List<EnumEquipement> _equipements, int _capacite) => Mediateur.ReserverSalle(this, _periode, _equipements, _capacite);

        /// <summary>
        /// Permet de demander aux <see cref="IMediateur"/> d'annuler une <seealso cref="Reservation"/> en se basant sur un <seealso cref="Employee"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_periode">Periode de date(<see cref="DateTime"/>) de la <seealso cref="Reservation"/> à annuler</param>
        public override void AnnulerReservation(Periode _periode) => Mediateur.AnnulerReservation(this, _periode);

        /// <summary>
        /// Permet de renvoyer les caracteristiques de la <see cref="Employee"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public override string ToStringCollegue()=> string.Format("Employée\n    Matricule : {0}\n    Nom : {1}\n    Prenom : {2}\n", Matricule, Nom, Prenom);


    }
}

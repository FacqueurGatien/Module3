using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public abstract class Collegue
    {
        protected string Nom { get; }
        protected IMediateur Mediateur { get; }
        protected List<Reservation> Reservations { get; }

        public Collegue(IMediateur _mediateur,string _nom)
        {
            Mediateur = _mediateur;
            Nom = _nom;
            Reservations = new List<Reservation>();
        }

        public void AjouterReservation(Reservation _reservation) => Reservations.Add(_reservation);
        public Reservation? RecupererReservation(Reservation _reservation) => Reservations.Find(r => r.Periode.DateDebut == _reservation.Periode.DateDebut && r.Periode.DateFin == r.Periode.DateFin && r.Employee == _reservation.Employee && r.Salle == _reservation.Salle);
        public List<Reservation> RecupererReservations() => Reservations;
        public void EnleverReservation(Reservation _reservation) => Reservations.Remove(_reservation);
        public void AnnulerReservation(Periode _periode) => Mediateur.AnnulerReservation(this, _periode);
        public string ToStringReservation()
        {
            string result = "";
            string separateur = "_________________________";
            if(Reservations.Count > 0)
            {
                foreach (Reservation reservation in Reservations)
                {
                    result += string.Format("{0}\nInformation sur la salle : \n{1}\n\nInformation sur l'employée : \n{2}\nPeriode de reservation : \n{3}\n{0}\n",
                        separateur,reservation.Salle.ToStringCollegue(),reservation.Employee.ToStringCollegue(),reservation.Periode.ToStringPeriode(),separateur);
                }
            }
            else
            {
                result += string.Format("Information concernant cette {0} : \n{1}\nAucune reservation\n{2}\n", GetType().Name, ToStringCollegue(), separateur);
 
            }
            return result;
        }

        public abstract string ToStringCollegue();

    }
}

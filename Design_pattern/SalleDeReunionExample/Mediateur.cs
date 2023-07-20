using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Mediateur : IMediateur
    {
        //Todo Ajouter une fonction pour ajouter les employee salle ou reservation  sans passer par le public
        public List<SalleDeReunion> Salles { get; }
        public List<Employee> Employees { get; }
        public List<Reservation> Reservations { get; }
        public Mediateur()
        {
            Salles = new List<SalleDeReunion>();
            Employees = new List<Employee>();
            Reservations = new List<Reservation>();
        }

        public Reservation? ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            if (Salles.Count > 0 && Employees.Count > 0)
            {
                foreach (SalleDeReunion salle in Salles)
                {
                    if (salle.VerifierEquipement(_equipements) &&
                        salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                        salle.VerifierCapacite(_capacite))
                    {
                        Reservation reservation = new Reservation(salle, _employee, _periode);
                        AjouterReservation(reservation);
                        return reservation;
                    }
                }
            }
            return null;
        }
        public void AnnulerReservation(SalleDeReunion _salle, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r=>r.Periode.DateDebut==_periode.DateDebut && r.Periode.DateFin==_periode.DateFin && r.Salle==_salle);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        public void AnnulerReservation(Employee _employee, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Periode.DateDebut == _periode.DateDebut && r.Periode.DateFin == _periode.DateFin && r.Employee==_employee);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        public EnumDisponibilite VerifierDisponibilite(SalleDeReunion _salle,Periode _periode)
        {
            foreach (Reservation reservation in Reservations)
            {
                if (reservation.Salle == _salle &&
                    !(_periode.DateDebut < reservation.Periode.DateDebut && _periode.DateFin < reservation.Periode.DateDebut) &&
                    !(_periode.DateDebut > reservation.Periode.DateFin && _periode.DateFin > reservation.Periode.DateFin))
                {
                    return EnumDisponibilite.Occupe;
                }
            }
            return EnumDisponibilite.Disponible;
        }


        public void AjouterReservation(Reservation _reservation) => Reservations.Add(_reservation);
        private void EnleverReservation(Reservation _reservation) => Reservations.Remove(_reservation);

        public string ToStringSalles()
        {
            string result = "Liste des salles\n-------------------\n";
            foreach (SalleDeReunion salle in Salles)
            {
                result += string.Format("{0}\n", salle.ToStringCollegue());
            }
            return result;
        }
        public string ToStringEmployees()
        {
            string result = "Liste des employees\n-------------------\n";
            foreach (Employee employee in Employees)
            {
                result += string.Format("{0}\n", employee.ToStringCollegue());
            }
            return result;
        }
        public string ToStringReservation()
        {
            string result = "";
            string separateur = "_________________________";
            if (Reservations.Count > 0)
            {
                foreach (Reservation reservation in Reservations)
                {
                    result += string.Format("{0}\nInformation sur la salle : \n{1}\n\nInformation sur l'employée : \n{2}\nPeriode de reservation : \n{3}\n{0}\n",
                        separateur, reservation.Salle.ToStringCollegue(), reservation.Employee.ToStringCollegue(), reservation.Periode.ToStringPeriode(), separateur);
                }
            }
            else
            {
                result += "Aucune Reservation enregistré";
            }
            return result;
        }

    }
}

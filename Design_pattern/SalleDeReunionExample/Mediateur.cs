using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Mediateur : IMediateur
    {
        public List<SalleDeReunion> Salles { get; }
        public List<Employee> Employees { get; }

        public Mediateur()
        {
            Salles = new List<SalleDeReunion>();
            Employees = new List<Employee>();
        }

        public Reservation? ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            if (Salles.Count > 0 && Employees.Count > 0)
            {
                foreach (SalleDeReunion salle in Salles)
                {
                    bool equipementDispo = salle.VerifierEquipement(_equipements);
                    bool periodeLibre = salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible;

                    if (salle.VerifierEquipement(_equipements) &&
                        salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                        salle.VerifierCapacite(_capacite))
                    {
                        Reservation reservation = new Reservation(salle, _employee, _periode);
                        salle.AjouterReservation(reservation);
                        _employee.AjouterReservation(reservation);
                        return reservation;
                    }
                }
            }
            return null;
        }
        public void AnnulerReservation(Collegue _collegue, Periode _periode)
        {
            Reservation? reservation = _collegue.RecupererReservations().Find(r=>r.Periode.DateDebut==_periode.DateDebut && r.Periode.DateFin==_periode.DateFin);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
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

        private static void EnleverReservation(Reservation _reservation)
        {
            _reservation.Salle.EnleverReservation(_reservation);
            _reservation.Employee.EnleverReservation(_reservation);
        }

    }
}

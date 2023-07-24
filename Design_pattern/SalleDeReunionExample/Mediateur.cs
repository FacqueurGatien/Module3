using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Mediateur : IMediateur
    {
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="SalleDeReunion"/>
        /// </summary>
        public List<SalleDeReunion> Salles { get; }
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="Employee"/>
        /// </summary>
        public List<Employee> Employees { get; }
        /// <summary>
        /// <see cref="List{T}"/> contenant l'ensemble des <seealso cref="Reservation"/>
        /// </summary>
        public List<Reservation> Reservations { get; }

        /// <summary>
        /// Constructeur du <see cref="Mediateur"/>
        /// </summary>
        public Mediateur()
        {
            Salles = new List<SalleDeReunion>();
            Employees = new List<Employee>();
            Reservations = new List<Reservation>();
        }
        /// <summary>
        /// Permet d'effectuer la <see cref="Reservation"/> d'une <seealso cref="SalleDeReunion"/> sous certaines condition
        /// </summary>
        /// <param name="_employee"><see cref="Employee"/> qui effectue la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> de date(<see cref="DateTime"/>) de la <seealso cref="Reservation"/></param>
        /// <param name="_equipements">Liste d'equipement que la <see cref="SalleDeReunion"/> doit disposer</param>
        /// <param name="_capacite">Capacité d'acceuille necessaire de la <see cref="SalleDeReunion"/></param>
        /// <returns></returns>
        public bool ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
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
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ReserverSalle(Employee _employee, string _salle, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            SalleDeReunion salle = Salles.Find(s=>s.Reference()==_salle);
            if (Salles.Count > 0 && Employees.Count > 0 && salle!=null)
            {
                if (salle.VerifierEquipement(_equipements) &&
                    salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                    salle.VerifierCapacite(_capacite))
                {
                    Reservation reservation = new Reservation(salle, _employee, _periode);
                    AjouterReservation(reservation);
                    return true;
                }
            }
            return false;
        }
        public List<SalleDeReunion> ReserverSalles(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            List<SalleDeReunion> salles = new List<SalleDeReunion>();
            if (Salles.Count > 0 && Employees.Count > 0)
            {
                foreach (SalleDeReunion salle in Salles)
                {
                    if (salle.VerifierEquipement(_equipements) &&
                        salle.VerifierDisponibilité(_periode) == EnumDisponibilite.Disponible &&
                        salle.VerifierCapacite(_capacite))
                    {
                        salles.Add(salle);
                    }
                }
            }
            return salles;
        }
        /// <summary>
        /// Permet l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> en se basant sur une <seealso cref="SalleDeReunion"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_salle"><see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> concerner par la <seealso cref="Reservation"/></param>
        public void AnnulerReservation(SalleDeReunion _salle, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Periode.DateDebut == _periode.DateDebut && r.Periode.DateFin == _periode.DateFin && r.Salle == _salle);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        /// <summary>
        /// Permet l'annulation d'une <see cref="Reservation"/> de <seealso cref="SalleDeReunion"/> en se basant sur un <seealso cref="Employee"/> et une <seealso cref="Periode"/>
        /// </summary>
        /// <param name="_salle"><see cref="SalleDeReunion"/> concerner par la <seealso cref="Reservation"/></param>
        /// <param name="_periode"><see cref="Periode"/> concerner par la <seealso cref="Reservation"/></param>
        public void AnnulerReservation(Employee _employee, Periode _periode)
        {
            Reservation? reservation = Reservations.Find(r => r.Periode.DateDebut == _periode.DateDebut && r.Periode.DateFin == _periode.DateFin && r.Employee == _employee);
            if (reservation != null)
            {
                EnleverReservation(reservation);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_salle"></param>
        /// <param name="_periode"></param>
        /// <returns></returns>
        public EnumDisponibilite VerifierDisponibilite(SalleDeReunion _salle, Periode _periode)
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

        /// <summary>
        /// Permet d'ajouter une <see cref="Reservation"/> a la liste <seealso cref="Reservations"/>
        /// </summary>
        /// <param name="_reservation"></param>
        public void AjouterReservation(Reservation _reservation) => Reservations.Add(_reservation);
        /// <summary>
        /// Permet d'ôter une <see cref="Reservation"/> de la liste <seealso cref="Reservations"/>
        /// </summary>
        /// <param name="_reservation"></param>
        private void EnleverReservation(Reservation _reservation) => Reservations.Remove(_reservation);

        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de toute les <see cref="SalleDeReunion"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringSalles()
        {
            string result = "Liste des salles\n-------------------\n";
            foreach (SalleDeReunion salle in Salles)
            {
                result += string.Format("{0}\n", salle.ToStringCollegue());
            }
            return result;
        }
        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de tout les <see cref="Employee"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
        public string ToStringEmployees()
        {
            string result = "Liste des employees\n-------------------\n";
            foreach (Employee employee in Employees)
            {
                result += string.Format("{0}\n", employee.ToStringCollegue());
            }
            return result;
        }
        /// <summary>
        /// Permet de renvoyer textuellement les caracteristiques de toute les <see cref="Reservation"/>
        /// </summary>
        /// <returns>Un <see cref="string"/> formaté</returns>
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

        public Employee? RecupererEmployer(string _matricule)
        {
            return Employees.Find(e => e.Matricule == _matricule);
        }

        public List<Periode> RecupererPeriodesEmployee(string _employee)
        {
            Employee? emp = Employees.Find(e=>e.Reference()==_employee);
            List<Periode> periodes = new List<Periode>();
            if (emp != null)
            {
                List<Reservation> reservations = Reservations.FindAll(r=>r.Employee.Matricule==emp.Matricule);
                reservations.ForEach(rp => periodes.Add(rp.Periode));
                return periodes;
            }
            return periodes;
        }
        public List<Periode> RecupererPeriodesSalle(string _salle)
        {
            SalleDeReunion? sal = Salles.Find(e => e.Reference() == _salle);
            List<Periode> periodes = new List<Periode>();
            if (sal != null)
            {
                List<Reservation> reservations = Reservations.FindAll(r => r.Salle.Reference() == sal.Reference());
                reservations.ForEach(rp => periodes.Add(rp.Periode));
                return periodes;
            }
            return periodes;
        }
        public List<SalleDeReunion>? RecupererSalle(string _employee,string _periode)
        {
            List<Reservation>? reservation = Reservations.FindAll(r=>r.Employee.Reference()==_employee && r.Periode.Reference()==_periode);
            List<SalleDeReunion> salles = new List<SalleDeReunion>();
            if (reservation .Count>0)
            {
                reservation.ForEach(r=>salles.Add(r.Salle));
            }
            return salles;
        }
        public List<Employee>? RecupererEmployee(string _salle, string _periode)
        {
            List<Reservation>? reservation = Reservations.FindAll(r => r.Salle.Reference() == _salle && r.Periode.Reference() == _periode);
            List<Employee> employees = new List<Employee>();
            if (reservation.Count > 0)
            {
                reservation.ForEach(r => employees.Add(r.Employee));
            }
            return employees;
        }
    }
}

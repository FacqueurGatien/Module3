using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    public enum EnumSalleDeReunion
    {
        Disponible,
        Occupee
    }
    public enum EnumEquipement
    {
        VideoProjecteur,
        Ordinateur,
        Climatisation,
        Insonorisation
    }
    public enum EnumType
    {
        Salle,
        Employe
    }
    public interface IMediateur
    {
        public Reservation? EmployeeFaitReservation(string employee, int invite, List<EnumEquipement> equipements, Periode periode);
        public void AnnulationReservation(Reservation reservation);
        public string EnvoyerMessage(Collegue collegue);

    }
    public abstract class Collegue
    {
        protected IMediateur mediateur;
        public EnumType type { get; }
        public Collegue(IMediateur _mediateur, EnumType _type)
        {
            mediateur = _mediateur;
            type = _type;
        }
        public void Annulation(Reservation? _reservation)
        {
            if (_reservation!=null)
            {
                mediateur.AnnulationReservation(_reservation);
            }
        }
        public void EnvoyerMessage()
        {
            Console.WriteLine(mediateur.EnvoyerMessage(this));
        }
    }
    public class Periode
    {
        public DateTime DateDebut { get; }
        public DateTime DateFin { get; }
        public Periode(DateTime _debut, DateTime _fin)
        {
            DateDebut = _debut;
            DateFin = _fin;
        }
    }
    public class Reservation
    {
        public Periode Periode { get; }
        public string Salle { get; }
        public string Employee{ get; }
        public Reservation(Periode _periode,string _salle, string _employee)
        {
            Periode = _periode;
            Salle = _salle;
            Employee = _employee;
        }
    }
    public class Mediateur : IMediateur
    {
        public List<Employee>? employees { get; set; }
        public List<SalleDeReunion>? salles { get; set; }
        public Mediateur(List<Employee> _emps = null, List<SalleDeReunion>? _sals = null)
        {
            if (_emps != null)
            {
                employees = _emps;
            }
            else
            {
                employees = new List<Employee>();
            }
            if (_sals != null)
            {
                salles = _sals;
            }
            else
            {
                salles = new List<SalleDeReunion>();
            }

        }
        public Reservation? EmployeeFaitReservation(string _employee, int _invite, List<EnumEquipement> _equipements, Periode _periode)
        {
            if (salles != null && salles.Count > 0 && employees != null)
            {
                EnumSalleDeReunion enumDispo = new EnumSalleDeReunion();
                foreach (SalleDeReunion salle in salles)
                {
                    bool equipementDispo = true;
                    bool periodeLibre = false;
                    foreach (EnumEquipement equipement in _equipements)
                    {
                        if (!salle.Equipements.Contains(equipement))
                        {
                            equipementDispo = false;
                        }
                    }
                    if (salle.Disponibilite.Count > 0)
                    {
                        if (salle.VerifierDisponibilite(_periode)==EnumSalleDeReunion.Disponible)
                        {
                            periodeLibre = true;
                        }
                    }
                    else
                    {
                        periodeLibre = true;
                    }
                    if (equipementDispo && periodeLibre && salle.capacite >= _invite)
                    {
                        Periode p = new Periode(_periode.DateDebut, _periode.DateFin);
                        Reservation r = new Reservation(p, salle.Nom, _employee);
                        salle.Disponibilite.Add(r,EnumSalleDeReunion.Occupee);
                        return r;
                    }
                }
            }
            return null;
        }
        public string EnvoyerMessage(Collegue collegue)
        {
            if (employees == null || salles == null)
            {
                return "Il n'y a aucune salle ou aucun employée répértorié";
            }
            Employee emp;
            SalleDeReunion sal;
            string message = "";
            if (collegue.type == EnumType.Employe)
            {
                emp = (Employee)collegue;
                if (emp.Reservations != null && emp.Reservations.Count > 0)
                {
                    message += $"L'employé {emp.Nom} a reservé";
                    if (emp.Reservations.Count > 1)
                    {
                        message += " les salles: ";
                        emp.Reservations.ForEach(sal => { message += sal + ","; });
                        message.Trim(',');
                    }
                    else
                    {
                        message += $" la salle: {emp.Reservations[0]}";
                    }
                }
                else
                {
                    message += $"L'employé {emp.Nom} n'a aucune salle de reservé";
                }
            }
            else
            {
                sal = (SalleDeReunion)collegue;
                if (sal.Disponibilite != null)
                {
                    message += $"La salle {sal.Nom} a été reservé";
                    if (sal.Disponibilite.Count > 1)
                    {
                        message += " les employées: ";
                        foreach (KeyValuePair<Reservation,EnumSalleDeReunion> s in sal.Disponibilite)
                        {
                            message += s.Key.Employee + ",";
                        }
                        message.Trim(',');
                    }
                    else
                    {
                        message += $" par l'employée: {sal.Disponibilite.First()}";
                    }
                }
                else
                {
                    message += $"La salle {sal.Nom} n'a aucune reservant";
                }
            }
            return message;
        }
        public void AnnulationReservation(Reservation _reservation)
        {
            SalleDeReunion s = salles.Find(s => s.Nom == _reservation.Salle);
            Employee e = employees.Find(e => e.Matricule == _reservation.Employee);
            s.Disponibilite.Remove(_reservation);
            e.Reservations.Remove(_reservation);
        }
    }
    public class SalleDeReunion : Collegue
    {
        public string Nom { get; }
        public int capacite { get; }
        public List<EnumEquipement> Equipements { get; }
        public Dictionary<Reservation, EnumSalleDeReunion> Disponibilite { get; set; }

        public SalleDeReunion(IMediateur _mediateur, string _nom, int _capacite, List<EnumEquipement> _equipements)
            : base(_mediateur, EnumType.Salle)
        {
            Nom = _nom;
            capacite = _capacite;
            Equipements = _equipements;
            Disponibilite = new Dictionary<Reservation, EnumSalleDeReunion>();
        }
        public EnumSalleDeReunion VerifierDisponibilite(Periode _periode)
        {
            foreach (KeyValuePair<Reservation, EnumSalleDeReunion> periode in Disponibilite)
            {
                if (!(_periode.DateDebut < periode.Key.Periode.DateDebut && _periode.DateFin < periode.Key.Periode.DateDebut) &&
                    !(_periode.DateDebut > periode.Key.Periode.DateFin && _periode.DateFin > periode.Key.Periode.DateFin))
                {
                    return EnumSalleDeReunion.Occupee;
                }
            }
            return EnumSalleDeReunion.Disponible;
        }
    }
    public class Employee : Collegue
    {
        public string Matricule { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public List<Reservation> Reservations { get; }
        public Employee(IMediateur _mediateur, string _matricule, string _nom, string _prenom)
            : base(_mediateur, EnumType.Employe)
        {
            Matricule = _matricule;
            Nom = _nom;
            Prenom = _prenom;
            Reservations = new List<Reservation>();
        }
        public Reservation Reservation(int _invite, List<EnumEquipement> _equipements, Periode _periode )
        {
            Reservation? r = mediateur.EmployeeFaitReservation(Matricule, _invite, _equipements, _periode);
            if(r!=null)
            {
                Reservations.Add(r);
                return r;
            }
            return null;
        }
        public Reservation? RecupererReservation(Periode _periode)
        {
            Reservation r = Reservations.Find(r=>r.Periode.DateDebut==_periode.DateDebut && r.Periode.DateFin==_periode.DateFin);
            if(r!=null)
            {
                return r;
            }
            return null;
        }
    }
    public class Programe
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("hello world");
            IMediateur mediateur = new Mediateur();

            SalleDeReunion s1 = new SalleDeReunion(mediateur, "Atic", 50, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.Insonorisation });
            SalleDeReunion s2 = new SalleDeReunion(mediateur, "Polar", 10, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.VideoProjecteur, EnumEquipement.Ordinateur });
            SalleDeReunion s3 = new SalleDeReunion(mediateur, "Saturn", 100, new List<EnumEquipement>() { EnumEquipement.Climatisation });
            SalleDeReunion s4 = new SalleDeReunion(mediateur, "Gonzales", 25, new List<EnumEquipement>() { EnumEquipement.Insonorisation, EnumEquipement.Ordinateur, EnumEquipement.VideoProjecteur });

            Employee e1 = new Employee(mediateur, "ESTJ001", "AAA", "AAAAAAA");
            Employee e2 = new Employee(mediateur, "ESTJ002", "BBB", "BBBBBBB");
            Employee e3 = new Employee(mediateur, "ESTJ003", "CCC", "CCCCCCC");
            Employee e4 = new Employee(mediateur, "ESTJ004", "DDD", "DDDDDDD");
            Employee e5 = new Employee(mediateur, "ESTJ005", "EEE", "EEEEEEE");
            Employee e6 = new Employee(mediateur, "ESTJ006", "FFF", "FFFFFFF");

            ((Mediateur)mediateur).salles.AddRange(new List<SalleDeReunion>() { s1, s2, s3, s4 });
            ((Mediateur)mediateur).employees.AddRange(new List<Employee>() { e1, e2, e3, e4, e5, e6 });

            Reservation e1r1 = e1.Reservation(20, new List<EnumEquipement> { EnumEquipement.Climatisation }, new Periode(new DateTime(2023, 12, 31, 10, 0, 0), new DateTime(2023, 12, 31, 22, 0, 0)));
            Reservation e1r2 = e1.Reservation(20, new List<EnumEquipement> { EnumEquipement.Climatisation }, new Periode(new DateTime(2024, 1, 1, 8, 30, 0), new DateTime(2024, 1, 1, 12, 0, 0)));
            Reservation e2r1 = e2.Reservation(10, new List<EnumEquipement> { EnumEquipement.Ordinateur }, new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));
            Reservation e3r1 = e3.Reservation(10, new List<EnumEquipement> { EnumEquipement.Ordinateur }, new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));
            Reservation e4r1 = e4.Reservation(10, new List<EnumEquipement> { EnumEquipement.Ordinateur }, new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));

            e1.EnvoyerMessage();
            e2.EnvoyerMessage();
            e3.EnvoyerMessage();
            e4.EnvoyerMessage();


            Console.WriteLine(s1.VerifierDisponibilite(new Periode(new DateTime(2023, 12, 31, 10, 0, 0), new DateTime(2023, 12, 31, 22, 0, 0))));
            Console.WriteLine(s1.VerifierDisponibilite(new Periode(new DateTime(2021, 12, 31, 10, 0, 0), new DateTime(2021, 12, 31, 22, 0, 0))));

            e1.Annulation(e1r1);
            e1.Annulation(e1r2);
            e1.Annulation(e2r1);
            e1.Annulation(e3r1);
            e1.Annulation(e4r1);

            e1.EnvoyerMessage();
            e2.EnvoyerMessage();
            e3.EnvoyerMessage();
            e4.EnvoyerMessage();
        }
    }
}
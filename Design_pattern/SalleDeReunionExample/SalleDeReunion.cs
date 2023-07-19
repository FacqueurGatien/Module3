using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class SalleDeReunion : Collegue
    {
        private int Capacite { get; }
        private List<EnumEquipement> Equipements { get; }

        public SalleDeReunion(IMediateur _mediateur, string _nom, int _capacite, List<EnumEquipement> equipements)
            : base(_mediateur, _nom)
        {
            Capacite = _capacite;
            Equipements = equipements;
        }

        public EnumDisponibilite VerifierDisponibilité(Periode _periode)
        {
            foreach (Reservation reservation in Reservations)
            {
                if (!(_periode.DateDebut < reservation.Periode.DateDebut && _periode.DateFin < reservation.Periode.DateDebut) &&
                    !(_periode.DateDebut > reservation.Periode.DateFin && _periode.DateFin > reservation.Periode.DateFin))
                {
                    return EnumDisponibilite.Occupe;
                }
            }
            return EnumDisponibilite.Disponible;
        }
        public bool VerifierEquipement(List<EnumEquipement> _equipements)
        {
            foreach (EnumEquipement equipement in _equipements)
            {
                if (!Equipements.Contains(equipement))
                {
                    return false;
                }
            }
            return true;
        }
        public bool VerifierCapacite(int _capacite)=> Capacite >= _capacite;
        public string ToStringEquipement()
        {
            string result = "";
            foreach (EnumEquipement equipement in Equipements)
            {
                result += $"        {equipement.ToString()}\n";
            }
            result.Trim(',');
            return result;
        }

        public override string ToStringCollegue() => string.Format("Salle de reunion\n    Nom : {0}\n    Capacite : {1} personnes\n    Liste d'équipements : \n{2}\n", Nom, Capacite, ToStringEquipement());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public interface IMediateur
    {
        public Reservation? ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite);
        public void AnnulerReservation(SalleDeReunion _salle,Periode _periode);
        public void AnnulerReservation(Employee _employee, Periode _periode);
        public EnumDisponibilite VerifierDisponibilite(SalleDeReunion _salle, Periode _periode);
    }
}

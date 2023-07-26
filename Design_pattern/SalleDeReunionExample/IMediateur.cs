﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public interface IMediateur
    {
        //Fonction minimum requise pour l'interface
        public bool ReserverSalle(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite);
        public bool ReserverSalle(Employee _employee, string _salle, Periode _periode, List<EnumEquipement> _equipements, int _capacite);
        public void AnnulerReservation(SalleDeReunion _salle,Periode _periode);
        public void AnnulerReservation(Employee _employee, Periode _periode);
        public void AnnulerReservation(Reservation _reservation);
        public EnumDisponibilite VerifierDisponibilite(SalleDeReunion _salle, Periode _periode);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Reservation
    {
        public SalleDeReunion Salle { get; }
        public Employee Employee { get; }
        public Periode Periode { get; }

        public Reservation(SalleDeReunion _salle,Employee _employee, Periode _periode)
        {
            Salle = _salle;
            Employee = _employee;
            Periode = _periode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Periode
    {
        public DateTime DateDebut { get; }
        public DateTime DateFin { get; }
        public Periode(DateTime _dateDebut,DateTime _dateFin)
        {
            DateDebut = _dateDebut;
            DateFin = _dateFin;
        }
        public string ToStringPeriode()=> string.Format("{0}\n{1}\n", DateDebut.ToString(), DateFin.ToString());

    }
}

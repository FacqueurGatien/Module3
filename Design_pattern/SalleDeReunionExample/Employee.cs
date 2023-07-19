using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleDeReunionExample
{
    public class Employee : Collegue
    {
        private string Matricule { get; }
        private string Prenom { get; }

        public Employee(IMediateur _mediateur,string _matricule, string _nom, string _prenom)
            :base(_mediateur,_nom)
        {
            Matricule = _matricule;
            Prenom = _nom;
        }

        public void ReserverSalle(Periode _periode, List<EnumEquipement> _equipements, int _capacite) => Mediateur.ReserverSalle(this, _periode, _equipements, _capacite);

        public override string ToStringCollegue()=> string.Format("Employée\n    Matricule : {0}\n    Nom : {1}\n    Prenom : {2}\n", Matricule, Nom, Prenom);
    }
}

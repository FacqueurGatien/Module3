using SalleDeReunionExample;

namespace ReservationSalleWinform
{
    public partial class ReservationSalleForm : Form
    {
        private IMediateur mediateur;
        private List<CheckBox> checkBoxEquip;
        private List<EnumEquipement> equipementSelectionne;
        private Employee? employeSelectionne;
        public ReservationSalleForm()
        {
            InitializeComponent();
            Chargement();
            UpdateIHM();

        }
        private void Chargement()
        {
            mediateur = new Mediateur();
            equipementSelectionne = new List<EnumEquipement>();
            CBXequipement1.Tag = EnumEquipement.Ordinateur;
            CBXequipement2.Tag = EnumEquipement.VideoProjecteur;
            CBXequipement3.Tag = EnumEquipement.Climatisation;
            CBXequipement4.Tag = EnumEquipement.Insonorisation;
            checkBoxEquip = new List<CheckBox>() { CBXequipement1, CBXequipement2, CBXequipement3, CBXequipement4 };

            SalleDeReunion s1 = new SalleDeReunion(mediateur, "Grenier", 50, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.Insonorisation });
            SalleDeReunion s2 = new SalleDeReunion(mediateur, "Chalet", 10, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.VideoProjecteur, EnumEquipement.Ordinateur });
            SalleDeReunion s3 = new SalleDeReunion(mediateur, "Arel3", 100, new List<EnumEquipement>() { EnumEquipement.Climatisation });
            SalleDeReunion s4 = new SalleDeReunion(mediateur, "Geek", 25, new List<EnumEquipement>() { EnumEquipement.Insonorisation, EnumEquipement.Ordinateur, EnumEquipement.VideoProjecteur });

            Employee e1 = new Employee(mediateur, "ESTJ001", "Antoine", "Daniel");
            Employee e2 = new Employee(mediateur, "ESTJ002", "Frederic", "Molas");
            Employee e3 = new Employee(mediateur, "ESTJ003", "Sebastien", "Rassiat");
            Employee e4 = new Employee(mediateur, "ESTJ004", "Mathieu", "Sommet");
            Employee e5 = new Employee(mediateur, "ESTJ005", "Lucas", "Hauchard");
            Employee e6 = new Employee(mediateur, "ESTJ006", "Bruce", "Benamran");

            ((Mediateur)mediateur).Salles.AddRange(new List<SalleDeReunion>() { s1, s2, s3, s4 });
            ((Mediateur)mediateur).Employees.AddRange(new List<Employee>() { e1, e2, e3, e4, e5, e6 });

            //Remplissage des ComboBox
            CBemployeeR.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBEmployeesListe.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBsalleListe.Items.AddRange(new string[] { s1.Reference(), s2.Reference(), s3.Reference(), s4.Reference() });
        }

        private void CBemployeeR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string matricule = cb.SelectedItem.ToString().Split(':')[0].Trim(' ');
            employeSelectionne = ((Mediateur)mediateur).RecupererEmployer(matricule);
            int capacité = (int)NUDcapacite.Value;
            DateTime dateDebut = new DateTime(DTperiodeDebut.Value.Year, DTperiodeDebut.Value.Month, DTperiodeDebut.Value.Day, (int)NUDheureDebut.Value, (int)NUDminuteDebut.Value, 0);
            DateTime dateFin = new DateTime(DTperiodeFin.Value.Year, DTperiodeFin.Value.Month, DTperiodeFin.Value.Day, (int)NUDheureFin.Value, (int)NUDminuteFin.Value, 0);

            if (employeSelectionne != null)
            {

            }
            UpdateIHM();
        }

        private void Bvalider_Click(object sender, EventArgs e)
        {

        }
        private void UpdateIHM()
        {
            if (employeSelectionne!=null && VerifierDate() && CBsalleDispo.SelectedItem == null)
            {
                Bvalider.Enabled = true;
                Periode periode = new Periode(new DateTime(DTperiodeDebut.Value.Year, DTperiodeDebut.Value.Month, DTperiodeDebut.Value.Day, (int)NUDheureDebut.Value, (int)NUDminuteDebut.Value, 0),
                    new DateTime(DTperiodeFin.Value.Year, DTperiodeFin.Value.Month, DTperiodeFin.Value.Day, (int)NUDheureFin.Value, (int)NUDminuteFin.Value, 0));
                RemplirListeSalleDispo(employeSelectionne, periode,equipementSelectionne,(int)NUDcapacite.Value);
            }
            else
            {
                Bvalider.Enabled = false;
            }
        }
        private void RemplirListeSalleDispo(Employee _employee,Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            List<SalleDeReunion> salleList = ((Mediateur)mediateur).ReserverSalles(_employee, _periode, _equipements, _capacite);

            salleList.ForEach(s=>CBsalleDispo.Items.Add(s.Reference()));
        }
        private bool VerifierDate()
        {
            if (DTperiodeDebut.Value != null && DTperiodeFin.Value != null)
            {
                if (DTperiodeDebut.Value < DTperiodeFin.Value)
                {
                    return true;
                }
                else if (DTperiodeDebut.Value.Year == DTperiodeFin.Value.Year &&
                    DTperiodeDebut.Value.Month == DTperiodeFin.Value.Month &&
                    DTperiodeDebut.Value.Day == DTperiodeFin.Value.Day)
                {
                    if (NUDheureDebut.Value < NUDheureFin.Value)
                    {
                        return true;
                    }
                    else if (NUDheureDebut.Value == NUDheureFin.Value)
                    {
                        if (NUDminuteDebut.Value < NUDminuteFin.Value)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private void CBsalleDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void DTperiodeDebut_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void DTperiodeFin_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void NUDheureDebut_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void NUDheureFin_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void NUDminuteDebut_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void NUDminuteFin_ValueChanged(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        private void CBXequipement1_CheckedChanged(object sender, EventArgs e)
        {
            equipementSelectionne.Clear();
            checkBoxEquip.ForEach(e =>
            {
                if (e.Checked == true)
                {
                    equipementSelectionne.Add((EnumEquipement)e.Tag);
                }
            });
        }
    }
}
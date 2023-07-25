using SalleDeReunionExample;

namespace ReservationSalleWinform
{
    /// <summary>
    /// Formulaire de réservation de salle.
    /// </summary>
    public partial class ReservationSalleForm : Form
    {
        private IMediateur mediateur;

        private List<CheckBox> checkBoxEquip;

        private Employee? employeSelectionne;
        private Periode periodeSelectionne;
        private List<EnumEquipement> equipementSelectionne;
        private string salleSelectionne;

        /// <summary>
        /// Constructeur par défaut du formulaire.
        /// </summary>
        public ReservationSalleForm()
        {
            InitializeComponent();
            Chargement();
            UpdateIHM();
        }

        /// <summary>
        /// Création des Salle et Employée et initialisation des element de l'IHM
        /// </summary>
        private void Chargement()
        {
            mediateur = new Mediateur();

            DTperiodeDebut.Value = DateTime.Now;
            DTperiodeFin.Value = DateTime.Now;
            NUDheureDebut.Value = 13;
            NUDheureDebut.Value = 13;

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

            CBemployeeR.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBEmployeesListe.Items.AddRange(new string[] { e1.Reference(), e2.Reference(), e3.Reference(), e4.Reference(), e5.Reference(), e6.Reference() });
            CBsalleListe.Items.AddRange(new string[] { s1.Reference(), s2.Reference(), s3.Reference(), s4.Reference() });
        }

        /// <summary>
        /// Gère la sélection d'un employé pour la réservation.
        /// </summary>
        private void SelectionneEmployeePourReservation(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            string matricule = cb.SelectedItem.ToString().Split(':')[0].Trim(' ');
            employeSelectionne = ((Mediateur)mediateur).RecupererEmployer(matricule);

            UpdateIHM();
        }

        /// <summary>
        /// Effectue la réservation de salle lorsque le bouton "Valider" est cliqué.
        /// </summary>
        private void Bvalider_Click(object sender, EventArgs e)
        {
            try
            {
                employeSelectionne.ReserverSalle(periodeSelectionne, CBsalleDispo.SelectedItem.ToString(), equipementSelectionne, (int)NUDcapacite.Value);
                CBsalleDispo.Items.Clear();
                Bvalider.Enabled = false;
                UpdateIHM();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Mise a jours de l'IHM
        /// </summary>
        private void UpdateIHM()
        {
            try
            {
                UpdatePeriode();
            }
            catch (ArgumentException)
            {
                DateTime now = DateTime.Now;
                DTperiodeDebut.ValueChanged -= ValueChange;
                DTperiodeFin.ValueChanged -= ValueChange;
                DTperiodeDebut.Value = now.AddDays(1);
                DTperiodeFin.Value = now.AddDays(1);
                DTperiodeDebut.ValueChanged += ValueChange;
                DTperiodeFin.ValueChanged += ValueChange;
                NUDheureDebut.Value = 6;
                NUDheureFin.Value = 6;
                NUDminuteDebut.Value = 0;
                NUDminuteFin.Value = 15;
            }
            if (employeSelectionne != null && CBsalleDispo.SelectedItem == null)
            {
                RemplirListeSalleDispo(employeSelectionne, periodeSelectionne, equipementSelectionne, (int)NUDcapacite.Value);
            }
        }
        /// <summary>
        /// Apelle la methode UpdateIHM quand certaint element de l'IHM change de valeur
        /// </summary>
        private void ValueChange(object sender, EventArgs e)
        {
            UpdateIHM();
        }

        /// <summary>
        /// Remplit la liste des salles disponibles pour la réservation.
        /// </summary>
        private void RemplirListeSalleDispo(Employee _employee, Periode _periode, List<EnumEquipement> _equipements, int _capacite)
        {
            List<SalleDeReunion> salleList = ((Mediateur)mediateur).RecupererSallesDispo(_employee, _periode, _equipements, _capacite);
            CBsalleDispo.Items.Clear();
            salleList.ForEach(s => CBsalleDispo.Items.Add(s.Reference()));
        }

        /// <summary>
        /// Gère la sélection d'une salle disponible dans la ComboBox.
        /// </summary>
        private void CBsalleDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                Bvalider.Enabled = true;
            }
            else
            {
                Bvalider.Enabled = false;
            }
        }

        /// <summary>
        /// Met à jour la période de réservation en fonction des valeurs sélectionnées.
        /// </summary>
        private void UpdatePeriode()
        {
            periodeSelectionne = new Periode(
                new DateTime(//date de Debut
                    DTperiodeDebut.Value.Year,
                    DTperiodeDebut.Value.Month,
                    DTperiodeDebut.Value.Day,
                    (int)NUDheureDebut.Value,
                    (int)NUDminuteDebut.Value,
                    0),
                new DateTime(//Date de Fin
                    DTperiodeFin.Value.Year,
                    DTperiodeFin.Value.Month,
                    DTperiodeFin.Value.Day,
                    (int)NUDheureFin.Value,
                    (int)NUDminuteFin.Value,
                    0));
        }
        /// <summary>
        /// Met a jour la liste d'equipement selectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            UpdateIHM();
        }

        private void CBEmployeesListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodeEmployee.Items.Clear();
            CBEmployeeSalle.Items.Clear();
            List<Periode> periodes = ((Mediateur)mediateur).RecupererPeriodesEmployee(((ComboBox)sender).SelectedItem.ToString());
            if (periodes.Count > 0)
            {
                periodes.ForEach(p =>
                {
                    if (!PeriodeEmployee.Items.Contains(p.Reference()))
                    {
                        PeriodeEmployee.Items.Add(p.Reference());
                    }
                });
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBEmployeeSalle.Items.Clear();
            List<SalleDeReunion> salles = ((Mediateur)mediateur).RecupererSalle(CBEmployeesListe.SelectedItem.ToString(), PeriodeEmployee.SelectedItem.ToString());
            if (salles.Count > 0)
            {
                CBEmployeeSalle.Items.Clear();
                salles.ForEach(s => CBEmployeeSalle.Items.Add(s.Reference()));
            }
        }

        private void CBsalleListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodeSalle.Items.Clear();
            CBSalleEmployee.Items.Clear();
            List<Periode> periodes = ((Mediateur)mediateur).RecupererPeriodesSalle(((ComboBox)sender).SelectedItem.ToString());
            if (periodes.Count > 0)
            {
                periodes.ForEach(p =>
                {
                    if (!PeriodeSalle.Items.Contains(p.Reference()))
                    {
                        PeriodeSalle.Items.Add(p.Reference());
                    }
                });
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            CBSalleEmployee.Items.Clear();
            List<Employee> emp = ((Mediateur)mediateur).RecupererEmployee(CBsalleListe.SelectedItem.ToString(), PeriodeSalle.SelectedItem.ToString());
            if (emp.Count > 0)
            {
                CBSalleEmployee.Items.Clear();
                emp.ForEach(s => CBSalleEmployee.Items.Add(s.Reference()));
            }
        }
        /*        /// <summary>
/// Verifie si les dates sont valides dans l'IHM 
/// </summary>
private bool VerifierDate()
{
if (DTperiodeDebut.Value != null && DTperiodeFin.Value != null && DTperiodeDebut.Value<=DateTime.Now)
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
}*/
    }
}

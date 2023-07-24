using SalleDeReunionExample;

namespace ReservationSalleWinform
{
    partial class ReservationSalleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelemployeeReservation = new Label();
            CBemployeeR = new ComboBox();
            capaciteLabel = new Label();
            NUDcapacite = new NumericUpDown();
            CBXequipement1 = new CheckBox();
            CBXequipement2 = new CheckBox();
            CBXequipement3 = new CheckBox();
            CBXequipement4 = new CheckBox();
            labelDate = new Label();
            labelHeure = new Label();
            labelMinute = new Label();
            labelDebut = new Label();
            DTperiodeDebut = new DateTimePicker();
            NUDheureDebut = new NumericUpDown();
            NUDminuteDebut = new NumericUpDown();
            labelFin = new Label();
            DTperiodeFin = new DateTimePicker();
            NUDheureFin = new NumericUpDown();
            NUDminuteFin = new NumericUpDown();
            labelSalleDispo = new Label();
            CBsalleDispo = new ComboBox();
            Bvalider = new Button();
            labelEployeesListe = new Label();
            CBEmployeesListe = new ComboBox();
            labelPeriodeEmployee = new Label();
            comboBox1 = new ComboBox();
            labelSalleReserve = new Label();
            textBox1 = new TextBox();
            labelSalles = new Label();
            CBsalleListe = new ComboBox();
            labelPeriodeSalle = new Label();
            comboBox3 = new ComboBox();
            labelEmployeeConcerné = new Label();
            textBox2 = new TextBox();
            labelEquipements = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDcapacite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDheureDebut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDminuteDebut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDheureFin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDminuteFin).BeginInit();
            SuspendLayout();
            // 
            // labelemployeeReservation
            // 
            labelemployeeReservation.AutoSize = true;
            labelemployeeReservation.Location = new Point(12, 9);
            labelemployeeReservation.Name = "labelemployeeReservation";
            labelemployeeReservation.Size = new Size(64, 15);
            labelemployeeReservation.TabIndex = 0;
            labelemployeeReservation.Text = "Employées";
            // 
            // CBemployeeR
            // 
            CBemployeeR.DropDownStyle = ComboBoxStyle.DropDownList;
            CBemployeeR.FormattingEnabled = true;
            CBemployeeR.Location = new Point(57, 27);
            CBemployeeR.Name = "CBemployeeR";
            CBemployeeR.Size = new Size(249, 23);
            CBemployeeR.TabIndex = 1;
            CBemployeeR.SelectedIndexChanged += CBemployeeR_SelectedIndexChanged;
            // 
            // capaciteLabel
            // 
            capaciteLabel.AutoSize = true;
            capaciteLabel.Location = new Point(358, 9);
            capaciteLabel.Name = "capaciteLabel";
            capaciteLabel.Size = new Size(59, 15);
            capaciteLabel.TabIndex = 2;
            capaciteLabel.Text = "Capacitée";
            // 
            // NUDcapacite
            // 
            NUDcapacite.Location = new Point(358, 27);
            NUDcapacite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDcapacite.Name = "NUDcapacite";
            NUDcapacite.Size = new Size(94, 23);
            NUDcapacite.TabIndex = 3;
            NUDcapacite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CBXequipement1
            // 
            CBXequipement1.AutoSize = true;
            CBXequipement1.Location = new Point(61, 94);
            CBXequipement1.Name = "CBXequipement1";
            CBXequipement1.Size = new Size(83, 19);
            CBXequipement1.TabIndex = 5;
            CBXequipement1.Text = "Ordinateur";
            CBXequipement1.UseVisualStyleBackColor = true;
            CBXequipement1.CheckedChanged += CBXequipement1_CheckedChanged;
            // 
            // CBXequipement2
            // 
            CBXequipement2.AutoSize = true;
            CBXequipement2.Location = new Point(205, 94);
            CBXequipement2.Name = "CBXequipement2";
            CBXequipement2.Size = new Size(110, 19);
            CBXequipement2.TabIndex = 6;
            CBXequipement2.Text = "VideoProjecteur";
            CBXequipement2.UseVisualStyleBackColor = true;
            CBXequipement2.CheckedChanged += CBXequipement1_CheckedChanged;
            // 
            // CBXequipement3
            // 
            CBXequipement3.AutoSize = true;
            CBXequipement3.Location = new Point(61, 138);
            CBXequipement3.Name = "CBXequipement3";
            CBXequipement3.Size = new Size(96, 19);
            CBXequipement3.TabIndex = 7;
            CBXequipement3.Text = "Climatisation";
            CBXequipement3.UseVisualStyleBackColor = true;
            CBXequipement3.CheckedChanged += CBXequipement1_CheckedChanged;
            // 
            // CBXequipement4
            // 
            CBXequipement4.AutoSize = true;
            CBXequipement4.Location = new Point(205, 138);
            CBXequipement4.Name = "CBXequipement4";
            CBXequipement4.Size = new Size(101, 19);
            CBXequipement4.TabIndex = 8;
            CBXequipement4.Text = "Insonorisation";
            CBXequipement4.UseVisualStyleBackColor = true;
            CBXequipement4.CheckedChanged += CBXequipement1_CheckedChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(61, 183);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 9;
            labelDate.Text = "Date";
            // 
            // labelHeure
            // 
            labelHeure.AutoSize = true;
            labelHeure.Location = new Point(292, 183);
            labelHeure.Name = "labelHeure";
            labelHeure.Size = new Size(39, 15);
            labelHeure.TabIndex = 10;
            labelHeure.Text = "Heure";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Location = new Point(376, 183);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(50, 15);
            labelMinute.TabIndex = 11;
            labelMinute.Text = "Minutes";
            // 
            // labelDebut
            // 
            labelDebut.AutoSize = true;
            labelDebut.Location = new Point(10, 220);
            labelDebut.Name = "labelDebut";
            labelDebut.Size = new Size(39, 15);
            labelDebut.TabIndex = 12;
            labelDebut.Text = "Debut";
            // 
            // DTperiodeDebut
            // 
            DTperiodeDebut.Location = new Point(57, 214);
            DTperiodeDebut.Name = "DTperiodeDebut";
            DTperiodeDebut.Size = new Size(200, 23);
            DTperiodeDebut.TabIndex = 13;
            DTperiodeDebut.ValueChanged += DTperiodeDebut_ValueChanged;
            // 
            // NUDheureDebut
            // 
            NUDheureDebut.Location = new Point(292, 214);
            NUDheureDebut.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDheureDebut.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            NUDheureDebut.Name = "NUDheureDebut";
            NUDheureDebut.Size = new Size(46, 23);
            NUDheureDebut.TabIndex = 14;
            NUDheureDebut.Value = new decimal(new int[] { 6, 0, 0, 0 });
            NUDheureDebut.ValueChanged += NUDheureDebut_ValueChanged;
            // 
            // NUDminuteDebut
            // 
            NUDminuteDebut.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            NUDminuteDebut.Location = new Point(376, 214);
            NUDminuteDebut.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            NUDminuteDebut.Name = "NUDminuteDebut";
            NUDminuteDebut.Size = new Size(62, 23);
            NUDminuteDebut.TabIndex = 15;
            NUDminuteDebut.ValueChanged += NUDminuteDebut_ValueChanged;
            // 
            // labelFin
            // 
            labelFin.AutoSize = true;
            labelFin.Location = new Point(12, 267);
            labelFin.Name = "labelFin";
            labelFin.Size = new Size(23, 15);
            labelFin.TabIndex = 16;
            labelFin.Text = "Fin";
            // 
            // DTperiodeFin
            // 
            DTperiodeFin.Location = new Point(57, 259);
            DTperiodeFin.Name = "DTperiodeFin";
            DTperiodeFin.Size = new Size(200, 23);
            DTperiodeFin.TabIndex = 17;
            DTperiodeFin.ValueChanged += DTperiodeFin_ValueChanged;
            // 
            // NUDheureFin
            // 
            NUDheureFin.Location = new Point(292, 259);
            NUDheureFin.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDheureFin.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            NUDheureFin.Name = "NUDheureFin";
            NUDheureFin.Size = new Size(46, 23);
            NUDheureFin.TabIndex = 18;
            NUDheureFin.Value = new decimal(new int[] { 6, 0, 0, 0 });
            NUDheureFin.ValueChanged += NUDheureFin_ValueChanged;
            // 
            // NUDminuteFin
            // 
            NUDminuteFin.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            NUDminuteFin.Location = new Point(376, 259);
            NUDminuteFin.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            NUDminuteFin.Name = "NUDminuteFin";
            NUDminuteFin.Size = new Size(62, 23);
            NUDminuteFin.TabIndex = 19;
            NUDminuteFin.ValueChanged += NUDminuteFin_ValueChanged;
            // 
            // labelSalleDispo
            // 
            labelSalleDispo.AutoSize = true;
            labelSalleDispo.Location = new Point(12, 303);
            labelSalleDispo.Name = "labelSalleDispo";
            labelSalleDispo.Size = new Size(90, 15);
            labelSalleDispo.TabIndex = 20;
            labelSalleDispo.Text = "Salle Disponible";
            // 
            // CBsalleDispo
            // 
            CBsalleDispo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBsalleDispo.FormattingEnabled = true;
            CBsalleDispo.Location = new Point(57, 323);
            CBsalleDispo.Name = "CBsalleDispo";
            CBsalleDispo.Size = new Size(200, 23);
            CBsalleDispo.TabIndex = 21;
            CBsalleDispo.SelectedIndexChanged += CBsalleDispo_SelectedIndexChanged;
            // 
            // Bvalider
            // 
            Bvalider.Enabled = false;
            Bvalider.Location = new Point(358, 322);
            Bvalider.Name = "Bvalider";
            Bvalider.Size = new Size(94, 23);
            Bvalider.TabIndex = 22;
            Bvalider.Text = "Valider";
            Bvalider.UseVisualStyleBackColor = true;
            Bvalider.Click += Bvalider_Click;
            // 
            // labelEployeesListe
            // 
            labelEployeesListe.AutoSize = true;
            labelEployeesListe.Location = new Point(514, 9);
            labelEployeesListe.Name = "labelEployeesListe";
            labelEployeesListe.Size = new Size(64, 15);
            labelEployeesListe.TabIndex = 23;
            labelEployeesListe.Text = "Employées";
            // 
            // CBEmployeesListe
            // 
            CBEmployeesListe.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEmployeesListe.FormattingEnabled = true;
            CBEmployeesListe.Location = new Point(514, 27);
            CBEmployeesListe.Name = "CBEmployeesListe";
            CBEmployeesListe.Size = new Size(189, 23);
            CBEmployeesListe.TabIndex = 24;
            // 
            // labelPeriodeEmployee
            // 
            labelPeriodeEmployee.AutoSize = true;
            labelPeriodeEmployee.Location = new Point(514, 61);
            labelPeriodeEmployee.Name = "labelPeriodeEmployee";
            labelPeriodeEmployee.Size = new Size(47, 15);
            labelPeriodeEmployee.TabIndex = 25;
            labelPeriodeEmployee.Text = "Periode";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(514, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 26;
            // 
            // labelSalleReserve
            // 
            labelSalleReserve.AutoSize = true;
            labelSalleReserve.Location = new Point(514, 117);
            labelSalleReserve.Name = "labelSalleReserve";
            labelSalleReserve.Size = new Size(74, 15);
            labelSalleReserve.TabIndex = 27;
            labelSalleReserve.Text = "Salle Reservé";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 135);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 28;
            // 
            // labelSalles
            // 
            labelSalles.AutoSize = true;
            labelSalles.Location = new Point(514, 182);
            labelSalles.Name = "labelSalles";
            labelSalles.Size = new Size(96, 15);
            labelSalles.TabIndex = 29;
            labelSalles.Text = "Salle de réunions";
            // 
            // CBsalleListe
            // 
            CBsalleListe.DropDownStyle = ComboBoxStyle.DropDownList;
            CBsalleListe.FormattingEnabled = true;
            CBsalleListe.Location = new Point(514, 198);
            CBsalleListe.Name = "CBsalleListe";
            CBsalleListe.Size = new Size(187, 23);
            CBsalleListe.TabIndex = 30;
            // 
            // labelPeriodeSalle
            // 
            labelPeriodeSalle.AutoSize = true;
            labelPeriodeSalle.Location = new Point(514, 241);
            labelPeriodeSalle.Name = "labelPeriodeSalle";
            labelPeriodeSalle.Size = new Size(47, 15);
            labelPeriodeSalle.TabIndex = 31;
            labelPeriodeSalle.Text = "Periode";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(514, 258);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 23);
            comboBox3.TabIndex = 32;
            // 
            // labelEmployeeConcerné
            // 
            labelEmployeeConcerné.AutoSize = true;
            labelEmployeeConcerné.Location = new Point(514, 303);
            labelEmployeeConcerné.Name = "labelEmployeeConcerné";
            labelEmployeeConcerné.Size = new Size(110, 15);
            labelEmployeeConcerné.TabIndex = 33;
            labelEmployeeConcerné.Text = "Employée reservant";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(514, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 34;
            // 
            // labelEquipements
            // 
            labelEquipements.AutoSize = true;
            labelEquipements.Location = new Point(10, 61);
            labelEquipements.Name = "labelEquipements";
            labelEquipements.Size = new Size(76, 15);
            labelEquipements.TabIndex = 35;
            labelEquipements.Text = "Equipements";
            // 
            // ReservationSalleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 368);
            Controls.Add(labelEquipements);
            Controls.Add(textBox2);
            Controls.Add(labelEmployeeConcerné);
            Controls.Add(comboBox3);
            Controls.Add(labelPeriodeSalle);
            Controls.Add(CBsalleListe);
            Controls.Add(labelSalles);
            Controls.Add(textBox1);
            Controls.Add(labelSalleReserve);
            Controls.Add(comboBox1);
            Controls.Add(labelPeriodeEmployee);
            Controls.Add(CBEmployeesListe);
            Controls.Add(labelEployeesListe);
            Controls.Add(Bvalider);
            Controls.Add(CBsalleDispo);
            Controls.Add(labelSalleDispo);
            Controls.Add(NUDminuteFin);
            Controls.Add(NUDheureFin);
            Controls.Add(DTperiodeFin);
            Controls.Add(labelFin);
            Controls.Add(NUDminuteDebut);
            Controls.Add(NUDheureDebut);
            Controls.Add(DTperiodeDebut);
            Controls.Add(labelDebut);
            Controls.Add(labelMinute);
            Controls.Add(labelHeure);
            Controls.Add(labelDate);
            Controls.Add(CBXequipement4);
            Controls.Add(CBXequipement3);
            Controls.Add(CBXequipement2);
            Controls.Add(CBXequipement1);
            Controls.Add(NUDcapacite);
            Controls.Add(capaciteLabel);
            Controls.Add(CBemployeeR);
            Controls.Add(labelemployeeReservation);
            Name = "ReservationSalleForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUDcapacite).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDheureDebut).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDminuteDebut).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDheureFin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDminuteFin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FenetreListeEmployee fenetreListeEmployee1;
        private FenetreListeSalle fenetreListeSalle1;
        private FenetreListeEmployee fenetreListeEmployee2;
        private FenetreListeSalle fenetreListeSalle2;
        private FenetreListeSalle listeSalle;
        private Label labelemployeeReservation;
        private ComboBox CBemployeeR;
        private Label capaciteLabel;
        private NumericUpDown NUDcapacite;
        private CheckBox CBXequipement1;
        private CheckBox CBXequipement2;
        private CheckBox CBXequipement3;
        private CheckBox CBXequipement4;
        private Label labelDate;
        private Label labelHeure;
        private Label labelMinute;
        private Label labelDebut;
        private DateTimePicker DTperiodeDebut;
        private NumericUpDown NUDheureDebut;
        private NumericUpDown NUDminuteDebut;
        private Label labelFin;
        private DateTimePicker DTperiodeFin;
        private NumericUpDown NUDheureFin;
        private NumericUpDown NUDminuteFin;
        private Label labelSalleDispo;
        private ComboBox CBsalleDispo;
        private Button Bvalider;
        private Label labelEployeesListe;
        private ComboBox CBEmployeesListe;
        private Label labelPeriodeEmployee;
        private ComboBox comboBox1;
        private Label labelSalleReserve;
        private TextBox textBox1;
        private Label labelSalles;
        private ComboBox CBsalleListe;
        private Label labelPeriodeSalle;
        private ComboBox comboBox3;
        private Label labelEmployeeConcerné;
        private TextBox textBox2;
        private Label labelEquipements;
    }
}
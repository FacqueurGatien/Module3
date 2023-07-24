namespace ReservationSalleWinform
{
    partial class FormulaireReservationUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            listeEmployee = new ComboBoxUC();
            capacite = new NumericUpDownUC();
            groupBoxequipement = new GroupBox();
            item6 = new CheckBoxUC();
            item5 = new CheckBoxUC();
            item4 = new CheckBoxUC();
            item3 = new CheckBoxUC();
            item2 = new CheckBoxUC();
            item1 = new CheckBoxUC();
            dateDebut = new DatePickerUC();
            heureDebut = new NumericUpDownUC();
            minuteDebut = new NumericUpDownUC();
            dateFin = new DatePickerUC();
            heureFin = new NumericUpDownUC();
            minuteFin = new NumericUpDownUC();
            listeSalleDispo = new ComboBoxUC();
            buttonValider = new Button();
            groupBoxequipement.SuspendLayout();
            SuspendLayout();
            // 
            // listeEmployee
            // 
            listeEmployee.Location = new Point(1, 8);
            listeEmployee.MaximumSize = new Size(200, 50);
            listeEmployee.MinimumSize = new Size(47, 43);
            listeEmployee.Name = "listeEmployee";
            listeEmployee.Size = new Size(181, 50);
            listeEmployee.TabIndex = 0;
            // 
            // capacite
            // 
            capacite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            capacite.Location = new Point(304, 8);
            capacite.MaximumSize = new Size(200, 50);
            capacite.MinimumSize = new Size(47, 43);
            capacite.Name = "capacite";
            capacite.Size = new Size(68, 50);
            capacite.TabIndex = 1;
            // 
            // groupBoxequipement
            // 
            groupBoxequipement.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxequipement.Controls.Add(item6);
            groupBoxequipement.Controls.Add(item5);
            groupBoxequipement.Controls.Add(item4);
            groupBoxequipement.Controls.Add(item3);
            groupBoxequipement.Controls.Add(item2);
            groupBoxequipement.Controls.Add(item1);
            groupBoxequipement.Location = new Point(15, 76);
            groupBoxequipement.Name = "groupBoxequipement";
            groupBoxequipement.Size = new Size(379, 159);
            groupBoxequipement.TabIndex = 2;
            groupBoxequipement.TabStop = false;
            groupBoxequipement.Text = "Equipements";
            // 
            // item6
            // 
            item6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            item6.Location = new Point(266, 96);
            item6.MaximumSize = new Size(200, 50);
            item6.MinimumSize = new Size(47, 43);
            item6.Name = "item6";
            item6.Size = new Size(89, 43);
            item6.TabIndex = 5;
            // 
            // item5
            // 
            item5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            item5.Location = new Point(138, 96);
            item5.MaximumSize = new Size(200, 50);
            item5.MinimumSize = new Size(47, 43);
            item5.Name = "item5";
            item5.Size = new Size(89, 43);
            item5.TabIndex = 4;
            // 
            // item4
            // 
            item4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            item4.Location = new Point(16, 96);
            item4.MaximumSize = new Size(200, 50);
            item4.MinimumSize = new Size(47, 43);
            item4.Name = "item4";
            item4.Size = new Size(89, 43);
            item4.TabIndex = 3;
            // 
            // item3
            // 
            item3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            item3.Location = new Point(266, 27);
            item3.MaximumSize = new Size(200, 50);
            item3.MinimumSize = new Size(47, 43);
            item3.Name = "item3";
            item3.Size = new Size(89, 43);
            item3.TabIndex = 2;
            // 
            // item2
            // 
            item2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            item2.Location = new Point(138, 27);
            item2.MaximumSize = new Size(200, 50);
            item2.MinimumSize = new Size(47, 43);
            item2.Name = "item2";
            item2.Size = new Size(89, 43);
            item2.TabIndex = 1;
            // 
            // item1
            // 
            item1.Location = new Point(16, 27);
            item1.MaximumSize = new Size(200, 50);
            item1.MinimumSize = new Size(47, 43);
            item1.Name = "item1";
            item1.Size = new Size(89, 43);
            item1.TabIndex = 0;
            // 
            // dateDebut
            // 
            dateDebut.Anchor = AnchorStyles.Left;
            dateDebut.Location = new Point(15, 262);
            dateDebut.MaximumSize = new Size(200, 50);
            dateDebut.MinimumSize = new Size(200, 47);
            dateDebut.Name = "dateDebut";
            dateDebut.Size = new Size(200, 47);
            dateDebut.TabIndex = 3;
            // 
            // heureDebut
            // 
            heureDebut.Anchor = AnchorStyles.Right;
            heureDebut.Location = new Point(241, 262);
            heureDebut.MaximumSize = new Size(200, 50);
            heureDebut.MinimumSize = new Size(47, 43);
            heureDebut.Name = "heureDebut";
            heureDebut.Size = new Size(71, 43);
            heureDebut.TabIndex = 4;
            // 
            // minuteDebut
            // 
            minuteDebut.Anchor = AnchorStyles.Right;
            minuteDebut.Location = new Point(327, 262);
            minuteDebut.MaximumSize = new Size(200, 50);
            minuteDebut.MinimumSize = new Size(47, 43);
            minuteDebut.Name = "minuteDebut";
            minuteDebut.Size = new Size(67, 43);
            minuteDebut.TabIndex = 5;
            // 
            // dateFin
            // 
            dateFin.Anchor = AnchorStyles.Left;
            dateFin.Location = new Point(15, 315);
            dateFin.MaximumSize = new Size(200, 50);
            dateFin.MinimumSize = new Size(200, 47);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(200, 47);
            dateFin.TabIndex = 6;
            // 
            // heureFin
            // 
            heureFin.Anchor = AnchorStyles.Right;
            heureFin.Location = new Point(241, 315);
            heureFin.MaximumSize = new Size(200, 50);
            heureFin.MinimumSize = new Size(47, 43);
            heureFin.Name = "heureFin";
            heureFin.Size = new Size(71, 43);
            heureFin.TabIndex = 7;
            // 
            // minuteFin
            // 
            minuteFin.Anchor = AnchorStyles.Right;
            minuteFin.Location = new Point(327, 315);
            minuteFin.MaximumSize = new Size(200, 50);
            minuteFin.MinimumSize = new Size(47, 43);
            minuteFin.Name = "minuteFin";
            minuteFin.Size = new Size(67, 43);
            minuteFin.TabIndex = 8;
            // 
            // listeSalleDispo
            // 
            listeSalleDispo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listeSalleDispo.Location = new Point(15, 378);
            listeSalleDispo.MaximumSize = new Size(200, 50);
            listeSalleDispo.MinimumSize = new Size(47, 43);
            listeSalleDispo.Name = "listeSalleDispo";
            listeSalleDispo.Size = new Size(200, 43);
            listeSalleDispo.TabIndex = 9;
            // 
            // buttonValider
            // 
            buttonValider.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValider.Enabled = false;
            buttonValider.Location = new Point(241, 392);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(153, 27);
            buttonValider.TabIndex = 10;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // FormulaireReservationUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonValider);
            Controls.Add(listeSalleDispo);
            Controls.Add(minuteFin);
            Controls.Add(heureFin);
            Controls.Add(dateFin);
            Controls.Add(minuteDebut);
            Controls.Add(heureDebut);
            Controls.Add(dateDebut);
            Controls.Add(groupBoxequipement);
            Controls.Add(capacite);
            Controls.Add(listeEmployee);
            MinimumSize = new Size(410, 430);
            Name = "FormulaireReservationUC";
            Size = new Size(410, 430);
            groupBoxequipement.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBoxUC listeEmployee;
        private NumericUpDownUC capacite;
        private GroupBox groupBoxequipement;
        private CheckBoxUC item6;
        private CheckBoxUC item5;
        private CheckBoxUC item4;
        private CheckBoxUC item3;
        private CheckBoxUC item2;
        private CheckBoxUC item1;
        private DatePickerUC dateDebut;
        private NumericUpDownUC heureDebut;
        private NumericUpDownUC minuteDebut;
        private DatePickerUC dateFin;
        private NumericUpDownUC heureFin;
        private NumericUpDownUC minuteFin;
        private ComboBoxUC listeSalleDispo;
        private Button buttonValider;
    }
}

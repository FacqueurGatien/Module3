namespace ReservationSalleWinform
{
    partial class FenetreListeEmployee
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
            comboBoxListe = new ComboBoxUC();
            comboBoxPeriode = new ComboBoxUC();
            textBoxResult = new TextBoxUC();
            SuspendLayout();
            // 
            // comboBoxListe
            // 
            comboBoxListe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxListe.Location = new Point(3, 3);
            comboBoxListe.MaximumSize = new Size(200, 50);
            comboBoxListe.MinimumSize = new Size(47, 43);
            comboBoxListe.Name = "comboBoxListe";
            comboBoxListe.Size = new Size(200, 50);
            comboBoxListe.TabIndex = 0;
            // 
            // comboBoxPeriode
            // 
            comboBoxPeriode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPeriode.Location = new Point(3, 59);
            comboBoxPeriode.MaximumSize = new Size(200, 50);
            comboBoxPeriode.MinimumSize = new Size(47, 43);
            comboBoxPeriode.Name = "comboBoxPeriode";
            comboBoxPeriode.Size = new Size(200, 50);
            comboBoxPeriode.TabIndex = 1;
            // 
            // textBoxResult
            // 
            textBoxResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult.Location = new Point(3, 115);
            textBoxResult.MaximumSize = new Size(200, 50);
            textBoxResult.MinimumSize = new Size(43, 47);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(200, 50);
            textBoxResult.TabIndex = 2;
            // 
            // FenetreListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxResult);
            Controls.Add(comboBoxPeriode);
            Controls.Add(comboBoxListe);
            MinimumSize = new Size(210, 175);
            Name = "FenetreListe";
            Size = new Size(210, 175);
            ResumeLayout(false);
        }

        #endregion

        private ComboBoxUC comboBoxListe;
        private ComboBoxUC comboBoxPeriode;
        private TextBoxUC textBoxResult;
    }
}

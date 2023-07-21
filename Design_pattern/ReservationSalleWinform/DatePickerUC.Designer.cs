namespace ReservationSalleWinform
{
    partial class DatePickerUC
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
            label = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(3, 0);
            label.Name = "label";
            label.Size = new Size(38, 15);
            label.TabIndex = 0;
            label.Text = "label1";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(3, 22);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(192, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // DatePickerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker);
            Controls.Add(label);
            MaximumSize = new Size(200, 50);
            MinimumSize = new Size(200, 47);
            Name = "DatePickerUC";
            Size = new Size(200, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private DateTimePicker dateTimePicker;
    }
}

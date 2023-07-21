namespace ReservationSalleWinform
{
    partial class CheckBoxUC
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
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(38, 15);
            label.TabIndex = 0;
            label.Text = "label1";
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Bottom;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(12, 20);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(15, 14);
            checkBox.TabIndex = 1;
            checkBox.UseVisualStyleBackColor = true;
            // 
            // CheckBoxUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox);
            Controls.Add(label);
            MaximumSize = new Size(200, 50);
            MinimumSize = new Size(47, 43);
            Name = "CheckBoxUC";
            Size = new Size(47, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private CheckBox checkBox;
    }
}

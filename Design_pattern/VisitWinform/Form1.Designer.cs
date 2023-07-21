namespace VisitWinform
{
    partial class Form1
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
            panelDessiner = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panelDessiner.SuspendLayout();
            SuspendLayout();
            // 
            // panelDessiner
            // 
            panelDessiner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDessiner.Controls.Add(dateTimePicker1);
            panelDessiner.Location = new Point(1, 1);
            panelDessiner.Name = "panelDessiner";
            panelDessiner.Size = new Size(803, 452);
            panelDessiner.TabIndex = 0;
            panelDessiner.Paint += panelDessiner_Paint;
            panelDessiner.MouseClick += panelDessiner_MouseClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDessiner);
            Name = "Form1";
            Text = "Form1";
            panelDessiner.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDessiner;
        private DateTimePicker dateTimePicker1;
    }
}
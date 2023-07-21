using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSalleWinform
{
    public partial class NumericUpDownUC : UserControl
    {
        public NumericUpDownUC()
        {
            InitializeComponent();
        }
        public string LabelNumericUpDownUC(string text) =>label.Text=text;
        public int NUDNumericUpDownUC() => (int)numericUpDown.Value;
        public void ChangerPasNUDNumericUpDownUC(int pas) => numericUpDown.Increment = pas;
        public void ChangerMaxNUDNumericUpDownUC(int max) => numericUpDown.Maximum = max;
        public void ChangerMinNUDNumericUpDownUC(int min) => numericUpDown.Increment = min;

    }
}

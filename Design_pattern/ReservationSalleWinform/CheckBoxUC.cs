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
    public partial class CheckBoxUC : UserControl
    {
        public CheckBoxUC()
        {
            InitializeComponent();
        }
        public string LabelCheckBoxUC(string text) => label.Text=text;
        public bool CBCheckBoxUC() =>checkBox.Checked;
    }
}

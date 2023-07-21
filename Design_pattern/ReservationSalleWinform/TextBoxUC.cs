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
    public partial class TextBoxUC : UserControl
    {
        public TextBoxUC()
        {
            InitializeComponent();
        }
        public string LabelTextBoxUC(string text) =>label.Text=text;
        public void TBTextBoxUC(string text) =>textBox.Text=text; 
    }
}

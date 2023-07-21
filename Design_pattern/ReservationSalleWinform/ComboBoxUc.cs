using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSalleWinform
{
    public partial class ComboBoxUC : UserControl
    {
        public ComboBoxUC()
        {
            InitializeComponent();
        }
        public string LabelComboBoxUC(string text)=> label.Text = text;
        public ComboBox.ObjectCollection ItemsComboBoxUC(object item)
        {
            comboBox.Items.Add(item);
            return comboBox.Items;
        }
    }
}

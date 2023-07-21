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
    public partial class DatePickerUC : UserControl
    {
        public DatePickerUC()
        {
            InitializeComponent();
        }
        public string LabelDateTimePickerUC(string text) =>label.Text=text;
        public DateTime DateDateTimePickkerUC() => dateTimePicker.Value;
    }
}

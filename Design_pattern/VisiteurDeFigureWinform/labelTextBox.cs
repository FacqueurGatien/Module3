using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisiteurDeFigureWinform
{
    public partial class labelTextBox : UserControl
    {
        public labelTextBox()
        {
            InitializeComponent();
        }

        private void labelTextBox_Load(object sender, EventArgs e)
        {

        }
        public void SetLabel(string text)
        {
            label1.Text=text;
        }
        public int GetValue()
        {
            int value=1;
            int.TryParse(textBox1.Text, out value);
            return value;
        }
    }
}

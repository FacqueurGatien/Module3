﻿using SalleDeReunionExample;
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
    public partial class FormulaireReservationUC : UserControl
    {
        public List<Employee> employees { get; set; }
        public List<SalleDeReunion> salleDeReunions { get; set; }
        public IMediateur mediateur { get; set; }
        public FormulaireReservationUC()
        {
            InitializeComponent();
        }
        public UserControl UserControl() => this;
    }
}

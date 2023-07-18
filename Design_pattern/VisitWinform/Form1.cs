using FigureGeo;
using System.Drawing;
using System.Windows.Forms;
using VisiteurDeFigureWinform;

namespace VisitWinform
{
    public partial class Form1 : Form
    {
        private Graphics graph;
        private Figure f;
        VisiteurWinFormConcrete vw;
        public Form1()
        {
            InitializeComponent();
            graph = panelDessiner.CreateGraphics();
            vw = new VisiteurWinFormConcrete(graph);
        }

        private void panelDessiner_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelDessiner_MouseClick(object sender, MouseEventArgs e)
        {
            f = new FigureGeo.Rectangle(0, 0, 100, 100);
            Panel p = f.Accept(vw);
            p.Location = new Point(e.X - f.anchor.X, e.Y - f.anchor.Y);
            panelDessiner.Controls.Add(p);
        }
    }
}
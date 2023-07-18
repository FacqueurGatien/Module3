using FigureGeo;
using System.CodeDom.Compiler;
using System.Drawing;

namespace VisiteurDeFigureWinform
{
    public partial class FigureWinform : Form
    {
        public FigureWinform()
        {
            InitializeComponent();
            Figure f = new FigureGeo.Rectangle(0, 0, 100, 50);
            f.Accept(new VisiteurWinFormConcrete(panel));
            Graphics graph = panel.CreateGraphics();
            graph.DrawRectangle(new Pen(Color.Red, 50.0f),
                (int)0,
                (int)0,
                (int)100,
                (int)100);
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
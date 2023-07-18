using FigureGeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisiteurDeFigureWinform
{
    public class VisiteurWinFormConcrete : IVisiteurDeFigure<Panel>
    {
        private Panel panel;
        private int posX;
        private int posY;
        private double mesure1;
        private double mesure2;
        public VisiteurWinFormConcrete(Graphics graph)
        {
            panel = new Panel();
            panel.Paint += PaintPanel;
        }
        private void PaintPanel(object sender, PaintEventArgs e)
        {
            Graphics graphics = panel.CreateGraphics();
            graphics.DrawRectangle(new Pen(Color.Red,5),
                (int)posX,
                (int)posY,
                (int)mesure1,
                (int)mesure2);
        }
        public Panel Visite(FigureGeo.Rectangle rectangle)
        {
            mesure1 = rectangle.Longueur;
            mesure2 = rectangle.Largeur;
            panel = new Panel();
            panel.Size = new Size((int)rectangle.Longueur,(int)rectangle.Largeur);
            panel.BackColor = Color.White;
            panel.Paint += PaintPanel;
            PaintPanel(null,null);
            return panel;
        }

        public Panel Visite(Rond rond)
        {
            throw new NotImplementedException();
        }

        public Panel Visite(Triangle triangle)
        {
            throw new NotImplementedException();
        }

        public Panel Visite(Carre carre)
        {
            throw new NotImplementedException();
        }

        public Panel Visite(Figures figures)
        {
            throw new NotImplementedException();
        }
    }
}

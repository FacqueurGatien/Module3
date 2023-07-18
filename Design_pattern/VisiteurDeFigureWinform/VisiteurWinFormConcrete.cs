using FigureGeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiteurDeFigureWinform
{
    public class VisiteurWinFormConcrete : IVisiteurDeFigure<Panel>
    {
        private Panel panel;
        private Pen pen;
        public VisiteurWinFormConcrete(Panel panel)
        {
            this.panel = panel;
            this.pen = new Pen(Color.Red, 2);
        }
        public Panel Visite(FigureGeo.Rectangle rectangle)
        {
            /*Panel panel = new Panel();
            panel.BackColor = Color.LightCoral;*/
            
            /*Graphics graph = panel.CreateGraphics();
            graph.DrawRectangle(pen,
                (int)0,
                (int)0,
                (int)100,
                (int)100);*/
            //return panel;
            return null;
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

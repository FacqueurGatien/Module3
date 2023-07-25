using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiareMediator
{
    public abstract class Coleague
    {
        protected IMediator mediator;
        protected string nom;
        public Coleague(IMediator _mediator,string _nom)
        {
            mediator = _mediator;
            nom = _nom;
        }
        public abstract string InfoPublish();
        public abstract string CvPublish();
    }
}

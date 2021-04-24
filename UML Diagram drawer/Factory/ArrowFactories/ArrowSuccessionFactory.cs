using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Arrows.ArrowHeads;
using UML_Diagram_drawer.Arrows.ArrowNocks;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public class ArrowSuccessionFactory : IArrowsFactory
    {
        public Arrow GetArrow()
        {
            return new Arrow(arrowHead: new TriangleArrowHead());
        }
    }
}

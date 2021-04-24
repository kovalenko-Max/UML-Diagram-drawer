using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Arrows.ArrowHeads;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public class ArrowAssociationFactory : IArrowsFactory
    {
        public Arrow GetArrow()
        {
            return new Arrow(arrowHead: new ThreePointArrowHead());
        }
    }
}

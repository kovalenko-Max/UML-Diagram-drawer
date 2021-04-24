using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Arrows;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    interface IArrowsFactory
    {
        Arrow GetArrow();
    }
}

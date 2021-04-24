using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Arrows.ArrowHeads;
using UML_Diagram_drawer.Arrows;
using System.Drawing;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public class ArrowRealizationFactory : IArrowsFactory
    {
        public Arrow GetArrow()
        {
            Pen pen = (Pen)Default.Draw.Pen.Clone();
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            return new Arrow(pen: pen, arrowHead: new TriangleArrowHead());
        }
    }
}

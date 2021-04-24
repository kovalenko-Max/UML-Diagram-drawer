using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Arrows
{
    public class Arrow : AbstactArrow
    {
        public Arrow(Pen pen = null, IArrowHead arrowHead = null, IArrowNock arrowNock = null) : base(pen, arrowHead, arrowNock)
        {
        }
    }
}

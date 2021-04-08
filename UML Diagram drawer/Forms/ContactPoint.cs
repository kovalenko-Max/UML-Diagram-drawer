using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UML_Diagram_drawer.Forms
{
    public class ContactPoint
    {
        Point Location { get; set; }
        Side side { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if(obj is ContactPoint)
            {
                ContactPoint contactPoint = (ContactPoint)obj;
                result = (Location == contactPoint.Location) && (side == contactPoint.side);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Location.ToString()} {side}";
        }
    }
}

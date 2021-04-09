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
        public Point Location { get; set; }
        public Side Side { get; set; }

        public ContactPoint(Point location)
        {
            Location = location;
        }
        public ContactPoint(Point location, Side side)
        {
            Location = location;
            Side = side;
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if(obj is ContactPoint)
            {
                ContactPoint contactPoint = (ContactPoint)obj;
                result = (Location == contactPoint.Location) && (Side == contactPoint.Side);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Location.ToString()} {Side}";
        }
    }
}

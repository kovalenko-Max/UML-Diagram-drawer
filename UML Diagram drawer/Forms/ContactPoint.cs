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
        private int _selectRadius = 30;
        public Point Location { get; set; }
        public Side Side { get; set; }

        public static ContactPoint Empty = new ContactPoint(Point.Empty);

        public ContactPoint(Point location)
        {
            Location = location;
        }

        public ContactPoint(Point location, Side side)
        {
            Location = location;
            Side = side;
        }

        

        public void Draw()
        {
            Point secondPoint;
            if (Side == Side.Bottom)
            {
                secondPoint = new Point(Location.X, Location.Y - 20);
            }
            else if (Side == Side.Down)
            {
                secondPoint = new Point(Location.X, Location.Y + 20);
            }
            else if (Side == Side.Left)
            {
                secondPoint = new Point(Location.X - 20, Location.Y);
            }
            else
            {
                secondPoint = new Point(Location.X + 20, Location.Y);
            }
            MainGraphics.Graphics.DrawLine(new Pen(Color.Red, 10), Location, secondPoint);
            _rectangle = new Rectangle(new Point(Location.X, Location.Y - 5), new Size(secondPoint.X - Location.X, secondPoint.Y - Location.Y));
        }

        public bool Select(Point point)
        {
            bool result = false;

            if (Contains(point))
            {
                result = true;
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is ContactPoint)
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

        private bool Contains(Point point)
        {
            bool result = false;

            if (Math.Pow(point.X - Location.X, 2) + Math.Pow(point.Y - Location.Y, 2) < Math.Pow(_selectRadius, 2))
            {
                result = true;
            }

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class FormUML : ISelectable
    {
        private Rectangle _rectangle;
        public Point Location { get; set; }
        public Point SecondPoint { get; set; }

        public ContactPoint BottomContactPoint { get; set; }
        public ContactPoint LeftContactPoint { get; set; }
        public ContactPoint RightContactPoint { get; set; }
        public ContactPoint DownContactPoint { get; set; }
        public ContactPoint[] ContactPoints { get; set; }
        public bool IsSelected { get; set; }
        public Pen Pen { get; set; }
        public Rectangle[] Rectangles { get; set; }
        public Point[] Points { get; set; }


        public ContactPoint ConnectArrow(Point point)
        {
            var result = ContactPoint.Empty;

            foreach (var contactPoint in ContactPoints)
            {
                if (contactPoint.FindClosestContactPoint(point))
                {
                    contactPoint.Select(point);
                    result = contactPoint;
                }
            }

            return result;
        }



        public void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            _rectangle = new Rectangle(Location, Default.Size.FormSize);
            SecondPoint = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height);
            MainGraphics.Graphics.DrawRectangle(Default.Draw.Pen, Location.X, Location.Y, _rectangle.Width, _rectangle.Height);

            SetContactPoint();
            DrawCP();
        }

        public void Move(int deltaX, int deltaY)
        {
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }

        public void Select(Point point)
        {
            throw new NotImplementedException();
        }

        private void DrawCP()
        {
            foreach (var contactPoint in ContactPoints)
            {
                contactPoint.Draw();
            }
        }

        private void SetContactPoint()
        {
            ContactPoints = new ContactPoint[4];
            Point location = new Point(Location.X + _rectangle.Width / 2, Location.Y);
            ContactPoints[0] = new ContactPoint(location, Side.Bottom);
            location = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height / 2);
            ContactPoints[1] = new ContactPoint(location, Side.Right);
            location = new Point(Location.X, Location.Y + _rectangle.Height / 2);
            ContactPoints[2] = new ContactPoint(location, Side.Left);
            location = new Point(Location.X + _rectangle.Width / 2, Location.Y + _rectangle.Height);
            ContactPoints[3] = new ContactPoint(location, Side.Down);
        }
    }
}

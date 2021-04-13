using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class FormUML
    {
        private Rectangle _rectangle;
        public Point Location { get; set; }
        public Point SecondPoint { get; set; }

        public ContactPoint BottomContactPoint { get; set; }
        public ContactPoint LeftContactPoint { get; set; }
        public ContactPoint RightContactPoint { get; set; }
        public ContactPoint DownContactPoint { get; set; }

        public void Draw()
        {
            _rectangle = new Rectangle(Location, Default.Size.FormSize);
            SecondPoint = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height);
            MainGraphics.Graphics.DrawRectangle(Default.Draw.Pen, Location.X, Location.Y, _rectangle.Width, _rectangle.Height);

            SetContactPoint();
            DrawCP();
        }

        public void Move(int deltaX,int deltaY)
        {
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }
        private void DrawCP()
        {
            BottomContactPoint.Draw();
            RightContactPoint.Draw();
            LeftContactPoint.Draw();
            DownContactPoint.Draw();
        }

        private void SetContactPoint()
        {
            Point location = new Point(Location.X + _rectangle.Width / 2, Location.Y);
            BottomContactPoint = new ContactPoint(location, Side.Bottom);
            location = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height / 2);
            RightContactPoint = new ContactPoint(location, Side.Right);
            location = new Point(Location.X, Location.Y + _rectangle.Height / 2);
            LeftContactPoint = new ContactPoint(location, Side.Left);
            location = new Point(Location.X + _rectangle.Width/2, Location.Y + _rectangle.Height);
            DownContactPoint = new ContactPoint(location, Side.Down);
        }
    }
}

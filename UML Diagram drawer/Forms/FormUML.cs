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
        public ContactPoint[] ContactPoints { get; set; }
        public bool IsSelected { get; set; }
        public Pen Pen { get; set; }
        public Module[] Modules { get; set; }

        public FormUML()
        {
            Pen = Default.Draw.Pen;
            Modules = new Module[3];
            SetContactPoint();
            CreateModules();
        }

        public ContactPoint ConnectArrow(Point point)
        {
            ContactPoint result = ContactPoint.Empty;

            foreach (ContactPoint contactPoint in ContactPoints)
            {
                if (contactPoint.Select(point))
                {
                    result = contactPoint;
                }
            }

            return result;
        }

        public void Draw()
        {
            //int pointX = Location.X + _rectangle.Width;
            //int pointY = Location.Y + _rectangle.Height;
            //SecondPoint = new Point(pointX, pointY);

            MainGraphics.Graphics.FillRectangle(Default.Draw.FillBrush, GetRectangle());
            MainGraphics.Graphics.DrawRectangle(Pen, GetRectangle());

            DrawModules();
            SetNewLocationContactPoint();
        }

        public void Move(int deltaX, int deltaY)
        {
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }

        public void RemoveSelect()
        {
            if (!IsSelected)
            {
                IsSelected = false;
                Pen = Default.Draw.Pen;

                foreach (var item in Modules)
                {
                    item.Pen = Pen;
                }
            }
        }

        public bool Select(Point point)
        {
            if (_rectangle != null)
            {
                bool result = false;
                if (_rectangle.Contains(point))
                {
                    Pen = Default.Draw.PenSelect;

                    foreach (var item in Modules)
                    {
                        item.Pen = Pen;
                    }

                    IsSelected = true;
                    result = true;
                }

                return result;
            }
            else
            {
                throw new ArgumentNullException("Rectangle is null");
            }
        }

        private void CreateModules()
        {
            Modules[0] = new Module() { ModuleType = ModuleType.Title };
            Modules[1] = new Module() { ModuleType = ModuleType.Field };
            Modules[2] = new Module() { ModuleType = ModuleType.Method };
        }

        private void DrawModules()
        {
            int currentLocationY = 0;
            foreach (Module module in Modules)
            {
                module.Location = new Point(this.Location.X, this.Location.Y + currentLocationY);
                currentLocationY += module.Size.Height;
                module.Draw();
            }
        }

        private Rectangle GetRectangle()
        {
            if (_rectangle.IsEmpty)
            {
                _rectangle = new Rectangle(Location, Default.Size.FormSize);
            }
            int currentSizeY = 0;
            for (int i = 0; i < Modules.Length; i++)
            {
                currentSizeY += Modules[i].Size.Height;
            }
            _rectangle.Size = new Size(_rectangle.Size.Width, currentSizeY);
            _rectangle.Location = this.Location;
            return _rectangle;
        }

        private void SetNewLocationContactPoint()
        {
            Point location = new Point(Location.X + _rectangle.Width / 2, Location.Y);
            ContactPoints[0].Location = location;
            location = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height / 2);
            ContactPoints[1].Location = location;
            location = new Point(Location.X, Location.Y + _rectangle.Height / 2);
            ContactPoints[2].Location = location;
            location = new Point(Location.X + _rectangle.Width / 2, Location.Y + _rectangle.Height);
            ContactPoints[3].Location = location;
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

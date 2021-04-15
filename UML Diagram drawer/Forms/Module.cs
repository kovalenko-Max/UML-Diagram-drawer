using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class Module
    {
        private bool _isAddFirstText = true;

        private Rectangle _rectangle;
        public Point Location { get; set; }
        public Pen Pen { get; set; }
        public List<TextField> TextFields { get; set; }
        public ModuleType ModuleType { get; set; }
        public Size Size { get; set; }

        public Module()
        {
            Pen = Default.Draw.Pen;
            TextFields = new List<TextField>();
        }

        public void Draw()
        {
            MainGraphics.Graphics.DrawRectangle(Pen, GetRectangle());

            if (_isAddFirstText)
            {
                AddTextField();
                _isAddFirstText = false;
            }

            DrawTextField();
        }

        public void AddTextField()
        {
            TextField tempTextField = new TextField() { Location = new Point(this.Location.X, this.Location.Y + GetNewLocationY()) };
            TextFields.Add(tempTextField);
        }

        private int GetNewLocationY()
        {
            int currentLocationY = 0;
            for (int i = 0; i < TextFields.Count; i++)
            {
                currentLocationY += TextFields[i].Size.Height;
            }

            return currentLocationY;
        }
        
        private Rectangle GetRectangle()
        {
            if (_rectangle.IsEmpty)
            {
                _rectangle = new Rectangle(Location, Default.Size.ModuleFormSize);
            }

            Size = new Size(_rectangle.Width, GetNewLocationY());
            _rectangle.Size = Size;
            _rectangle.Location = this.Location;

            return _rectangle;
        }

        private void DrawTextField()
        {
            int currentLocationY = 0;
            for (int i = 0; i < TextFields.Count; i++)
            {
                TextFields[i].Location = new Point(this.Location.X, this.Location.Y + currentLocationY);
                currentLocationY += TextFields[i].Size.Height;
                TextFields[i].Draw();
            }
        }
    }
}

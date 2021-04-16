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
        public Size Size
        {
            get
            {
                return _rectangle.Size;
            }
            private set
            {
                _rectangle.Size = value;
            }
        }

        public Module()
        {
            Pen = Default.Draw.Pen;
            TextFields = new List<TextField>();
            _rectangle = new Rectangle(Location, Default.Size.ModuleFormSize);
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

        public void RemoveTextField()
        {
            TextFields.RemoveAt(TextFields.Count - 1);
        }

        public void RemoveConcreteTextField(TextField textField)
        {
            TextFields.Remove(textField);
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
            int addHeight = GetNewLocationY() == 0 ? Default.Size.ModuleFormSize.Height : 0;
            _rectangle.Size = new Size(_rectangle.Width, addHeight + GetNewLocationY());
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

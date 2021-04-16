using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class TextField
    {
        public Rectangle _rectangle;
        public Pen Pen { get; set; }
        public Font Font { get; set; }
        public SolidBrush Brush { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
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

        public TextField()
        {
            Pen = Default.Draw.Pen;
            Font = Default.Text.Font;
            Brush = Default.Text.Brush;
            Text = Default.Text.SomeText;
        }

        public void Draw()
        {
            MainGraphics.Graphics.DrawString(Text, Font, Brush, (RectangleF)GetRectangle());
        }

        private Rectangle GetRectangle()
        {
            if (_rectangle.IsEmpty)
            {
                _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
            }

            _rectangle.Size = new Size(_rectangle.Width, _rectangle.Height);
            _rectangle.Location = this.Location;

            return _rectangle;
        }
    }
}

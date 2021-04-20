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
        private Rectangle _rectangle;
        public Pen Pen { get; set; }
        public Font Font { get; set; }
        public StringFormat StringFormat { get; set; }
        public SolidBrush Brush { get; set; }
        public string Text { get; set; }
        public Point Location
        {
            get
            {
                return _rectangle.Location;
            }
            set
            {
                _rectangle.Location = value;
            }
        }
        public Size Size
        {
            get
            {
                return _rectangle.Size;
            }
            set
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
            _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
        }

        public TextField(string text)
        {
            Pen = Default.Draw.Pen;
            Font = Default.Text.Font;
            Brush = Default.Text.Brush;
            Text = text;
            _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
        }

        public TextField(string text, Pen pen, Font font, SolidBrush brush,StringFormat stringFormat)
        {
            Pen = pen;
            Font = font;
            Brush = brush;
            Text = text;
            StringFormat = stringFormat;
            _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
        }

        public void Draw()
        {
            MainGraphics.Graphics.DrawString(Text, Font, Brush, (RectangleF)_rectangle,StringFormat);
        }

        public bool Contains(Point point)
        {
            return _rectangle.Contains(point);   
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is TextField)
            {
                TextField textField = (TextField)obj;
                if (this.Text == textField.Text && this.Location == textField.Location)
                {
                    result = true;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(Text);
            result.Append(" " + Location);

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class TextField : ICloneable
    {
        private bool _isSelect;
        private SolidBrush _brush;
        private Rectangle _rectangle;
        public string Text { get; set; }
        public Font Font { get; set; }
        public StringFormat StringFormat { get; set; }
        public Color Color
        {
            get
            {
                if (_brush != null)
                {
                    return _brush.Color;
                }

                throw new ArgumentNullException("Brush is null");
            }
            set
            {
                if (_brush != null)
                {
                    _brush.Color = value;
                }
                else
                {
                    throw new ArgumentNullException("Brush is null");
                }
            }
        }
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
            Font = (Font)Default.Text.Font.Clone();
            _brush = (SolidBrush)Default.Text.Brush.Clone();
            Color = _brush.Color;
            Text = Default.Text.SomeText;
            _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
        }

        public TextField(string text)
        {
            Font = (Font)Default.Text.Font.Clone();
            _brush = (SolidBrush)Default.Text.Brush.Clone();
            Color = _brush.Color;
            Text = text;
            _rectangle = new Rectangle(Location, Default.Size.TextFieldSize);
        }

        public void Draw()
        {
            _rectangle.Size = new Size(_rectangle.Width, GetDesiredSize().Height);
            MainGraphics.Graphics.DrawString(Text, Font, _brush, (RectangleF)_rectangle, StringFormat);
            if (_isSelect)
            {
                MainGraphics.Graphics.DrawRectangle(new Pen(Color,5), _rectangle);
            }
        }

        public bool Contains(Point point)
        {
            return _rectangle.Contains(point);
        }

        public void Select()
        {
            _isSelect = true;
        }

        public void RemoveSelect()
        {
            _isSelect = false;
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

        public Size GetDesiredSize()
        {
            SizeF newSize = MainGraphics.Graphics.MeasureString(Text, Font);
            Size result = Default.Size.TextFieldSize;
            if (newSize.ToSize().Width > Default.Size.TextFieldSize.Width
                && newSize.ToSize().Height > Default.Size.TextFieldSize.Height)
            {
                result = new Size(newSize.ToSize().Width + 10, newSize.ToSize().Height + 10);
            }
            else if (newSize.ToSize().Width > Default.Size.TextFieldSize.Width)
            {
                result.Width = newSize.ToSize().Width + 10;
            }
            else if (newSize.ToSize().Height > Default.Size.TextFieldSize.Height)
            {
                result.Height = newSize.ToSize().Height + 40;
            }

            return result;
        }

        public object Clone()
        {
            TextField newModule = (TextField)this.MemberwiseClone();
            newModule._brush = (SolidBrush)_brush.Clone();
            newModule.Color = Color;
            newModule.Font = Font;
            newModule.Size = Size;
            newModule.StringFormat = StringFormat;
            newModule.Location = Location;
            newModule.StringFormat = StringFormat;
            newModule.Text = Text;

            return newModule;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms.Modules;

namespace UML_Diagram_drawer.Forms
{
    public abstract class AbstactModule
    {
        protected Rectangle _rectangle;
        protected Pen _pen;
        public ModuleType Type { get; set; }
        public string DefaultText { get; set; }
        public float WidthLine
        {
            get
            {
                return _pen.Width;
            }
            set
            {
                _pen.Width = value;
            }
        }
        public Color Color { get; set; }
     
        public Font Font { get; set; }
        public List<TextField> TextFields { get; set; }
        public StringFormat StringFormat { get; set; }
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

        public AbstactModule()
        {
            _pen = Default.Draw.Pen;
            Color = _pen.Color;
            Font = Default.Text.Font;
            _rectangle = new Rectangle(Location, Default.Size.ModuleFormSize);
            TextFields = new List<TextField>();
        }

        public AbstactModule(ModuleType type, string defaultText, StringFormat stringFormat)
        {
            Type = type;
            _pen = Default.Draw.Pen;
            Color = _pen.Color;
            Font = Default.Text.Font;
            DefaultText = defaultText;
            _rectangle = new Rectangle(Location, Default.Size.ModuleFormSize);
            StringFormat = stringFormat;
            TextFields = new List<TextField>();
            TextFields.Add(new TextField(DefaultText)
            {
                StringFormat = stringFormat,
                Location = new Point(Location.X, Location.Y + GetDesiredSize().Height)
            });
        }

        public virtual void Draw()
        {
            //
            _pen.Color = Color;
            _rectangle.Height = GetDesiredSize().Height;
            MainGraphics.Graphics.DrawRectangle(_pen, _rectangle);
            DrawTextField();
        }

        public void AddTextField()
        {
            int addedY = 0;
            foreach (TextField text in TextFields)
            {
                addedY += text.Size.Height;
            }

            TextField tempTextField = new TextField(DefaultText)
            {
                Location = new Point(Location.X, Location.Y + addedY),
                Font = Font
            };

            TextFields.Add(tempTextField);
        }

        public void AddTextField(string text)
        {
            if (text != null)
            {
                int addedY = 0;
                foreach (TextField textField in TextFields)
                {
                    addedY += textField.Size.Height;
                }

                TextField tempTextField = new TextField(text)
                {
                    Font = Font,
                    StringFormat = StringFormat,
                    Location = new Point(Location.X, Location.Y + addedY)
                };

                TextFields.Add(tempTextField);
            }
            else
            {
                throw new ArgumentNullException("Text is null");
            }
        }

        public void RemoveTextField()
        {
            TextFields.RemoveAt(TextFields.Count - 1);
        }

        public void RemoveConcreteTextField(TextField textField)
        {
            if (textField != null)
            {
                TextFields.Remove(textField);
            }
            else
            {
                throw new ArgumentNullException("TextField is null");
            }
        }

        public void RemoveTextField(Point point)
        {
            foreach (TextField text in TextFields)
            {
                if (text.Contains(point))
                {
                    RemoveConcreteTextField(text);
                    break;
                }
            }
        }

        public bool Contains(Point point)
        {
            return _rectangle.Contains(point);
        }

        public void SetFont(Font font)
        {
            Font = font;
            foreach (TextField text in TextFields)
            {
                text.Font = font;
            }
        }

        public void SetColorText(Color color)
        {
            foreach (TextField text in TextFields)
            {
                text.Color = color;
            }
        }

        public void Resize(int value)
        {
            Font = new Font(Font.FontFamily, value);
            foreach (var item in TextFields)
            {
                item.Font = new Font(item.Font.FontFamily, value);
            }
        }

        public TextField SelectTextField(Point point)
        {
            if (Contains(point))
            {
                TextField result = null;

                foreach (TextField text in TextFields)
                {
                    if (text.Contains(point))
                    {
                        result = text;
                    }
                }

                return result;
            }

            throw new ArgumentException("Point out of range");
        }

        public abstract override bool Equals(object obj);

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Type + " " + Location);

            return result.ToString();
        }

        public int GetMaximumWidth()
        {
            int max = 0;
            foreach (TextField text in TextFields)
            {
                int value = text.GetDesiredSize().Width;
                if (max < value)
                {
                    max = value;
                }
            }
            return max;
        }

        public Size GetDesiredSize()
        {
            Size addedSize = Size.Empty;
            for (int i = 0; i < TextFields.Count; i++)
            {
                if (addedSize.Width < TextFields[i].GetDesiredSize().Height)
                {
                    addedSize.Width = TextFields[i].GetDesiredSize().Width;
                }
                addedSize.Height += TextFields[i].GetDesiredSize().Height;
            }

            return addedSize;
        }

        public void SetWidth(int width)
        {
            foreach (TextField text in TextFields)
            {
                text.Size = new Size(width, text.Size.Height);
            }
        }

        protected void DrawTextField()
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public abstract class AbstactModule
    {
        protected bool _isAddFirstText = true;
        protected Rectangle _rectangle;

        public string DefaultText { get; set; }
        public Pen Pen { get; set; }
        public List<TextField> TextFields { get; set; }
        public StringFormat StringFormat { get; set; }
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
            Pen = Default.Draw.Pen;
            TextFields = new List<TextField>();
            _rectangle = new Rectangle(Location, Default.Size.ModuleFormSize);
        }

        public virtual void Draw()
        {
            MainGraphics.Graphics.DrawRectangle(Pen, GetRectangle());

            if (_isAddFirstText)
            {
                AddTextField(DefaultText);
                _isAddFirstText = false;
            }

            DrawTextField();
        }

        public void AddTextField()
        {
            TextField tempTextField = new TextField()
            {
                Text = DefaultText,
                Location = new Point(this.Location.X, this.Location.Y + GetNewLocationY())
                
            };

            TextFields.Add(tempTextField);
        }

        public void AddTextField(string text)
        {
            if (text != null)
            {
                TextField tempTextField = new TextField()
                {
                    StringFormat = this.StringFormat,
                    Text = text,
                    Location = new Point(this.Location.X, this.Location.Y + GetNewLocationY())
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
            result.Append(this.GetType() + " " + Location);

            return result.ToString();
        }

        protected int GetNewLocationY()
        {
            int currentLocationY = 0;
            for (int i = 0; i < TextFields.Count; i++)
            {
                currentLocationY += TextFields[i].Size.Height;
            }

            return currentLocationY;
        }

        protected Rectangle GetRectangle()
        {
            int addHeight = GetNewLocationY() == 0 ? Default.Size.ModuleFormSize.Height : 0;
            _rectangle.Size = new Size(_rectangle.Width, addHeight + GetNewLocationY());
            _rectangle.Location = this.Location;

            return _rectangle;
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

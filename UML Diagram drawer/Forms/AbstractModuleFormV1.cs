using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public abstract class AbstractModuleFormV1
    {
        private bool _isCreatetDefaultField = true;
        private Size _defaultSize = DefaultValue.ModuleFormSize;
        private Pen _defaultPen = new Pen(Color.Black, 5);
        private string _defaultText;
        private Rectangle _rectangle;
        public Size Size { get; set; }
        public Point Location { get; set; }
        public List<TextFieldV1> TextFields { get; set; }
        public StringFormat StringFormat { get; set; }
        public Pen Pen { get; set; }
        public Size DefaultSize
        {
            get
            {
                return _defaultSize;
            }
            set
            {
                _defaultSize = value;
            }
        }
        public Pen DefaultPen
        {
            get
            {
                return _defaultPen;
            }
            set
            {
                _defaultPen = value;
            }
        }
        public string DefaultText
        {
            get
            {
                return _defaultText;
            }
            set
            {
                _defaultText = value;
            }
        }
        public bool Visible { get; set; }

        public AbstractModuleFormV1()
        {
            Size = DefaultSize;
            Pen = DefaultPen;
            TextFields = new List<TextFieldV1>();
        }

        public AbstractModuleFormV1(Size size)
        {
            Size = size;
            Pen = DefaultPen;
            TextFields = new List<TextFieldV1>();
        }

        public AbstractModuleFormV1(Size size, Pen pen)
        {
            Size = size;
            Pen = pen;
            TextFields = new List<TextFieldV1>();
        }

        public void Draw()
        {
            if (!Location.IsEmpty&&Visible)
            {
                _rectangle = new Rectangle(Location, GetSize());
                MainGraphics.Graphics.DrawRectangle(Pen, _rectangle);
                if (_isCreatetDefaultField)
                {
                    AddTextField();
                    _isCreatetDefaultField = false;
                }
                DrawTextFields();
            }
        }

        public void AddTextField()
        {
            var textFietld = TextFieldV1.GetTextField(_defaultText, StringFormat, GetPointForNewTextField());
            TextFields.Add(textFietld);
        }

        private Size GetSize()
        {
            Size result = Size.Empty;
            if (TextFields.Count > 0)
            {
                int wigth = DefaultValue.ModuleFormSize.Width;
                int height = 0;
                for (int i = 0; i < TextFields.Count; i++)
                {
                    height += TextFields[i].Rectangle.Height;
                }
                result = new Size(wigth, height);
            }
            else
            {
                result = DefaultValue.ModuleFormSize;
            }

            return result;
        }

        private Point GetPointForNewTextField()
        {
            Point result = Point.Empty;
            if (TextFields.Count > 0)
            {
                int pointX = Location.X;
                int pointY = 0;
                for (int i = 0; i < TextFields.Count; i++)
                {
                    pointY += TextFields[i].Rectangle.Height;
                }
                result = new Point(pointX, pointY);
            }
            else
            {
                result = Location;
            }

            return result;
        }

        public void DrawTextFields()
        {
            foreach (TextFieldV1 text in TextFields)
            {
                text.Draw();
            }
        }
    }
}

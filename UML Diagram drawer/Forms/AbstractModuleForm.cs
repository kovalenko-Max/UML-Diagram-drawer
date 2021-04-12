using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public abstract class AbstractModuleForm 
    {
        private bool _isCreatetDefaultField = true;
        private Size _defaultSize = new Size(200, 25);
        private Pen _defaultPen = new Pen(Color.Black, 5);
        private string _defaultText;
        private Rectangle _rectangle;

        public Font Font = new Font("Arial", 14);
        public Size Size { get; set; }
        public Point Location { get; set; }
        public List<TextField> TextFields { get; set; }
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

        public AbstractModuleForm()
        {
            Size = DefaultSize;
            Pen = DefaultPen;
            TextFields = new List<TextField>();
        }

        public AbstractModuleForm(Size size)
        {
            Size = size;
            Pen = DefaultPen;
            TextFields = new List<TextField>();
        }

        public AbstractModuleForm(Size size, Pen pen)
        {
            Size = size;
            Pen = pen;
            TextFields = new List<TextField>();
        }

        public void Draw(Graphics graphics)
        {
            if (!Location.IsEmpty)
            {
                //Size = new Size(Size.Width, Size.Height * TextFields.Count + 40);
                _rectangle = new Rectangle(Location, Size);
                graphics.DrawRectangle(Pen, _rectangle);
                if (_isCreatetDefaultField)
                {
                    AddTextField(graphics);
                    _isCreatetDefaultField = false;
                }
            }
        }

        public virtual void AddTextField(Graphics graphics)
        {
            var textFietld = new TextField();
            TextFields.Add(textFietld);
            TextFields[TextFields.Count - 1].Text = _defaultText;
            TextFields[TextFields.Count - 1].Font = Font;
            TextFields[TextFields.Count - 1].StringFormat = StringFormat;
            TextFields[TextFields.Count - 1].Draw(graphics, _rectangle);
        }
    }
}

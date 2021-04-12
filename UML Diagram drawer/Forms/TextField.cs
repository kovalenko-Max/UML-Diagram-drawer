using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public class TextField 
    {
        private Font _defaultFont = new Font("Arial", 14);
        private string _defaultText = "Text";
        private Rectangle _rectangle;
        public Size Size
        {
            get
            {
                if (_rectangle != null)
                {
                    return _rectangle.Size;
                }

                throw new ArgumentNullException("Rectangle is null");
            }
            set
            {
                if (_rectangle != null)
                {
                    _rectangle.Size = value;
                }
                else
                {
                    throw new ArgumentNullException("Rectangle is null");
                }
            }
        }
        public StringFormat StringFormat { get; set; }
        public Font Font { get; set; }
        public string Text { get; set; }

        public TextField()
        {
            Text = _defaultText;
            Font = _defaultFont;
            _rectangle = new Rectangle();
        }

        public void Draw(Graphics graphics, Rectangle rectangle)
        {
            if (Text != string.Empty && StringFormat != null)
            {
                _rectangle = rectangle;
                graphics.DrawString(Text, Font, new SolidBrush(Color.Black), _rectangle, StringFormat);
            }
        }
        
    }
}

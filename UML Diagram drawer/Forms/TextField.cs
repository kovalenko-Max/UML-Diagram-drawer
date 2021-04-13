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

        public StringFormat StringFormat { get; set; }
        public Font Font { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
        public Rectangle Rectangle { get; set; }

        private TextField(string text,StringFormat strFormat,Point location)
        {
            Text = text;
            StringFormat = strFormat;
            Font = _defaultFont;
            Location = location;
            Rectangle = new Rectangle(Location,DefaultValue.TextFieldSize);
        }

        public static TextField GetTextField(string text, StringFormat strFormat, Point location)
        {
            if (text != null && strFormat != null && location != null)
            {
                return new TextField(text, strFormat, location);
            }
            
            throw new ArgumentNullException("Value is null");
        }

        public void Draw()
        {
            if (Text != string.Empty && StringFormat != null)
            {
                MainGraphics.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black), Rectangle, StringFormat);
            }
        }
        
    }
}

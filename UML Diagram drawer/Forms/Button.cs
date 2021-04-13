using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    class Button
    {
        public Rectangle Rectangle { get; set; }
        public Point Location { get; set; }
        public string Text { get; set; }
        public Font Font { get; set; }

        public Button()
        {
            Text = "Button";
            Rectangle = new Rectangle();
            Font = new Font("Arial", 10);
            Location = Point.Empty;
        }
    }
}

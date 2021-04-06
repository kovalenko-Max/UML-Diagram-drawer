using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public class Squere
    {
        private int _width;
        private int _heigth;
        private int _widthLine = 5;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value >= 0 ? value : 0;
            }
        }
        public int Height
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = value >= 0 ? value : 0;
            }
        }
        public int WidthLine
        {
            get
            {
                return _widthLine;
            }
            set
            {
                _widthLine = value >= 0 ? value : 0;
            }
        }

        public Point Location { get; set; }
        public Color Color { get; set; }
        public Pen Pen { get; set; }

        public Squere(Color color, int widht = 100, int height = 100)
        {
            Color = color;
            Width = widht;
            Height = height;
            Pen = new Pen(color, Width);
        }

        public void Draw(Graphics graphics)
        {
            if (!Location.IsEmpty)
            {
                graphics.DrawRectangle(Pen, Location.X, Location.Y, Width, Height);
            }
        }

        public void OnCollisionEnter(Graphics graphics, Point point)
        {
            if (!(graphics is null) && !point.IsEmpty)
            {
                bool onColEnterX = point.X > Location.X && point.X < Location.X + Width;
                bool onColEnterY = point.Y > Location.Y && point.Y < Location.Y + Height;

                if (onColEnterX && onColEnterY)
                {
                    Pen.Color = Color.Blue;
                    Draw(graphics);
                }
            }
            else if(graphics is null)
            {
                throw new ArgumentException("Graphics is null");
            }
            else
            {
                throw new ArgumentException("Point is null");
            }
        }
    }
}

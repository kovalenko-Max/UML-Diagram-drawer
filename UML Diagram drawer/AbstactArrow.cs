using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public abstract class AbstactArrow
    {
        private int _width = 5;
        private int _sizeArrowhead;
        private Point _from = Point.Empty;
        private Point _to = Point.Empty;

        public bool IsHorizontal { get; set; }
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public Color Color { get; set; }
        public Point From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
            }
        }
        public Point To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value > 0 ? value : 0;

                _sizeArrowhead = _width * 3;
            }
        }
        public int SizeArrowhead
        {
            get
            {
                return _sizeArrowhead;
            }
            set
            {
                _sizeArrowhead = value > 0 ? value : 0;
            }
        }

        public abstract void Draw();

        public void DrawStraightBrokenLine(int wipeFromStartArrow = 0, int wipeFromEndArrow = 0)
        {
            Point[] points;

            if (IsHorizontal)
            {
                wipeFromEndArrow = To.X > From.X ? wipeFromEndArrow * (-1) : wipeFromEndArrow;
                wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                points = new Point[]
                {
                    new Point(From.X+wipeFromStartArrow,From.Y),
                    new Point((To.X + From.X) / 2,From.Y),
                    new Point((To.X + From.X) / 2,To.Y),
                    new Point(To.X+wipeFromEndArrow,To.Y)
                };

                Graphics.DrawLines(Pen, points);
            }
            else
            {
                wipeFromEndArrow = To.Y < From.Y ? wipeFromEndArrow : wipeFromEndArrow * (-1);
                wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                points = new Point[]
                {
                    new Point(From.X+wipeFromStartArrow,From.Y),
                    new Point(To.X, From.Y),
                    new Point(To.X,To.Y+wipeFromEndArrow)
                };

                Graphics.DrawLines(Pen, points);
            }
        }
    }
}

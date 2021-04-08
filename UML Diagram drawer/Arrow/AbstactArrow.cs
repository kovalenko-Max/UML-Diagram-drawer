using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer.Arrow
{
    public abstract class AbstactArrow
    {
        protected int _sizeArrowhead;

        public bool IsHorizontal { get; set; }
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public ContactPoint ContactPoint { get; set; }
       
        public AbstactArrow(Pen pen, Graphics graphics, Point startPoint, Point endPoint)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;
            Graphics = graphics;
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        public AbstactArrow(Pen pen, Graphics graphics)
        {
            Pen = pen;
            Graphics = graphics;
            _sizeArrowhead = (int)Pen.Width * 3;
        }

        public abstract void Draw();

        public abstract void CreateSelectionBorders();

        public void DrawStraightBrokenLine(int wipeFromStartArrow = 0, int wipeFromEndArrow = 0)
        {
            if (!StartPoint.IsEmpty && !EndPoint.IsEmpty)
            {
                Point[] points;

                if (IsHorizontal)
                {
                    wipeFromEndArrow = EndPoint.X > StartPoint.X ? wipeFromEndArrow * (-1) : wipeFromEndArrow;
                    wipeFromStartArrow = EndPoint.X > StartPoint.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    points = new Point[]
                    {
                        new Point(StartPoint.X+wipeFromStartArrow,StartPoint.Y),
                        new Point((EndPoint.X + StartPoint.X) / 2,StartPoint.Y),
                        new Point((EndPoint.X + StartPoint.X) / 2,EndPoint.Y),
                        new Point(EndPoint.X+wipeFromEndArrow,EndPoint.Y)
                    };

                    Graphics.DrawLines(Pen, points);
                }
                else
                {
                    wipeFromEndArrow = EndPoint.Y < StartPoint.Y ? wipeFromEndArrow : wipeFromEndArrow * (-1);
                    wipeFromStartArrow = EndPoint.X > StartPoint.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    points = new Point[]
                    {
                        new Point(StartPoint.X+wipeFromStartArrow,StartPoint.Y),
                        new Point(EndPoint.X, StartPoint.Y),
                        new Point(EndPoint.X,EndPoint.Y+wipeFromEndArrow)
                    };

                    Graphics.DrawLines(Pen, points);
                }
            }
        }

    }
}

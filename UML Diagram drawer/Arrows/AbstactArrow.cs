using System;
using System.Drawing;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    public abstract class AbstactArrow : ISelectable
    {
        protected int _sizeArrowhead;
        
        public bool IsHorizontal { get; set; }
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public ContactPoint StartPoint { get; set; }
        public ContactPoint EndPoint { get; set; }
        public bool IsSelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsMove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point StartMovePoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Rectangle[] Rectangles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point[] Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AbstactArrow(Pen pen, Graphics graphics, Point startPoint, Point endPoint)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;
            Graphics = graphics;

            StartPoint = new ContactPoint(startPoint);
            EndPoint = new ContactPoint(endPoint);
        }
        public AbstactArrow(Pen pen, Graphics graphics)
        {
            Pen = pen;
            Graphics = graphics;
            _sizeArrowhead = (int)Pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public abstract void Draw();

        public void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }

        public void DrawStraightBrokenLine(int wipeFromStartArrow = 0, int wipeFromEndArrow = 0)
        {
            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                Point[] points;

                if (IsHorizontal)
                {
                    wipeFromEndArrow = EndPoint.Location.X > StartPoint.Location.X ? wipeFromEndArrow * (-1) : wipeFromEndArrow;
                    wipeFromStartArrow = EndPoint.Location.X > StartPoint.Location.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    points = new Point[]
                    {
                        new Point(StartPoint.Location.X+wipeFromStartArrow,StartPoint.Location.Y),
                        new Point((EndPoint.Location.X + StartPoint.Location.X) / 2,StartPoint.Location.Y),
                        new Point((EndPoint.Location.X + StartPoint.Location.X) / 2,EndPoint.Location.Y),
                        new Point(EndPoint.Location.X+wipeFromEndArrow,EndPoint.Location.Y)
                    };

                    Graphics.DrawLines(Pen, points);
                }
                else
                {
                    wipeFromEndArrow = EndPoint.Location.Y < StartPoint.Location.Y ? wipeFromEndArrow : wipeFromEndArrow * (-1);
                    wipeFromStartArrow = EndPoint.Location.X > StartPoint.Location.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    points = new Point[]
                    {
                        new Point(StartPoint.Location.X+wipeFromStartArrow,StartPoint.Location.Y),
                        new Point(EndPoint.Location.X, StartPoint.Location.Y),
                        new Point(EndPoint.Location.X,EndPoint.Location.Y+wipeFromEndArrow)
                    };

                    Graphics.DrawLines(Pen, points);
                }
            }
        }


        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public bool Select(Point point)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }
    }
}

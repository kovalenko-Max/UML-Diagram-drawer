using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    public abstract class AbstactArrow : ISelectable
    {
        protected int _sizeArrowhead;

        public bool IsHorizontal { get; set; }
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
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

        public void CreateRectangles()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public void Select(Point point)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }
    }
}

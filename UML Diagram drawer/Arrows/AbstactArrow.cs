using System;
using System.Drawing;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    public abstract class AbstactArrow : ISelectable
    {
        const int indentFromBorder = 50;

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
        public Point[] Points { get; set; }

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

        protected Point[] GetPoints()
        {
            if ((StartPoint.Side == Side.Left && EndPoint.Side == Side.Right)
                || (StartPoint.Side == Side.Right && EndPoint.Side == Side.Left))
            {
                Points = zigzagArroyLeftRighr();
            }
            else if ((StartPoint.Side == Side.Up && EndPoint.Side == Side.Bottom)
                || (StartPoint.Side == Side.Bottom && EndPoint.Side == Side.Up))
            {
                Points = zigzagArroyUpDown();
            }
            else if ((StartPoint.Side == Side.Bottom && EndPoint.Side == Side.Left || (EndPoint.Side == Side.Right))
                || (StartPoint.Side == Side.Up && (EndPoint.Side == Side.Left) || (EndPoint.Side == Side.Right)))
            {
                Points = RectangularArrowUpBottom();
            }
            else if ((StartPoint.Side == Side.Left && (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom))
                || (StartPoint.Side == Side.Right && (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)))
            {
                Points = RectangularArrowLeftRight();
            }

            if((EndPoint.Location.Y >= StartPoint.Location.Y + indentFromBorder) && ((StartPoint.Side == Side.Left && EndPoint.Location.X > StartPoint.Location.X)
                || (StartPoint.Side == Side.Right && EndPoint.Location.X < StartPoint.Location.X)))
            {
                Points = new Point[5];
                Points[0] = StartPoint.Location;
                Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y + indentFromBorder);
                int middle = (StartPoint.Location.X + EndPoint.Location.X) / 2;
                Points[2] = new Point(middle, StartPoint.Location.Y + indentFromBorder);
                Points[3] = new Point(middle, EndPoint.Location.Y);
                Points[4] = EndPoint.Location;
            }

            //if ((StartPoint.Side == Side.Left && (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom) && EndPoint.Location.Y >= StartPoint.Location.Y + indentFromBorder))
            //{
            //    Points = new Point[5];
            //    Points[0] = StartPoint.Location;
            //    Points[1] = new Point(StartPoint.Location.X + indentFromBorder, StartPoint.Location.Y);
            //    int middle = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
            //    Points[2] = new Point(StartPoint.Location.X + indentFromBorder, middle);
            //    Points[3] = new Point(EndPoint.Location.X, middle);
            //    Points[4] = EndPoint.Location;
            //}

            return Points;

            Point[] zigzagArroyLeftRighr()
            {
                Point[] points = new Point[4];
                points[0] = StartPoint.Location;
                int middle = (StartPoint.Location.X + EndPoint.Location.X) / 2;
                points[1] = new Point(middle, StartPoint.Location.Y);
                points[2] = new Point(middle, EndPoint.Location.Y);
                points[points.Length - 1] = EndPoint.Location;
                return points;
            }

            Point[] zigzagArroyUpDown()
            {
                Point[] points = new Point[4];
                points[0] = StartPoint.Location;
                int middle = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
                points[1] = new Point(StartPoint.Location.X, middle);
                points[2] = new Point(EndPoint.Location.X, middle);
                points[points.Length - 1] = EndPoint.Location;
                return points;
            }

            Point[] RectangularArrowUpBottom()
            {
                Point[] points = new Point[3];
                points[0] = StartPoint.Location;
                points[1] = new Point(StartPoint.Location.X, EndPoint.Location.Y);
                points[points.Length - 1] = EndPoint.Location;

                return points;
            }

            Point[] RectangularArrowLeftRight()
            {
                Point[] points = new Point[3];
                points[0] = StartPoint.Location;
                points[1] = new Point(EndPoint.Location.X, StartPoint.Location.Y);
                points[points.Length - 1] = EndPoint.Location;

                return points;
            }
        }

        public void DrawStraightBrokenLine()
        {
            Graphics.DrawLines(Pen, GetPoints());
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

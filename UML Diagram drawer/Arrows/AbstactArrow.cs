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

        protected Pen Pen { get; set; }
        public ContactPoint StartPoint { get; set; }
        public ContactPoint EndPoint { get; set; }
        public bool IsSelected { get; set; }
        public bool IsMove { get; set; }
        public Point StartMovePoint { get; set; }
        public Rectangle[] Rectangles { get; set; }
        public Point[] Points { get; set; }

        public AbstactArrow()
        {

        }
        public AbstactArrow(Pen pen, Point startPoint, Point endPoint)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;

            StartPoint = new ContactPoint(startPoint);
            EndPoint = new ContactPoint(endPoint);
        }
        public AbstactArrow(Pen pen)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public abstract void Draw();

        private TypeOfLineDirection kindOfLineSwithcer()
        {
            TypeOfLineDirection typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;

            if (StartPoint.Side == Side.Right)
            {
                if(EndPoint.Side == Side.Bottom)
                {
                    typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangeleLeftRightLine;
                }
                else if (EndPoint.Location.X <= StartPoint.Location.X + indentFromBorder)
                {
                    typeOfLineDirection = TypeOfLineDirection.FivePointsFromLeftToBottomOrUpLine;
                }
                else
                {
                    typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;
                }
            }
            else if (StartPoint.Side == Side.Left)
            {
                if (EndPoint.Location.X <= StartPoint.Location.X + indentFromBorder)
                {
                    typeOfLineDirection = TypeOfLineDirection.FivePointsFromLeftToBottomOrUpLine;
                }
                else
                {
                    typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;
                }
            }
            else if (StartPoint.Side == Side.Bottom)
            {
                if (EndPoint.Location.Y <= StartPoint.Location.Y + indentFromBorder)
                {
                    typeOfLineDirection = TypeOfLineDirection.FivePointsFromeButomToFlankLine;
                }
                else if (EndPoint.Side == Side.Up)
                {
                    typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangelUpDownLine;
                }
                else
                {
                    typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangelUpDownLine;
                }

            }
            else if (StartPoint.Side == Side.Up)
            {
                if(EndPoint.Location == Point.Empty)
                {
                    EndPoint.Side = Side.Bottom;
                }

                if (EndPoint.Location.Y >= StartPoint.Location.Y - indentFromBorder)
                {
                    typeOfLineDirection = TypeOfLineDirection.FivePointsFromUpToFlankLine;
                }
                else if (EndPoint.Side == Side.Bottom)
                {
                    typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakUpDownLine;
                }
                else
                {
                    typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangelUpDownLine;
                }
            }

            return typeOfLineDirection;
        }

        protected Point[] GetPoints()
        {
            switch (kindOfLineSwithcer())
            // switch (TypeOfLineDirection.FourPointsFromRightToRight)
            {
                case TypeOfLineDirection.FourPointsZikzakLeftRightLine:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    int middle = (StartPoint.Location.X + EndPoint.Location.X) / 2;
                    Points[1] = new Point(middle, StartPoint.Location.Y);
                    Points[2] = new Point(middle, EndPoint.Location.Y);
                    Points[Points.Length - 1] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsZikzakUpDownLine:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    middle = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
                    Points[1] = new Point(StartPoint.Location.X, middle);
                    Points[2] = new Point(EndPoint.Location.X, middle);
                    Points[Points.Length - 1] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.ThreePointsRectangelUpDownLine:
                    Points = new Point[3];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, EndPoint.Location.Y);
                    Points[Points.Length - 1] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.ThreePointsRectangeleLeftRightLine:
                    Points = new Point[3];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(EndPoint.Location.X, StartPoint.Location.Y);
                    Points[Points.Length - 1] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromeButomToFlankLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y + indentFromBorder);
                    middle = (StartPoint.Location.X + EndPoint.Location.X) / 2;
                    Points[2] = new Point(middle, StartPoint.Location.Y + indentFromBorder);
                    Points[3] = new Point(middle, EndPoint.Location.Y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromUpToFlankLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y - indentFromBorder);
                    middle = (StartPoint.Location.X + EndPoint.Location.X) / 2;
                    Points[2] = new Point(middle, StartPoint.Location.Y - indentFromBorder);
                    Points[3] = new Point(middle, EndPoint.Location.Y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromLeftToBottomOrUpLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X - indentFromBorder, StartPoint.Location.Y);
                    middle = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
                    Points[2] = new Point(StartPoint.Location.X - indentFromBorder, middle);
                    Points[3] = new Point(EndPoint.Location.X, middle);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromRightToBottomOrUpLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X + indentFromBorder, StartPoint.Location.Y);
                    middle = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
                    Points[2] = new Point(StartPoint.Location.X + indentFromBorder, middle);
                    Points[3] = new Point(EndPoint.Location.X, middle);

                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromUpToUp:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y - indentFromBorder);
                    Points[2] = new Point(EndPoint.Location.X, StartPoint.Location.Y - indentFromBorder);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromBottomToBottom:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y + indentFromBorder);
                    Points[2] = new Point(EndPoint.Location.X, StartPoint.Location.Y + indentFromBorder);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromLeftToLeft:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X - indentFromBorder, StartPoint.Location.Y);
                    Points[2] = new Point(StartPoint.Location.X - indentFromBorder, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromRightToRight:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X + indentFromBorder, StartPoint.Location.Y);
                    Points[2] = new Point(StartPoint.Location.X + indentFromBorder, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;
            }

            return Points;
        }

        public void DrawStraightBrokenLine()
        {
            MainGraphics.Graphics.DrawLines(Pen, GetPoints());
        }

        public void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public bool Select(Point point)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }
    }
}

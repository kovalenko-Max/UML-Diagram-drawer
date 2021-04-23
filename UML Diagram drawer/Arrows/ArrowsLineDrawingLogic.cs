using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    static class ArrowsLineDrawingLogic
    {
        public static ContactPoint StartPoint;
        public static ContactPoint EndPoint;
        const int indentFromBorder = 50;
        static public Point[] Points { get; set; }

        private static TypeOfLineDirection kindOfLineSwithcer()
        {
            TypeOfLineDirection typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;

            if (StartPoint.Side == Side.Right)
            {
                if (EndPoint.Location.X >= StartPoint.Location.X + indentFromBorder)
                {
                    if (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)
                    {

                        if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Up)
                            || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Bottom))
                        {
                            typeOfLineDirection = TypeOfLineDirection.FivePointsFromRightToUpOfBottomLine;
                        }
                        else
                        {
                            typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangeleLeftRightLine;
                        }
                    }
                    else if (EndPoint.Side == Side.Right)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsFromRightToRight;
                    }
                    else
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;
                    }
                }
                else
                {
                    if (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromRightToUpOfBottomLineWithArounding;
                    }
                    else if (EndPoint.Side == Side.Right)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsFromRightToRightWithArounding;
                    }
                    else if (EndPoint.Side == Side.Left)
                    {
                        typeOfLineDirection = TypeOfLineDirection.SixPointsFromRightToLeftOfRightLineWithArounding;
                    }
                }
            }
            else if (StartPoint.Side == Side.Left)
            {
                if (EndPoint.Location.X <= StartPoint.Location.X - indentFromBorder)
                {
                    if (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)
                    {
                        if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Up)
                           || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Bottom))
                        {
                            typeOfLineDirection = TypeOfLineDirection.FivePointsFromRightToUpOfBottomLine;
                        }
                        else
                        {
                            typeOfLineDirection = TypeOfLineDirection.ThreePointsRectangeleLeftRightLine;
                        }
                    }
                    else if (EndPoint.Side == Side.Left)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsFromLeftToLeft;
                    }
                    else
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;
                    }
                }
                else
                {
                    if (EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromLeftToUpOfBottomLineWithArounding;
                    }
                    else if (EndPoint.Side == Side.Right)
                    {
                        typeOfLineDirection = TypeOfLineDirection.SixPointsFromLeftToRightOfLeftLineWithArounding;
                    }
                    else if (EndPoint.Side == Side.Left)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsFromLeftToLeftWithArounding;
                    }
                }
            }
            else if (StartPoint.Side == Side.Bottom)
            {
                if (EndPoint.Location.Y <= StartPoint.Location.Y + indentFromBorder)
                {
                    if (EndPoint.Side == Side.Right)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromButtonToRight;
                    }
                    else if (EndPoint.Side == Side.Left)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromButtonToLeft;
                    }
                    else if (EndPoint.Side == Side.Up)
                    {
                        typeOfLineDirection = TypeOfLineDirection.SixPointsFromLeftToRightOfLeftLineWithArounding;
                    }
                    else
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsFromBottomToBottom;
                    }
                }
                else
                {
                    if (EndPoint.Side == Side.Right)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromButtonToRight;
                    }
                    else if (EndPoint.Side == Side.Left)
                    {
                        typeOfLineDirection = TypeOfLineDirection.FivePointsFromButtonToLeft;
                    }
                    else
                    {
                        typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakUpDownLine;
                    }
                }
            }
            else if (StartPoint.Side == Side.Up)
            {
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

        public static Point[] GetPoints(ContactPoint startPoint, ContactPoint endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            int x;
            int y;
            int middleX = (StartPoint.Location.X + EndPoint.Location.X) / 2;
            int middleY = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;

            switch (kindOfLineSwithcer())
            {
                case TypeOfLineDirection.FourPointsZikzakLeftRightLine:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;

                    Points[1] = new Point(middleX, StartPoint.Location.Y);
                    Points[2] = new Point(middleX, EndPoint.Location.Y);
                    Points[Points.Length - 1] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsZikzakUpDownLine:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;

                    Points[1] = new Point(StartPoint.Location.X, middleY);
                    Points[2] = new Point(EndPoint.Location.X, middleY);
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

                case TypeOfLineDirection.FivePointsFromButtonToLeft:
                    Points = new Point[5];
                    Points[0] = startPoint.Location;
                    y = StartPoint.Location.Y + indentFromBorder;
                    Points[1] = new Point(StartPoint.Location.X, y);
                    x = EndPoint.Location.X - indentFromBorder;
                    Points[2] = new Point(x, y);
                    Points[3] = new Point(x, EndPoint.Location.Y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromButtonToRight:
                    Points = new Point[5];
                    Points[0] = startPoint.Location;
                    y = StartPoint.Location.Y + indentFromBorder;
                    Points[1] = new Point(StartPoint.Location.X, y);
                    x = EndPoint.Location.X + indentFromBorder;
                    if (endPoint.Location.X > StartPoint.Location.X)
                    {
                        Points[2] = new Point(x, y);
                        Points[3] = new Point(x, EndPoint.Location.Y);
                    }
                    else
                    {
                        Points[2] = new Point(middleX, y);
                        Points[3] = new Point(middleX, EndPoint.Location.Y);
                    }

                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromeButomToFlankLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y + indentFromBorder);
                    Points[2] = new Point(middleX, StartPoint.Location.Y + indentFromBorder);
                    Points[3] = new Point(middleX, EndPoint.Location.Y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromUpToFlankLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X, StartPoint.Location.Y - indentFromBorder);
                    Points[2] = new Point(middleX, StartPoint.Location.Y - indentFromBorder);
                    Points[3] = new Point(middleX, EndPoint.Location.Y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromLeftToBottomOrUpLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X - indentFromBorder, StartPoint.Location.Y);
                    Points[2] = new Point(StartPoint.Location.X - indentFromBorder, middleY);
                    Points[3] = new Point(EndPoint.Location.X, middleY);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromRightToUpOfBottomLine:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(middleX, StartPoint.Location.Y);
                    y = EndPoint.Location.Y < StartPoint.Location.Y
                        ? EndPoint.Location.Y - indentFromBorder : EndPoint.Location.Y + indentFromBorder;
                    Points[2] = new Point(middleX, y);
                    Points[3] = new Point(EndPoint.Location.X, y);
                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromRightToUpOfBottomLineWithArounding:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X + indentFromBorder, StartPoint.Location.Y);

                    if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Up)
                        || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Bottom))
                    {
                        y = EndPoint.Side == Side.Up ? EndPoint.Location.Y - indentFromBorder : EndPoint.Location.Y + indentFromBorder;
                        Points[2] = new Point(StartPoint.Location.X + indentFromBorder, y);
                        Points[3] = new Point(EndPoint.Location.X, y);
                    }

                    else if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Bottom)
                        || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Up))
                    {
                        Points[2] = new Point(StartPoint.Location.X + indentFromBorder, middleY);
                        Points[3] = new Point(EndPoint.Location.X, middleY);
                    }

                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FivePointsFromLeftToUpOfBottomLineWithArounding:
                    Points = new Point[5];
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(StartPoint.Location.X - indentFromBorder, StartPoint.Location.Y);

                    if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Up)
                        || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Bottom))
                    {
                        y = EndPoint.Side == Side.Up ? EndPoint.Location.Y - indentFromBorder : EndPoint.Location.Y + indentFromBorder;
                        Points[2] = new Point(StartPoint.Location.X - indentFromBorder, y);
                        Points[3] = new Point(EndPoint.Location.X, y);
                    }

                    else if ((EndPoint.Location.Y < StartPoint.Location.Y && EndPoint.Side == Side.Bottom)
                        || (EndPoint.Location.Y > StartPoint.Location.Y && EndPoint.Side == Side.Up))
                    {
                        Points[2] = new Point(StartPoint.Location.X - indentFromBorder, middleY);
                        Points[3] = new Point(EndPoint.Location.X, middleY);
                    }

                    Points[4] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.SixPointsFromRightToLeftOfRightLineWithArounding:
                    Points = new Point[6];

                    x = StartPoint.Location.X + indentFromBorder;
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, middleY);

                    x = EndPoint.Location.X - indentFromBorder;
                    Points[3] = new Point(x, middleY);
                    Points[4] = new Point(x, EndPoint.Location.Y);
                    Points[5] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.SixPointsFromBottomToUpRightSide:
                    Points = new Point[6];
                    Points[0] = StartPoint.Location;
                    y = StartPoint.Location.Y + indentFromBorder;
                    Points[1] = new Point(StartPoint.Location.X, y);
                    Points[2] = new Point(middleX,y);

                    x = EndPoint.Location.X + indentFromBorder;
                    Points[3] = new Point(x, middleY);
                    Points[4] = new Point(x, EndPoint.Location.Y);
                    Points[5] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.SixPointsFromLeftToRightOfLeftLineWithArounding:
                    Points = new Point[6];

                    x = StartPoint.Location.X - indentFromBorder;
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, middleY);

                    x = EndPoint.Location.X + indentFromBorder;
                    Points[3] = new Point(x, middleY);
                    Points[4] = new Point(x, EndPoint.Location.Y);
                    Points[5] = EndPoint.Location;
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
                    x = EndPoint.Location.X - indentFromBorder;
                    Points[0] = StartPoint.Location;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromLeftToLeftWithArounding:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    x = StartPoint.Location.X - indentFromBorder;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromRightToRightWithArounding:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    x = StartPoint.Location.X + indentFromBorder;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;

                case TypeOfLineDirection.FourPointsFromRightToRight:
                    Points = new Point[4];
                    Points[0] = StartPoint.Location;
                    x = EndPoint.Location.X + indentFromBorder;
                    Points[1] = new Point(x, StartPoint.Location.Y);
                    Points[2] = new Point(x, EndPoint.Location.Y);
                    Points[3] = EndPoint.Location;
                    break;
            }

            return Points;
        }
    }
}

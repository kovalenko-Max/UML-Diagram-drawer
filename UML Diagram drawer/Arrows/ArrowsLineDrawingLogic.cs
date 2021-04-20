﻿using System;
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


            //////_____________________________________________________________________

            else if (StartPoint.Side == Side.Left)
            {
                //typeOfLineDirection = TypeOfLineDirection.FourPointsZikzakLeftRightLine;
                if (EndPoint.Location.X <= StartPoint.Location.X + indentFromBorder)
                {
                    if(EndPoint.Side == Side.Up || EndPoint.Side == Side.Bottom)
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
                    else if(EndPoint.Side == Side.Left)
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
                    //typeOfLineDirection = TypeOfLineDirection.FivePointsFromLeftToBottomOrUpLine;
                }
            }

            //////__________________________________________________________________________
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
                if (EndPoint.Location == Point.Empty)
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

        public static Point[] GetPoints(ContactPoint startPoint, ContactPoint endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            int x;
            int y;
            int middleX = (StartPoint.Location.X + EndPoint.Location.X) / 2;
            int middleY = (StartPoint.Location.Y + EndPoint.Location.Y) / 2;
            
            switch (kindOfLineSwithcer())
            //switch (TypeOfLineDirection.ThreePointsRectangeleLeftRightLine)
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

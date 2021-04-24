using System.Drawing;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    static class ArrowsLineDrawingLogic
    {
        const int indentFromBorder = 50;
        public static Point[] GetPoints(ContactPoint startPoint, ContactPoint endPoint)
        {
            int x;
            int y;
            int middleX = (startPoint.Location.X + endPoint.Location.X) / 2;
            int middleY = (startPoint.Location.Y + endPoint.Location.Y) / 2;
            Point[] Points = new Point[3];

            if (startPoint.Side == Side.Right)
            {
                if (endPoint.Location.X >= startPoint.Location.X + indentFromBorder)
                {
                    if (endPoint.Side == Side.Up || endPoint.Side == Side.Bottom)
                    {

                        if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Up)
                            || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Bottom))
                        {
                            Points = new Point[5];
                            Points[0] = startPoint.Location;
                            Points[1] = new Point(middleX, startPoint.Location.Y);
                            y = endPoint.Location.Y < startPoint.Location.Y
                                ? endPoint.Location.Y - indentFromBorder : endPoint.Location.Y + indentFromBorder;
                            Points[2] = new Point(middleX, y);
                            Points[3] = new Point(endPoint.Location.X, y);
                            Points[4] = endPoint.Location;
                        }
                        else
                        {
                            Points = new Point[3];
                            Points[0] = startPoint.Location;
                            Points[1] = new Point(endPoint.Location.X, startPoint.Location.Y);
                            Points[Points.Length - 1] = endPoint.Location;
                        }
                    }
                    else if (endPoint.Side == Side.Right)
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        x = endPoint.Location.X + indentFromBorder;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, endPoint.Location.Y);
                        Points[3] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;

                        Points[1] = new Point(middleX, startPoint.Location.Y);
                        Points[2] = new Point(middleX, endPoint.Location.Y);
                        Points[Points.Length - 1] = endPoint.Location;
                    }
                }
                else
                {
                    if (endPoint.Side == Side.Up || endPoint.Side == Side.Bottom)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X + indentFromBorder, startPoint.Location.Y);

                        if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Up)
                            || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Bottom))
                        {
                            y = endPoint.Side == Side.Up ? endPoint.Location.Y - indentFromBorder : endPoint.Location.Y + indentFromBorder;
                            Points[2] = new Point(startPoint.Location.X + indentFromBorder, y);
                            Points[3] = new Point(endPoint.Location.X, y);
                        }

                        else if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Bottom)
                            || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Up))
                        {
                            Points[2] = new Point(startPoint.Location.X + indentFromBorder, middleY);
                            Points[3] = new Point(endPoint.Location.X, middleY);
                        }

                        Points[4] = endPoint.Location;

                    }
                    else if (endPoint.Side == Side.Right)
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        x = startPoint.Location.X + indentFromBorder;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, endPoint.Location.Y);
                        Points[3] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[6];

                        x = startPoint.Location.X + indentFromBorder;
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, middleY);

                        x = endPoint.Location.X - indentFromBorder;
                        Points[3] = new Point(x, middleY);
                        Points[4] = new Point(x, endPoint.Location.Y);
                        Points[5] = endPoint.Location;
                    }
                }
            }
            else if (startPoint.Side == Side.Left)
            {
                if (endPoint.Location.X <= startPoint.Location.X - indentFromBorder)
                {
                    if (endPoint.Side == Side.Up || endPoint.Side == Side.Bottom)
                    {
                        if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Up)
                           || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Bottom))
                        {
                            Points = new Point[5];
                            Points[0] = startPoint.Location;
                            Points[1] = new Point(middleX, startPoint.Location.Y);
                            y = endPoint.Location.Y < startPoint.Location.Y
                                ? endPoint.Location.Y - indentFromBorder : endPoint.Location.Y + indentFromBorder;
                            Points[2] = new Point(middleX, y);
                            Points[3] = new Point(endPoint.Location.X, y);
                            Points[4] = endPoint.Location;
                        }
                        else
                        {
                            Points = new Point[3];
                            Points[0] = startPoint.Location;
                            Points[1] = new Point(endPoint.Location.X, startPoint.Location.Y);
                            Points[Points.Length - 1] = endPoint.Location;
                        }
                    }
                    else if (endPoint.Side == Side.Left)
                    {
                        Points = new Point[4];
                        x = endPoint.Location.X - indentFromBorder;
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, endPoint.Location.Y);
                        Points[3] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;

                        Points[1] = new Point(middleX, startPoint.Location.Y);
                        Points[2] = new Point(middleX, endPoint.Location.Y);
                        Points[Points.Length - 1] = endPoint.Location;
                    }
                }
                else
                {
                    if (endPoint.Side == Side.Up || endPoint.Side == Side.Bottom)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X - indentFromBorder, startPoint.Location.Y);

                        if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Up)
                            || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Bottom))
                        {
                            y = endPoint.Side == Side.Up ? endPoint.Location.Y - indentFromBorder : endPoint.Location.Y + indentFromBorder;
                            Points[2] = new Point(startPoint.Location.X - indentFromBorder, y);
                            Points[3] = new Point(endPoint.Location.X, y);
                        }

                        else if ((endPoint.Location.Y < startPoint.Location.Y && endPoint.Side == Side.Bottom)
                            || (endPoint.Location.Y > startPoint.Location.Y && endPoint.Side == Side.Up))
                        {
                            Points[2] = new Point(startPoint.Location.X - indentFromBorder, middleY);
                            Points[3] = new Point(endPoint.Location.X, middleY);
                        }

                        Points[4] = endPoint.Location;

                    }
                    else if (endPoint.Side == Side.Right)
                    {
                        Points = new Point[6];

                        x = startPoint.Location.X - indentFromBorder;
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, middleY);

                        x = endPoint.Location.X + indentFromBorder;
                        Points[3] = new Point(x, middleY);
                        Points[4] = new Point(x, endPoint.Location.Y);
                        Points[5] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        x = startPoint.Location.X - indentFromBorder;
                        Points[1] = new Point(x, startPoint.Location.Y);
                        Points[2] = new Point(x, endPoint.Location.Y);
                        Points[3] = endPoint.Location;
                    }
                }
            }
            else if (startPoint.Side == Side.Bottom)
            {
                if (endPoint.Location.Y > startPoint.Location.Y)
                {
                    if (endPoint.Side == Side.Left || endPoint.Side == Side.Right)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X, middleY);
                        x = endPoint.Side == Side.Left ? endPoint.Location.X - indentFromBorder : endPoint.Location.X + indentFromBorder;
                        Points[2] = new Point(x, middleY);
                        Points[3] = new Point(x, endPoint.Location.Y);
                        Points[4] = endPoint.Location;
                    }
                    else if (endPoint.Side == Side.Bottom)
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        y = endPoint.Location.Y + indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(endPoint.Location.X, y);
                        Points[3] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X, middleY);
                        Points[2] = new Point(endPoint.Location.X, middleY);
                        Points[3] = endPoint.Location;
                    }
                }
                else
                {
                    if (endPoint.Side == Side.Left || endPoint.Side == Side.Right)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y + indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        x = endPoint.Side == Side.Left ? endPoint.Location.X - indentFromBorder : endPoint.Location.X + indentFromBorder;
                        Points[2] = new Point(x, y);
                        Points[3] = new Point(x, endPoint.Location.Y);
                        Points[4] = endPoint.Location;
                    }
                    else if (endPoint.Side == Side.Up)
                    {
                        Points = new Point[6];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y + indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(middleX, y);
                        y = endPoint.Location.Y - indentFromBorder;
                        Points[3] = new Point(middleX, y);
                        Points[4] = new Point(endPoint.Location.X, y);
                        Points[5] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y + indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(endPoint.Location.X, y);
                        Points[3] = endPoint.Location;
                    }
                }
            }
            else if (startPoint.Side == Side.Up)
            {
                if (endPoint.Location.Y < startPoint.Location.Y)
                {
                    if (endPoint.Side == Side.Left || endPoint.Side == Side.Right)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X, middleY);
                        x = endPoint.Side == Side.Left ? endPoint.Location.X - indentFromBorder : endPoint.Location.X + indentFromBorder;
                        Points[2] = new Point(x, middleY);
                        Points[3] = new Point(x, endPoint.Location.Y);
                        Points[4] = endPoint.Location;
                    }
                    else if (endPoint.Side == Side.Up)
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        y = endPoint.Location.Y - indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(endPoint.Location.X, y);
                        Points[3] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        Points[1] = new Point(startPoint.Location.X, middleY);
                        Points[2] = new Point(endPoint.Location.X, middleY);
                        Points[3] = endPoint.Location;
                    }
                }
                else
                {
                    if (endPoint.Side == Side.Left || endPoint.Side == Side.Right)
                    {
                        Points = new Point[5];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y - indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        x = endPoint.Side == Side.Left ? endPoint.Location.X - indentFromBorder : endPoint.Location.X + indentFromBorder;
                        Points[2] = new Point(x, y);
                        Points[3] = new Point(x, endPoint.Location.Y);
                        Points[4] = endPoint.Location;
                    }
                    else if (endPoint.Side == Side.Bottom)
                    {
                        Points = new Point[6];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y - indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(middleX, y);
                        y = endPoint.Location.Y + indentFromBorder;
                        Points[3] = new Point(middleX, y);
                        Points[4] = new Point(endPoint.Location.X, y);
                        Points[5] = endPoint.Location;
                    }
                    else
                    {
                        Points = new Point[4];
                        Points[0] = startPoint.Location;
                        y = startPoint.Location.Y - indentFromBorder;
                        Points[1] = new Point(startPoint.Location.X, y);
                        Points[2] = new Point(endPoint.Location.X, y);
                        Points[3] = endPoint.Location;
                    }
                }
            }

            return Points;
        }
    }
}
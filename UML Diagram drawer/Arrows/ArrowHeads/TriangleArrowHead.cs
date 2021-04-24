using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_drawer.Arrows.ArrowHeads
{
    public class TriangleArrowHead : IArrowHead
    {
        public void Draw(Pen pen, Point endPoint, Point preEndPoint)
        {
            DashStyle currentDashStyle = pen.DashStyle;
            pen.DashStyle = DashStyle.Solid;
            Point[] arrowHeadPoints = new Point[3];

            if (!preEndPoint.IsEmpty && !endPoint.IsEmpty)
            {
                Point eraseEndPoint;
                int _sizeArrowhead = (int)pen.Width * 3;

                if (preEndPoint.Y == endPoint.Y)
                {
                    if (preEndPoint.X < endPoint.X)
                    {
                        eraseEndPoint = new Point(endPoint.X - _sizeArrowhead, endPoint.Y);
                        arrowHeadPoints[0] = endPoint;
                        arrowHeadPoints[1] = new Point(endPoint.X - _sizeArrowhead, endPoint.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(endPoint.X - _sizeArrowhead, endPoint.Y - _sizeArrowhead);
                    }
                    else
                    {
                        eraseEndPoint = new Point(endPoint.X + _sizeArrowhead, endPoint.Y);
                        arrowHeadPoints[0] = endPoint;
                        arrowHeadPoints[1] = new Point(endPoint.X + _sizeArrowhead, endPoint.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(endPoint.X + _sizeArrowhead, endPoint.Y - _sizeArrowhead);
                    }
                }
                else
                {
                    if (preEndPoint.Y < endPoint.Y)
                    {
                        eraseEndPoint = new Point(endPoint.X, endPoint.Y - _sizeArrowhead);
                        arrowHeadPoints[0] = endPoint;
                        arrowHeadPoints[1] = new Point(endPoint.X + _sizeArrowhead, endPoint.Y - _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(endPoint.X - _sizeArrowhead, endPoint.Y - _sizeArrowhead);
                    }
                    else
                    {
                        eraseEndPoint = new Point(endPoint.X, endPoint.Y + _sizeArrowhead);
                        arrowHeadPoints[0] = endPoint;
                        arrowHeadPoints[1] = new Point(endPoint.X + _sizeArrowhead, endPoint.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(endPoint.X - _sizeArrowhead, endPoint.Y + _sizeArrowhead);
                    }
                }

                Pen erasePen = new Pen(MainData.GetMainData().PictureBoxMain.BackColor, _sizeArrowhead);
                MainGraphics.Graphics.DrawLine(erasePen, endPoint, eraseEndPoint);
                MainGraphics.Graphics.DrawPolygon(pen, arrowHeadPoints);
            }
            pen.DashStyle = currentDashStyle;
        }
    }
}